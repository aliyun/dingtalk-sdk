// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetSubmittedInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetSubmittedInstancesResponseBody body;

    public static PremiumGetSubmittedInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetSubmittedInstancesResponse self = new PremiumGetSubmittedInstancesResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetSubmittedInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetSubmittedInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetSubmittedInstancesResponse setBody(PremiumGetSubmittedInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetSubmittedInstancesResponseBody getBody() {
        return this.body;
    }

}
