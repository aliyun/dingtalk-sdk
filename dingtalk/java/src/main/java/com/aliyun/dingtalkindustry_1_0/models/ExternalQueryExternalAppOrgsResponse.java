// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalAppOrgsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExternalQueryExternalAppOrgsResponseBody body;

    public static ExternalQueryExternalAppOrgsResponse build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalAppOrgsResponse self = new ExternalQueryExternalAppOrgsResponse();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalAppOrgsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExternalQueryExternalAppOrgsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExternalQueryExternalAppOrgsResponse setBody(ExternalQueryExternalAppOrgsResponseBody body) {
        this.body = body;
        return this;
    }
    public ExternalQueryExternalAppOrgsResponseBody getBody() {
        return this.body;
    }

}
