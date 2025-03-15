import { Injectable } from '@angular/core';
import { Actions, ofType, createEffect } from '@ngrx/effects';
import { HttpClient } from '@angular/common/http';
import { catchError, map, switchMap, mergeMap } from 'rxjs/operators';
import { of } from 'rxjs';
import { 
    loadProducts, loadProductsSuccess, loadProductsFailure, 
    deleteProduct, deleteProductSuccess, deleteProductFailure, 
    addProduct, addProductSuccess, addProductFailure 
} from './product.actions';
import { Product } from './product.model';

@Injectable()
export class ProductEffects {
    constructor(private actions$: Actions, private http: HttpClient) {}

    loadProducts$ = createEffect(() =>
        this.actions$.pipe(
            ofType(loadProducts),
            mergeMap(() =>
                this.http.get<Product[]>('http://localhost:5222/api/product').pipe(
                    map((products) => loadProductsSuccess({ products })),
                    catchError((error) => of(loadProductsFailure({ error: error.message })))
                )
            )
        )
    );

    deleteProduct$ = createEffect(() =>
        this.actions$.pipe(
            ofType(deleteProduct),
            mergeMap(({ id }) =>
                this.http.delete(`http://localhost:5222/api/product/${id}`).pipe(
                    map(() => deleteProductSuccess({ id })),
                    catchError((error) => of(deleteProductFailure({ error: error.message })))
                )
            )
        )
    );

    addProduct$ = createEffect(() =>
        this.actions$.pipe(
            ofType(addProduct),
            switchMap(({ product }) =>
                this.http.post<Product>('http://localhost:5222/api/product', product, {
                    headers: { 'Content-Type': 'application/json' }
                }).pipe(
                    map((newProduct) => addProductSuccess({ product: newProduct })),
                    catchError((error) => of(addProductFailure({ error: error.message })))
                )
            )
        )
    );
}
