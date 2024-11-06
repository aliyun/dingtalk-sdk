// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFormSchemaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetFormSchemaResponseBody body;

    public static PremiumGetFormSchemaResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFormSchemaResponse self = new PremiumGetFormSchemaResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetFormSchemaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetFormSchemaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetFormSchemaResponse setBody(PremiumGetFormSchemaResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetFormSchemaResponseBody getBody() {
        return this.body;
    }

}
