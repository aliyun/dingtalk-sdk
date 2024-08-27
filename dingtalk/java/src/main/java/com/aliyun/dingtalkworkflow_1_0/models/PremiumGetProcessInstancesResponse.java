// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetProcessInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetProcessInstancesResponseBody body;

    public static PremiumGetProcessInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetProcessInstancesResponse self = new PremiumGetProcessInstancesResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetProcessInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetProcessInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetProcessInstancesResponse setBody(PremiumGetProcessInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetProcessInstancesResponseBody getBody() {
        return this.body;
    }

}
