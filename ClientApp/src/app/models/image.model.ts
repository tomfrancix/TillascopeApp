import { Product } from "./product.model";

export class Images {
  constructor(
    public imageId?: number,
    public alt?: string,
    public imageIcon?: string,
    public product?: Product
  ) { }
}
