// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVerifyStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateInvoiceVerifyStatusResponseBody body;

    public static UpdateInvoiceVerifyStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVerifyStatusResponse self = new UpdateInvoiceVerifyStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVerifyStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceVerifyStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceVerifyStatusResponse setBody(UpdateInvoiceVerifyStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceVerifyStatusResponseBody getBody() {
        return this.body;
    }

}
