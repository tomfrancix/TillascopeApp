import { Blueprint } from "./blueprint.model";
import { Rating } from "./rating.model";
import { Images } from "./image.model";

export class Product {
  constructor(
    public productId?: number,
    public category?: string,
    public subcategory?: string,
    public description?: string,
    public additionalinfo?: string,
    public ImageIcon?: string,
    public quantity?: number,
    public price?: number,
    public blueprint?: Blueprint,
    public ratings?: Rating[],
    public images?: Images[]
  ) { }
}
