// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class ConfirmPaymentOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConfirmPaymentOrderResponseBody body;

    public static ConfirmPaymentOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        ConfirmPaymentOrderResponse self = new ConfirmPaymentOrderResponse();
        return TeaModel.build(map, self);
    }

    public ConfirmPaymentOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConfirmPaymentOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConfirmPaymentOrderResponse setBody(ConfirmPaymentOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public ConfirmPaymentOrderResponseBody getBody() {
        return this.body;
    }

}
