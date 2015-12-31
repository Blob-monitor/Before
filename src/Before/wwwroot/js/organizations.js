///<reference path="../lib/jquery/dist/jquery.js" />
///<reference path="../lib/knockout/dist/knockout.js" />

(function (ko, $, organizations) {
  function Organization(item) {
    for (var prop in item) {
      this[prop] = item[prop];
    }
    return this;
  }

  function OrganizationsViewModel(organizations) {
    var list = organizations.map(function (item) { return new Organization(item); })

    this.organizations = ko.observableArray(organizations).textFilter(["Name", "Description"]);
    this.total = organizations.length;
  }

  ko.applyBindings(new OrganizationsViewModel(organizations));
})(ko, $, modelOrganizations);