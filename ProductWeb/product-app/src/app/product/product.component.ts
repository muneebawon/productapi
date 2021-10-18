import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor(private service:ProductService) { }

  ProductList:any=[];

  ngOnInit(): void {
    this.loadProductList();
  }

  loadProductList() {
    this.service.getProductList().subscribe((data:any[]) => {
      this.ProductList = data;
    });
  }

}
