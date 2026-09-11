// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreatePayableReceiptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreatePayableReceiptResponseBody body;

    public static CreatePayableReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        CreatePayableReceiptResponse self = new CreatePayableReceiptResponse();
        return TeaModel.build(map, self);
    }

    public CreatePayableReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreatePayableReceiptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreatePayableReceiptResponse setBody(CreatePayableReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public CreatePayableReceiptResponseBody getBody() {
        return this.body;
    }

}
