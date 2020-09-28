import { Component } from '@angular/core';
import { Repository } from "../models/repository";

@Component({
    selector: "category-filter",
    templateUrl: "categoryFilter.component.html"
})
export class CategoryFilterComponent {
    public chessCategory = "albert";

    constructor(private repo: Repository) { }

    setCategory(subcategory: string) {
        this.repo.filter.subcategory = subcategory;
        this.repo.getProducts();
    }
}
