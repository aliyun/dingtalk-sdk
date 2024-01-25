// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAbandonStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInvoiceAbandonStatusResponseBody body;

    public static UpdateInvoiceAbandonStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAbandonStatusResponse self = new UpdateInvoiceAbandonStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAbandonStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceAbandonStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceAbandonStatusResponse setBody(UpdateInvoiceAbandonStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAbandonStatusResponseBody getBody() {
        return this.body;
    }

}
