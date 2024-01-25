// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplyReceiptAndInvoiceRelatedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateApplyReceiptAndInvoiceRelatedResponseBody body;

    public static UpdateApplyReceiptAndInvoiceRelatedResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateApplyReceiptAndInvoiceRelatedResponse self = new UpdateApplyReceiptAndInvoiceRelatedResponse();
        return TeaModel.build(map, self);
    }

    public UpdateApplyReceiptAndInvoiceRelatedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateApplyReceiptAndInvoiceRelatedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateApplyReceiptAndInvoiceRelatedResponse setBody(UpdateApplyReceiptAndInvoiceRelatedResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateApplyReceiptAndInvoiceRelatedResponseBody getBody() {
        return this.body;
    }

}
