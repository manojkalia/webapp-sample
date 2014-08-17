service
.factory("SiteLocationFactory", function ($resource) {
    var siteLocationUrl = "/api/SiteLocation/:key";
    return $resource('', { key: '@id' }, {
        'get': { url: siteLocationUrl, method: 'GET' },
        'save': { url: siteLocationUrl, method: 'POST', headers: { 'Content-Type': 'application/json' } },
        'update': { url: siteLocationUrl, method: 'PUT' },
        'updatePatch': { url: siteLocationUrl, method: 'PATCH' },
        'query': { url: siteLocationUrl, method: 'GET', isArray: true },
        'remove': { url: siteLocationUrl, method: 'DELETE' },
    });
});