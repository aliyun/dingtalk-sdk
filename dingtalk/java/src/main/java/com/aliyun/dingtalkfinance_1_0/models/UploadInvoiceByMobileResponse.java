// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByMobileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UploadInvoiceByMobileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadInvoiceByMobileResponse setBody(UploadInvoiceByMobileResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadInvoiceByMobileResponseBody getBody() {
        return this.body;
    }

}
