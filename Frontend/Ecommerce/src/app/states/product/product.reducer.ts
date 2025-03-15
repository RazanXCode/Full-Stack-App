import { createReducer, on } from '@ngrx/store';
import { Product } from './product.model';
import { loadProducts, loadProductsSuccess, loadProductsFailure  , deleteProduct , deleteProductSuccess , deleteProductFailure,addProduct, addProductSuccess,addProductFailure} from './product.actions';

export interface ProductState {
  products: Product[];
  loading: boolean;
  error: string | null;
}

export const initialProductState: ProductState = {
  products: [],
  loading: false,
  error: null,
};

export const productReducer = createReducer(
  initialProductState,
  on(loadProducts, (state) => ({
    ...state,
    loading: true,
  })),
  on(loadProductsSuccess, (state, { products }) => ({
    ...state,
    loading: false,
    products,
  })),
  on(loadProductsFailure, (state, { error }) => ({
    ...state,
    loading: false,
    error,
  })),

  
   on(deleteProduct, (state) => ({
    ...state,
    loading: true,
})),
on(deleteProductSuccess, (state, { id }) => ({
    ...state,
    loading: false,
    products: state.products.filter(product => product.id !== id),
})),
on(deleteProductFailure, (state, { error }) => ({
    ...state,
    loading: false,
    error,
})),
on(addProduct, (state) => ({
  ...state,
  loading: true,
})),
on(addProductSuccess, (state, { product }) => ({
  ...state,
  loading: false,
  products: [...state.products, product], 
})),
on(addProductFailure, (state, { error }) => ({
  ...state,
  loading: false,
  error,
}))
);