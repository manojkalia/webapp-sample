service
.factory("ConsultantFactory", function ($resource) {
    var consultantUrl = "/api/consultant/:key";
    return $resource('', { key: '@id' }, {
        'get': { url: consultantUrl, method: 'GET' },
        'save': { url: consultantUrl, method: 'POST', headers: { 'Content-Type': 'application/json' } },
        'update': { url: consultantUrl, method: 'PUT' },
        'updatePatch': { url: consultantUrl, method: 'PATCH' },
        'query': { url: consultantUrl, method: 'GET', isArray: true },
        'remove': { url: consultantUrl, method: 'DELETE' },
    });
});