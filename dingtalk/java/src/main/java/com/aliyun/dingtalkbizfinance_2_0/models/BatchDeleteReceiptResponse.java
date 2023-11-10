// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteReceiptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchDeleteReceiptResponseBody body;

    public static BatchDeleteReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteReceiptResponse self = new BatchDeleteReceiptResponse();
        return TeaModel.build(map, self);
    }

    public BatchDeleteReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchDeleteReceiptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchDeleteReceiptResponse setBody(BatchDeleteReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchDeleteReceiptResponseBody getBody() {
        return this.body;
    }

}
