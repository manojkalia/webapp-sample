service
.factory("CategoryFactory", function ($resource) {
    var odataUrl = "oData/Category(:key)";
    return $resource('', { key: '@id' }, {
        'get': { url: odataUrl, method: 'GET' },
        'save': { url: odataUrl, method: 'POST', headers: { 'Content-Type': 'application/json' } },
        'update': { url: odataUrl, method: 'PUT' },
        'updatePatch': { url: odataUrl, method: 'PATCH' },
        'query': { url: odataUrl, method: 'GET' },
        'remove': { url: odataUrl, method: 'DELETE' },
    });
});