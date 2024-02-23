// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncInvoiceEntityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncInvoiceEntityResponseBody body;

    public static SyncInvoiceEntityResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncInvoiceEntityResponse self = new SyncInvoiceEntityResponse();
        return TeaModel.build(map, self);
    }

    public SyncInvoiceEntityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncInvoiceEntityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncInvoiceEntityResponse setBody(SyncInvoiceEntityResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncInvoiceEntityResponseBody getBody() {
        return this.body;
    }

}
