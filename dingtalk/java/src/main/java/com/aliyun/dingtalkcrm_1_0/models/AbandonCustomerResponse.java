// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AbandonCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AbandonCustomerResponseBody body;

    public static AbandonCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        AbandonCustomerResponse self = new AbandonCustomerResponse();
        return TeaModel.build(map, self);
    }

    public AbandonCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AbandonCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AbandonCustomerResponse setBody(AbandonCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public AbandonCustomerResponseBody getBody() {
        return this.body;
    }

}
