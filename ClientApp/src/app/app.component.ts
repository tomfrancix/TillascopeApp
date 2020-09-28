import { Component } from '@angular/core';
import { Repository } from "./models/repository";
import { Product } from "./models/product.model";
import { Blueprint } from "./models/blueprint.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'TillascopeApp';

  constructor(private repo: Repository) { }

  get product(): Product {
    return this.repo.product;
  }

  get products(): Product[] {
    return this.repo.products;
  }

  createProduct() {
    this.repo.createProduct(new Product(0, "Stage", "New Product", "description", "additional", "arthur1.jpg", 10, 45, this.repo.products[0].blueprint));
  }

  createProductAndBlueprint() {
    let s = new Blueprint(0, "New Range", "ad", "asdf", "asdf", "arthur1.jpg");
    let p = new Product(0, "Stage", "New Product", "asdf", "asdf", "arthur1.jpg", 10, 45, s);
    this.repo.createProductAndBlueprint(p, s);
  }

  replaceProduct() {
    let p = this.repo.products[0];
    p.category = "Modified Category";
    p.subcategory = "Modified Subcategory";
    this.repo.replaceProduct(p);
  }
  replaceBlueprint() {
    let s = new Blueprint(3, "Modified Title", "new", "new");
    this.repo.replaceBlueprint(s);
  }
  updateProduct() {
    let changes = new Map<string, any>();
    changes.set("subcategory", "Green Kayak");
    changes.set("blueprint", null);
    this.repo.updateProduct(1, changes);
  }

  deleteProduct() {
    this.repo.deleteProduct(1);
  }

  deleteBlueprint() {
    this.repo.deleteBlueprint(2);
  }
}
