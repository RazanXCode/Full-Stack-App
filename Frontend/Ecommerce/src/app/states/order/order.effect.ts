import { Injectable } from '@angular/core';
import { Actions, ofType, createEffect } from '@ngrx/effects';
import { HttpClient } from '@angular/common/http';
import { catchError, map, mergeMap } from 'rxjs/operators';
import { of } from 'rxjs';
import { loadOrders, loadOrdersSuccess, loadOrdersFailure, addOrder, addOrderSuccess, addOrderFailure, deleteOrder, deleteOrderSuccess, deleteOrderFailure } from './order.actions';
import { Order } from './order.model';

@Injectable()
export class OrderEffects {
  constructor(private actions$: Actions, private http: HttpClient) {}

  // Load Orders
  loadOrders$ = createEffect(() =>
    this.actions$.pipe(
      ofType(loadOrders),
      mergeMap(() =>
        this.http.get<Order[]>('http://localhost:5234/api/order').pipe(
          map((orders) => loadOrdersSuccess({ orders })),
          catchError((error) => of(loadOrdersFailure({ error: error.message })))
        )
      )
    )
  );

  // Add Order
  addOrder$ = createEffect(() =>
    this.actions$.pipe(
      ofType(addOrder),
      mergeMap(({ order }) =>
        this.http.post<Order>('http://localhost:5234/api/order', order).pipe(
          map((newOrder) => addOrderSuccess({ order: newOrder })),
          catchError((error) => of(addOrderFailure({ error: error.message })))
        )
      )
    )
  );

  // Delete Order
  deleteOrder$ = createEffect(() =>
    this.actions$.pipe(
      ofType(deleteOrder),
      mergeMap(({ id }) =>
        this.http.delete(`http://localhost:5234/api/order/${id}`).pipe(
          map(() => deleteOrderSuccess({ id })),
          catchError((error) => of(deleteOrderFailure({ error: error.message })))
        )
      )
    )
  );
}
