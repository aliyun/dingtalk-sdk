// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalBelongMainOrgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ExternalQueryExternalBelongMainOrgResponseBody body;

    public static ExternalQueryExternalBelongMainOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalBelongMainOrgResponse self = new ExternalQueryExternalBelongMainOrgResponse();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalBelongMainOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExternalQueryExternalBelongMainOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExternalQueryExternalBelongMainOrgResponse setBody(ExternalQueryExternalBelongMainOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public ExternalQueryExternalBelongMainOrgResponseBody getBody() {
        return this.body;
    }

}
