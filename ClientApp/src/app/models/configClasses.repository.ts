export class Filter {
  subcategory?: string;
  search?: string;
  related: boolean = false;

  reset() {
    this.subcategory = this.search = null;
    this.related = false;
  }
}

export class Pagination {

  productsPerPage: number = 20;
  currentPage = 1;
}
