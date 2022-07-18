// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplyReceiptAndInvoiceRelatedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateApplyReceiptAndInvoiceRelatedResponse setBody(UpdateApplyReceiptAndInvoiceRelatedResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateApplyReceiptAndInvoiceRelatedResponseBody getBody() {
        return this.body;
    }

}
