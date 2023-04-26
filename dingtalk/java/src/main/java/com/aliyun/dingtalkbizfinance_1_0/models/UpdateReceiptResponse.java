// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateReceiptResponseBody body;

    public static UpdateReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateReceiptResponse self = new UpdateReceiptResponse();
        return TeaModel.build(map, self);
    }

    public UpdateReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateReceiptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateReceiptResponse setBody(UpdateReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateReceiptResponseBody getBody() {
        return this.body;
    }

}
