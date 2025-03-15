import { createReducer, on } from '@ngrx/store';
import { Order } from './order.model';
import { loadOrdersSuccess, loadOrdersFailure, addOrderSuccess, addOrderFailure, deleteOrderSuccess, deleteOrderFailure } from './order.actions';

export interface OrderState {
  orders: Order[];
  loading: boolean;
  error: string | null;
}

export const initialState: OrderState = {
  orders: [],
  loading: false,
  error: null,
};

export const orderReducer = createReducer(
  initialState,
  on(loadOrdersSuccess, (state, { orders }) => ({
    ...state,
    orders,
    loading: false,
  })),
  on(loadOrdersFailure, (state, { error }) => ({
    ...state,
    error,
    loading: false,
  })),
  on(addOrderSuccess, (state, { order }) => ({
    ...state,
    orders: [...state.orders, order],
  })),
  on(addOrderFailure, (state, { error }) => ({
    ...state,
    error,
  })),
  on(deleteOrderSuccess, (state, { id }) => ({
    ...state,
    orders: state.orders.filter(order => order.id !== id),
  })),
  on(deleteOrderFailure, (state, { error }) => ({
    ...state,
    error,
  }))
);
