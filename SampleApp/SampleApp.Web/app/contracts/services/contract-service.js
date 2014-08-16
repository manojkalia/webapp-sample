service
.factory("ContractFactory", function ($resource) {
    var contractUrl = "/api/Contract/:key";
    return $resource('', { key: '@id' }, {
        'get': { url: contractUrl, method: 'GET' },
        'save': { url: contractUrl, method: 'POST', headers: { 'Content-Type': 'application/json' } },
        'update': { url: contractUrl, method: 'PUT' },
        'updatePatch': { url: contractUrl, method: 'PATCH' },
        'query': { url: contractUrl, method: 'GET', isArray: true },
        'remove': { url: contractUrl, method: 'DELETE' },
    });
});