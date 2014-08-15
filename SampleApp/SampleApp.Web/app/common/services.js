'use strict';

// Demonstrate how to register services
// In this case it is a simple value service.
var service = angular.module('app.services', ['ngResource'])
    
    .value('version', '0.1');