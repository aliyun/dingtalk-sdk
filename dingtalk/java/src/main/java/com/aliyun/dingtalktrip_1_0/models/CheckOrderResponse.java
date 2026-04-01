// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class CheckOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckOrderResponseBody body;

    public static CheckOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckOrderResponse self = new CheckOrderResponse();
        return TeaModel.build(map, self);
    }

    public CheckOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckOrderResponse setBody(CheckOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckOrderResponseBody getBody() {
        return this.body;
    }

}
