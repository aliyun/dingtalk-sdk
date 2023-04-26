// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncBusinessSignInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SyncBusinessSignInfoResponseBody body;

    public static SyncBusinessSignInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncBusinessSignInfoResponse self = new SyncBusinessSignInfoResponse();
        return TeaModel.build(map, self);
    }

    public SyncBusinessSignInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncBusinessSignInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncBusinessSignInfoResponse setBody(SyncBusinessSignInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncBusinessSignInfoResponseBody getBody() {
        return this.body;
    }

}
