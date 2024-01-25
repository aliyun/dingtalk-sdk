// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetNavigationCatalogResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetNavigationCatalogResponseBody body;

    public static GetNavigationCatalogResponse build(java.util.Map<String, ?> map) throws Exception {
        GetNavigationCatalogResponse self = new GetNavigationCatalogResponse();
        return TeaModel.build(map, self);
    }

    public GetNavigationCatalogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetNavigationCatalogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetNavigationCatalogResponse setBody(GetNavigationCatalogResponseBody body) {
        this.body = body;
        return this;
    }
    public GetNavigationCatalogResponseBody getBody() {
        return this.body;
    }

}
