import { NgModule } from "@angular/core";
import { BrowserModule } from '@angular/platform-browser';
import { CartSummaryComponent } from "./cartSummary.component";
import { CategoryFilterComponent } from "./categoryFilter.component";
import { PaginationComponent } from "./pagination.component";
import { ProductListComponent } from "./productList.component";
import { RatingsComponent } from "./ratings.component";
import { ProductSelectionComponent } from "./productSelection.component";
import { CartDetailComponent } from "./cartDetail.component";
import { FormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { ProductDetailComponent } from "./productDetail.component";
import { NavigationComponent } from "./navigation.component";
import { AboutComponent } from "./about.component";
import { HomeComponent } from "./home.component";
import { PolicyComponent } from "./policy.component";

@NgModule({
    declarations: [CartSummaryComponent, CategoryFilterComponent,
    PaginationComponent, ProductListComponent, RatingsComponent,
    ProductSelectionComponent, ProductDetailComponent, CartDetailComponent, NavigationComponent, AboutComponent, HomeComponent, PolicyComponent],
    imports: [BrowserModule, FormsModule, RouterModule],
    exports: [ProductSelectionComponent]
})
export class StoreModule { }
