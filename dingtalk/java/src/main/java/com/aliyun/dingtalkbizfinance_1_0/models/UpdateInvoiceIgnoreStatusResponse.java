// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceIgnoreStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateInvoiceIgnoreStatusResponse setBody(UpdateInvoiceIgnoreStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceIgnoreStatusResponseBody getBody() {
        return this.body;
    }

}
