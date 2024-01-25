// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UploadInvoiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadInvoiceResponse setBody(UploadInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadInvoiceResponseBody getBody() {
        return this.body;
    }

}
