// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountPeriodResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInvoiceAccountPeriodResponseBody body;

    public static UpdateInvoiceAccountPeriodResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountPeriodResponse self = new UpdateInvoiceAccountPeriodResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountPeriodResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceAccountPeriodResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceAccountPeriodResponse setBody(UpdateInvoiceAccountPeriodResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAccountPeriodResponseBody getBody() {
        return this.body;
    }

}
