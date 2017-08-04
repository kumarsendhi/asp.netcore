# Configure the Microsoft Azure Provider
provider "azurerm" {
      'client_id': ,
      'client_secret': abcd1234,
      'subscription_id': ,
      'tenant_id': 7fc705fc-d7bb-40b4-a982-f0bcf4b545b3
}

# create a resource group 
resource "azurerm_resource_group" "helloterraform" {
    name = "terraformtest"
    location = "West US"
}