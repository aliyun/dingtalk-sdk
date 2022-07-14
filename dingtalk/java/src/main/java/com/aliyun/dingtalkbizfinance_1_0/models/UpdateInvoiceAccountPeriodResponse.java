// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountPeriodResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateInvoiceAccountPeriodResponse setBody(UpdateInvoiceAccountPeriodResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAccountPeriodResponseBody getBody() {
        return this.body;
    }

}
