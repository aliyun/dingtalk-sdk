// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumDeleteFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumDeleteFormInstanceResponseBody body;

    public static PremiumDeleteFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumDeleteFormInstanceResponse self = new PremiumDeleteFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public PremiumDeleteFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumDeleteFormInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumDeleteFormInstanceResponse setBody(PremiumDeleteFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumDeleteFormInstanceResponseBody getBody() {
        return this.body;
    }

}
