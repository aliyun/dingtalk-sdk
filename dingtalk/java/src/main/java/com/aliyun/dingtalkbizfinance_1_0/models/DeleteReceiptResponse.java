// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class DeleteReceiptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteReceiptResponseBody body;

    public static DeleteReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteReceiptResponse self = new DeleteReceiptResponse();
        return TeaModel.build(map, self);
    }

    public DeleteReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteReceiptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteReceiptResponse setBody(DeleteReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteReceiptResponseBody getBody() {
        return this.body;
    }

}
