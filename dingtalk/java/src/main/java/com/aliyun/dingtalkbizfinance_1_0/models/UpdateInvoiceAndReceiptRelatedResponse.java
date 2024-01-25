// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAndReceiptRelatedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInvoiceAndReceiptRelatedResponseBody body;

    public static UpdateInvoiceAndReceiptRelatedResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAndReceiptRelatedResponse self = new UpdateInvoiceAndReceiptRelatedResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAndReceiptRelatedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceAndReceiptRelatedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceAndReceiptRelatedResponse setBody(UpdateInvoiceAndReceiptRelatedResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAndReceiptRelatedResponseBody getBody() {
        return this.body;
    }

}
