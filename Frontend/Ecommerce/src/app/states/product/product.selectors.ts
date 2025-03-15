import { createFeatureSelector, createSelector } from '@ngrx/store';
import { ProductState } from './product.reducer';

export const selectProductFeature = createFeatureSelector<ProductState>('products');

export const selectAllProducts = createSelector(
    selectProductFeature,
    (state: ProductState) => {
        return state?.products ?? [];
    }
);

export const selectLoading = createSelector(
    selectProductFeature,
    (state: ProductState) => state?.loading ?? false
);

export const selectError = createSelector(
    selectProductFeature,
    (state: ProductState) => state?.error ?? null
);