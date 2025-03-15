
import { createAction, props } from "@ngrx/store";
import { Product } from "./product.model";


// Loading Actions 
export const loadProducts = createAction('[Product List Component] Load Products');
export const loadProductsSuccess = createAction('[Product API] Load Products Success',
    props<{ products: Product[] }>()
);
debugger;


export const loadProductsFailure = createAction(
    '[Product API] Load Products Failure',
    props<{ error: string }>()
);



// Delete Product Actions
export const deleteProduct = createAction(
    '[Product List Component] Delete Product',
    props<{ id: number }>()
);

export const deleteProductSuccess = createAction(
    '[Product API] Delete Product Success',
    props<{ id: number }>()
);

export const deleteProductFailure = createAction(
    '[Product API] Delete Product Failure',
    props<{ error: string }>()
);


// Add Product Actions
export const addProduct = createAction(
    '[Product List Component] Add Product',
    props<{ product: Product }>()
);


export const addProductSuccess = createAction(
    '[Product API] Add Product Success',
    props<{ product: Product }>()
);


export const addProductFailure = createAction(
    '[Product API] Add Product Failure',
    props<{ error: string }>()
);