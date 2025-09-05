// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncTripInvoiceResponseBody body;

    public static SyncTripInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncTripInvoiceResponse self = new SyncTripInvoiceResponse();
        return TeaModel.build(map, self);
    }

    public SyncTripInvoiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncTripInvoiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncTripInvoiceResponse setBody(SyncTripInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncTripInvoiceResponseBody getBody() {
        return this.body;
    }

}
