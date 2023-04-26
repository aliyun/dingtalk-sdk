// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalOrgsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ExternalQueryExternalOrgsResponseBody body;

    public static ExternalQueryExternalOrgsResponse build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalOrgsResponse self = new ExternalQueryExternalOrgsResponse();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalOrgsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExternalQueryExternalOrgsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExternalQueryExternalOrgsResponse setBody(ExternalQueryExternalOrgsResponseBody body) {
        this.body = body;
        return this;
    }
    public ExternalQueryExternalOrgsResponseBody getBody() {
        return this.body;
    }

}
