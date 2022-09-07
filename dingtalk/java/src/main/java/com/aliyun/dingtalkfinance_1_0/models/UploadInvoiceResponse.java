// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UploadInvoiceResponseBody body;

    public static UploadInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceResponse self = new UploadInvoiceResponse();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadInvoiceResponse setBody(UploadInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadInvoiceResponseBody getBody() {
        return this.body;
    }

}
