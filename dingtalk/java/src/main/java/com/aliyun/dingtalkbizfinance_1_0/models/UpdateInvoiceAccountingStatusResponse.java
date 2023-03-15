// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateInvoiceAccountingStatusResponseBody body;

    public static UpdateInvoiceAccountingStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingStatusResponse self = new UpdateInvoiceAccountingStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceAccountingStatusResponse setBody(UpdateInvoiceAccountingStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAccountingStatusResponseBody getBody() {
        return this.body;
    }

}
