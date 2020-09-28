import { Injectable } from "@angular/core";
import { Router, ActivatedRoute, NavigationEnd } from "@angular/router";
import { Repository } from '../models/repository';
import { filter } from "rxjs/operators";

@Injectable()
export class NavigationService {

    constructor(private repository: Repository, private router: Router,
            private active: ActivatedRoute) {
        router.events
            .pipe(filter(event => event instanceof NavigationEnd))
            .subscribe(ev => this.handleNavigationChange());
    }

    private handleNavigationChange() {
        let active = this.active.firstChild.snapshot;
      if (active.url.length > 0 && active.url[0].path === "store") {
        //let subcategory = active.params["subcategory"];
        //this.repository.filter.subcategory = subcategory || "";
        
            if (active.params["subcategoryOrPage"] !== undefined) {
                let value = Number.parseInt(active.params["subcategoryOrPage"]);
                if (!Number.isNaN(value)) {
                    this.repository.filter.subcategory = "";
                    this.repository.paginationObject.currentPage = value;
                } else {
                    this.repository.filter.subcategory 
                        = active.params["subcategoryOrPage"];
                    this.repository.paginationObject.currentPage = 1;
                }
            } else {
                let subcategory = active.params["subcategory"];
                this.repository.filter.subcategory = subcategory || "";
                this.repository.paginationObject.currentPage
                    = Number.parseInt(active.params["page"]) || 1
            }
            this.repository.getProducts();
        }
    }

    get subcategories(): string[] {
        return this.repository.subcategories;
    }

    get currentCategory(): string {
        return this.repository.filter.subcategory;
    }

    set currentCategory(newCategory: string) {
        this.router.navigateByUrl(`/store/${(newCategory || "").toLowerCase()}`);
    }

    get currentPage(): number {
        return this.repository.paginationObject.currentPage;
    }
  //set details(id: number) {
  //  this.router.navigateByUrl(`/details/${id}`);
  //}
    set currentPage(newPage: number) {
        if (this.currentCategory === "") {
            this.router.navigateByUrl(`/store/${newPage}`);
        } else {
            this.router.navigateByUrl(`/store/${this.currentCategory}/${newPage}`);
        }
    }

    get productsPerPage(): number {
        return this.repository.paginationObject.productsPerPage;
    }

    get productCount(): number {
        return (this.repository.products || []).length;
    }
}
