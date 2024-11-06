// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFormInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetFormInstancesResponseBody body;

    public static PremiumGetFormInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFormInstancesResponse self = new PremiumGetFormInstancesResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetFormInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetFormInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetFormInstancesResponse setBody(PremiumGetFormInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetFormInstancesResponseBody getBody() {
        return this.body;
    }

}
