/// <reference types='cypress-xpath' />

export class HomePage {
  //Locators
  btnAddToCart = () => cy.get(".btn-success");

  //Functions
  addToCart() {
    this.btnAddToCart().should("exist");
    this.btnAddToCart().click();
  }
}