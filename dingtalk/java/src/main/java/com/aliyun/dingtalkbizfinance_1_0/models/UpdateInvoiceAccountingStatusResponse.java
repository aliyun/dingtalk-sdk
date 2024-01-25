// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateInvoiceAccountingStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceAccountingStatusResponse setBody(UpdateInvoiceAccountingStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAccountingStatusResponseBody getBody() {
        return this.body;
    }

}
