// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncInvoiceResponseBody body;

    public static SyncInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncInvoiceResponse self = new SyncInvoiceResponse();
        return TeaModel.build(map, self);
    }

    public SyncInvoiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncInvoiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncInvoiceResponse setBody(SyncInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncInvoiceResponseBody getBody() {
        return this.body;
    }

}
