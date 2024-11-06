// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetFormInstanceResponseBody body;

    public static PremiumGetFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFormInstanceResponse self = new PremiumGetFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetFormInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetFormInstanceResponse setBody(PremiumGetFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetFormInstanceResponseBody getBody() {
        return this.body;
    }

}
