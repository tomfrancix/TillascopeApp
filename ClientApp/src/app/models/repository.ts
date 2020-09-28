import { Product } from "./product.model";
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Filter, Pagination } from "./configClasses.repository";
import { Blueprint } from "./blueprint.model";
import { Observable } from "rxjs";

const productsUrl = "/api/products";
const blueprintUrl = "/api/blueprint";
const sessionUrl = "/api/session";

type productsMetadata = {
  data: Product[],
  subcategories: string[];
}

@Injectable()
export class Repository {

  product: Product;
  products: Product[];
  blueprints: Blueprint[] = [];
  filter: Filter = new Filter();
  subcategories: string[] = [];
  paginationObject = new Pagination();

  constructor(private http: HttpClient) {
    //this.filter.subcategory = "antonio";
    this.filter.related = true;
    //this.getProducts();
  }

  getProduct(id: number) {
    this.http.get<Product>(`${productsUrl}/${id}`).subscribe(p => this.product = p);
  }

  getProducts(related = false) {
    let url = `${productsUrl}?related=${this.filter.related}`;

    if (this.filter.subcategory) {
      url += `&subcategory=${this.filter.subcategory}`;
    }
    if (this.filter.search) {
      url += `&search=${this.filter.search}`;
    }

    url += "&metadata=true";

    this.http.get<productsMetadata>(url).subscribe(md => {
      this.products = md.data;
      this.subcategories = md.subcategories;
    });
  }
  getBlueprints() {
    this.http.get<Blueprint[]>(blueprintUrl).subscribe(sups => this.blueprints = sups);
  }

  createProduct(prod: Product) {
    let data = {
      category: prod.category, subcategory: prod.subcategory, description: prod.description, additionalinfo: prod.additionalinfo, imageIcon: prod.ImageIcon, quantity: prod.quantity, price: prod.price,
      blueprint: prod.blueprint ? prod.blueprint.blueprintId : 0
    };
    this.http.post<number>(productsUrl, data).subscribe(id => {
      prod.productId = id;
      this.products.push(prod);
    });
  }

  createProductAndBlueprint(prod: Product, supp: Blueprint) {
    let data = {
      title: supp.title, summary: supp.summary, description: supp.description, additionalinfo: supp.additionalinfo, image: supp.image
    };

    this.http.post<number>(blueprintUrl, data).subscribe(id => {
      supp.blueprintId = id;
      prod.blueprint = supp;
      this.blueprints.push(supp);
      if (prod != null) {
        this.createProduct(prod);
      }
    });
  }

  replaceProduct(prod: Product) {
    let data = {
      category: prod.category, subcategory: prod.subcategory, description: prod.description, additionalinfo: prod.additionalinfo, imageIcon: prod.ImageIcon, quantity: prod.quantity, price: prod.price,
      blueprint: prod.blueprint ? prod.blueprint.blueprintId : 0
    };
    this.http.put(`${productsUrl}/${prod.productId}`, data).subscribe(() => this.getProducts());
  }

  replaceBlueprint(supp: Blueprint) {
    let data = {
      title: supp.title, summary: supp.summary, description: supp.description, additionalinfo: supp.additionalinfo, image: supp.image
    };
    this.http.put(`${blueprintUrl}/${supp.blueprintId}`, data).subscribe(() => this.getProducts());
  }

  updateProduct(id: number, changes: Map<string, any>) {
    let patch = [];
    changes.forEach((value, key) =>
      patch.push({ op: "replace", path: key, value: value }));
    this.http.patch(`${productsUrl}/${id}`, patch)
      .subscribe(() => this.getProducts());
  }

  deleteProduct(id: number) {
    this.http.delete(`${productsUrl}/${id}`)
      .subscribe(() => this.getProducts());
  }

  deleteBlueprint(id: number) {
    this.http.delete(`${blueprintUrl}/${id}`)
      .subscribe(() => {
        this.getProducts();
        this.getBlueprints();
      });
  }

  storeSessionData<T>(dataType: string, data: T) {
    return this.http.post(`${sessionUrl}/${dataType}`, data)
      .subscribe(response => { });
  }

  getSessionData<T>(dataType: string): Observable<T> {
    return this.http.get<T>(`${sessionUrl}/${dataType}`);
  }
}
