import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
//import { ProductTableComponent } from "./structure/productTable.component";
//import { ProductDetailComponent } from './structure/productDetail.component';
import { ProductDetailComponent } from './store/productDetail.component';
import { CartDetailComponent } from './store/cartDetail.component';
import { ProductSelectionComponent } from "./store/productSelection.component";
import { AboutComponent } from "./store/about.component";
import { HomeComponent } from "./store/home.component";
import { PolicyComponent } from "./store/policy.component";



const routes: Routes = [
  //{ path: "table", component: ProductTableComponent },
  //{ path: "", component: ProductTableComponent }
  { path: "cart", component: CartDetailComponent },
  { path: "about", component: AboutComponent },
  { path: "home", component: HomeComponent },
  { path: "policy", component: PolicyComponent },
  { path: "store/:subcategory/:page", component: ProductSelectionComponent },
  { path: "store/:subcategoryOrPage", component: ProductSelectionComponent },
  //{ path: "store/:subcategory", component: ProductSelectionComponent },
  { path: "store", component: ProductSelectionComponent },
  { path: "detail", component: ProductDetailComponent },
  { path: "detail/:id", component: ProductDetailComponent },
  { path: "", redirectTo: "/store", pathMatch: "full" }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
