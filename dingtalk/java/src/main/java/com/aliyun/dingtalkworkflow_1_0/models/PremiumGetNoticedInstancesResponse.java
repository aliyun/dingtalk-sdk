// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetNoticedInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetNoticedInstancesResponseBody body;

    public static PremiumGetNoticedInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetNoticedInstancesResponse self = new PremiumGetNoticedInstancesResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetNoticedInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetNoticedInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetNoticedInstancesResponse setBody(PremiumGetNoticedInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetNoticedInstancesResponseBody getBody() {
        return this.body;
    }

}
