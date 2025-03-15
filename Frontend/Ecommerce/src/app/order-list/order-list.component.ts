import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { loadOrders, deleteOrder, addOrder } from '../states/order/order.actions';
import { selectAllOrders, selectLoading, selectError } from '../states/order/order.selectors';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Order } from '../states/order/order.model';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-order-list',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,FormsModule],
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css'],
})
export class OrderListComponent implements OnInit {
  orders$: Observable<Order[]>;
  loading$: Observable<boolean>;
  error$: Observable<string | null>;
  orderForm: FormGroup;

  constructor(private store: Store, private fb: FormBuilder) {
    this.orders$ = this.store.select(selectAllOrders);
    this.loading$ = this.store.select(selectLoading);
    this.error$ = this.store.select(selectError);
    this.orderForm = this.fb.group({
      status: ['', Validators.required],
      totalAmount: [null, [Validators.required, Validators.min(0)]],
    });
  }

  ngOnInit() {
    this.store.dispatch(loadOrders());
  }

  onDelete(id: number) {
    this.store.dispatch(deleteOrder({ id }));
  }

  onSubmit() {
    if (this.orderForm.valid) {
      const newOrder: Order = this.orderForm.value;
      this.store.dispatch(addOrder({ order: newOrder }));
      this.orderForm.reset();
    }
  }
}
