// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAndReceiptRelatedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateInvoiceAndReceiptRelatedResponse setBody(UpdateInvoiceAndReceiptRelatedResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAndReceiptRelatedResponseBody getBody() {
        return this.body;
    }

}
