// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAbandonStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateInvoiceAbandonStatusResponse setBody(UpdateInvoiceAbandonStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceAbandonStatusResponseBody getBody() {
        return this.body;
    }

}
