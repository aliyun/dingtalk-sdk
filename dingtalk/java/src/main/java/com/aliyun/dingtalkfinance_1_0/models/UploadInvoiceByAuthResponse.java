// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByAuthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UploadInvoiceByAuthResponseBody body;

    public static UploadInvoiceByAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceByAuthResponse self = new UploadInvoiceByAuthResponse();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceByAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadInvoiceByAuthResponse setBody(UploadInvoiceByAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadInvoiceByAuthResponseBody getBody() {
        return this.body;
    }

}
