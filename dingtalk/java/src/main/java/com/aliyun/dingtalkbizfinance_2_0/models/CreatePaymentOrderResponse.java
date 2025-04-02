// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreatePaymentOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreatePaymentOrderResponseBody body;

    public static CreatePaymentOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CreatePaymentOrderResponse self = new CreatePaymentOrderResponse();
        return TeaModel.build(map, self);
    }

    public CreatePaymentOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreatePaymentOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreatePaymentOrderResponse setBody(CreatePaymentOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreatePaymentOrderResponseBody getBody() {
        return this.body;
    }

}
