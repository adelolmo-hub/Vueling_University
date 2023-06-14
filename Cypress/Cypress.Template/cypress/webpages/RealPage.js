/// <reference types='cypress-xpath' />

// This class represents a real and more complex page than SamplePage
// It is based on the Cart Page of "www.demoblaze.com"
export class RealPage {

  // ELEMENTS
  // Place Order button
  btnPlaceOrder = () => cy.get(".btn-success");

  // Credit Card form
  formCard = () => cy.get("#card");

  // Form fields
  formName = () => cy.get("#name");
  formCountry = () => cy.get("#country");
  formCity = () => cy.get("#city");
  formMonth = () => cy.get("#month");
  formYear = () => cy.get("#year");

  // Purchase button
  btnPurchase = () => cy.get("[onclick ='purchaseOrder()']");

  // Success message image
  imgSuccess = () => cy.get(".sa-success");

  // Table body 
  tableBody = () => cy.get("#tbodyid");

  // Delete item button
  deleteItemButton = () => cy.xpath("(//a[contains(@onclick , 'delete')])[1]");

  // METHODS
  // Clicks the Place Order button after ensuring that the table is not empty
  placeOrder() {
    this.tableBody().should("not.to.be.empty");
    this.btnPlaceOrder().click();
  }

  // Fills the form with data from a fixture and clicks the Purchase button
  fillForm() {
    cy.fixture("fillPurchaseForm").then((formData) => {
      this.formName().type(formData.name);
      this.formCountry().type(formData.country);
      this.formCity().type(formData.city);
      this.formCard().type(formData.credit_card);
      this.formMonth().type(formData.month);
      this.formYear().type(formData.year);
      this.btnPurchase().click();
    });
  }

  // Asserts that the purchase was completed by checking the success message image
  assertPurchaseCompleted() {
    this.imgSuccess().should("exist").and("be.visible");
  }

  // Deletes an item by clicking the delete button for the first item in the table
  deleteItem() {
    this.deleteItemButton().click().should("be.visible");
  }
}

