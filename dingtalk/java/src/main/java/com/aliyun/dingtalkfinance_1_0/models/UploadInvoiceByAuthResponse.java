// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UploadInvoiceByAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadInvoiceByAuthResponse setBody(UploadInvoiceByAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadInvoiceByAuthResponseBody getBody() {
        return this.body;
    }

}
