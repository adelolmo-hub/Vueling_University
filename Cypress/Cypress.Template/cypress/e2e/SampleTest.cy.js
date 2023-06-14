//WebPages Imports
import { SamplePage } from "../webpages/SamplePage"; 
import { RealPage } from "../webpages/RealPage"; 

describe("SampleTest", () => {
  const samplePage = new SamplePage();
  const realPage = new RealPage();

  // This will be executed only once before
  before(() => {
    //Add logic here
  });

  // This will be executed before the execution of every test
  beforeEach(() => {
    
    cy.visit("");
  });

  // Test case 1
  it("Go to cart", () => {
    let finalURL = "/cart.html";
    samplePage.goToCart();
    samplePage.verifyPage(finalURL);
  });

  it("Make a purchase and assert it", () => {
    //Go to the baseURL + the specified below
    cy.visit("/cart.html");
    realPage.btnPlaceOrder().click();
    realPage.fillForm();
    realPage.assertPurchaseCompleted();
  });
  // Add more test cases here

  // This will be executed only once when everything is finished
  after(() => {
    // Add logic here
  });

  // This will be executed everytime a test ends
  afterEach(() => {
    //Add logic here
  });
});