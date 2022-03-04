// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByMobileResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UploadInvoiceByMobileResponseBody body;

    public static UploadInvoiceByMobileResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceByMobileResponse self = new UploadInvoiceByMobileResponse();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceByMobileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadInvoiceByMobileResponse setBody(UploadInvoiceByMobileResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadInvoiceByMobileResponseBody getBody() {
        return this.body;
    }

}
