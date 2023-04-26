// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingPeriodDateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateInvoiceAccountingPeriodDateResponseBody body;

    public static UpdateInvoiceAccountingPeriodDateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingPeriodDateResponse self = new UpdateInvoiceAccountingPeriodDateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingPeriodDateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceAccountingPeriodDateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceAccountingPeriodDateResponse setBody(UpdateInvoiceAccountingPeriodDateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAccountingPeriodDateResponseBody getBody() {
        return this.body;
    }

}
