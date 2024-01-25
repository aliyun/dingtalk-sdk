// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateReceiptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateReceiptResponseBody body;

    public static CreateReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateReceiptResponse self = new CreateReceiptResponse();
        return TeaModel.build(map, self);
    }

    public CreateReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateReceiptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateReceiptResponse setBody(CreateReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateReceiptResponseBody getBody() {
        return this.body;
    }

}
