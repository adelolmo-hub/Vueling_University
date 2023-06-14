/// <reference types='cypress-xpath' />

// This class represents a sample page object for testing purposes.
// It provides methods to interact with elements on the page and perform common actions.
// It is based on the Home Page of "www.demoblaze.com"
export class SamplePage {

  // ELEMENTS
  // Get the login button element by ID
  loginButton = () => cy.getId("login2");

  // Get the laptop button element by CSS selector
  laptopButton = () => cy.get('a.list-group-item[onclick="byCat(\'notebook\')"]');

  // Get the first item button element by XPath
  firstItemButton = () => cy.get("(//a[@class='hrefch'])[1]");

  // Get an item button element by XPath and a parameter for item number
  getItemButton = (num) => cy.get("(//a[@class='hrefch'])[" + num + "]");

  // Get the cart button element by ID
  cartButton = () => cy.get("#cartur");

  // METHODS
  // Click on the login button and assert its visibility
  clickLogin() {
    this.loginButton().click().should("be.visible");
  }

  // Click on the cart button
  goToCart() {
    this.cartButton().click();
  }

  // Verify the page location equals the one specified with a timeout of 10 seconds
  verifyPage(pageLocationURL) {
    cy.location("pathname", { timeout: 10000 }).should("eq", pageLocationURL);
  }
}


