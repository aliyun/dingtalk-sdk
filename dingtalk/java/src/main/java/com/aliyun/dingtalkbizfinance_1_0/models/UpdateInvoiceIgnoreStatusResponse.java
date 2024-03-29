// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceIgnoreStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInvoiceIgnoreStatusResponseBody body;

    public static UpdateInvoiceIgnoreStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceIgnoreStatusResponse self = new UpdateInvoiceIgnoreStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceIgnoreStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceIgnoreStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceIgnoreStatusResponse setBody(UpdateInvoiceIgnoreStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceIgnoreStatusResponseBody getBody() {
        return this.body;
    }

}
