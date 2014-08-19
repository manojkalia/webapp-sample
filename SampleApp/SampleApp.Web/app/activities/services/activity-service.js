service
.factory("ActivityFactory", function ($resource) {
    var activityUrl = "/api/Activity/:key";
    return $resource('', { key: '@id' }, {
        'get': { url: activityUrl, method: 'GET' },
        'save': { url: activityUrl, method: 'POST', headers: { 'Content-Type': 'application/json' } },
        'update': { url: activityUrl, method: 'PUT' },
        'updatePatch': { url: activityUrl, method: 'PATCH' },
        'query': { url: activityUrl, method: 'GET', isArray: true },
        'remove': { url: activityUrl, method: 'DELETE' },
    });
});