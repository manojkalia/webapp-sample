service
.factory("ProviderFactory", function ($resource) {
    var providerUrl = "/api/provider/:key";
    return $resource('', { key: '@id' }, {
        'get': { url: providerUrl, method: 'GET' },
        'save': { url: providerUrl, method: 'POST', headers: { 'Content-Type': 'application/json' } },
        'update': { url: providerUrl, method: 'PUT' },
        'updatePatch': { url: providerUrl, method: 'PATCH' },
        'query': { url: providerUrl, method: 'GET', isArray: true },
        'remove': { url: providerUrl, method: 'DELETE' },
    });
});