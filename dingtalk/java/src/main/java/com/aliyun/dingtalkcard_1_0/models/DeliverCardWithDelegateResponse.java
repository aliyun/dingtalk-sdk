// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class DeliverCardWithDelegateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeliverCardWithDelegateResponseBody body;

    public static DeliverCardWithDelegateResponse build(java.util.Map<String, ?> map) throws Exception {
        DeliverCardWithDelegateResponse self = new DeliverCardWithDelegateResponse();
        return TeaModel.build(map, self);
    }

    public DeliverCardWithDelegateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeliverCardWithDelegateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeliverCardWithDelegateResponse setBody(DeliverCardWithDelegateResponseBody body) {
        this.body = body;
        return this;
    }
    public DeliverCardWithDelegateResponseBody getBody() {
        return this.body;
    }

}
