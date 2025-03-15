import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule, FormsModule } from '@angular/forms';
import { loadProducts, addProduct, deleteProduct } from '../states/product/product.actions';
import { Product } from '../states/product/product.model';
import { selectLoading, selectError, selectAllProducts } from '../states/product/product.selectors';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, FormsModule],  // ✅ Import necessary modules
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
})
export class ProductListComponent implements OnInit {
  products$: Observable<Product[]>;
  loading$: Observable<boolean>;
  error$: Observable<string | null>;
  productForm: FormGroup;  

  constructor(private store: Store, private fb: FormBuilder) {
    this.products$ = this.store.select(selectAllProducts);
    this.loading$ = this.store.select(selectLoading);
    this.error$ = this.store.select(selectError);

    
    this.productForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      price: [null, [Validators.required, Validators.min(0)]]
    });
  }

  ngOnInit() {
    this.store.dispatch(loadProducts());
  }

  onSubmit() {
    if (this.productForm.valid) {
      const formValue = this.productForm.value;

      
      const newProduct: Product = {
        id: 0, // Will be assigned by database
        name: formValue['name'],  
        description: formValue['description'],
        price: formValue['price']
      };

   

      this.store.dispatch(addProduct({ product: newProduct }));
      this.productForm.reset();
    }
  }

  onDelete(id: number) {
    this.store.dispatch(deleteProduct({ id }));
  }
}
