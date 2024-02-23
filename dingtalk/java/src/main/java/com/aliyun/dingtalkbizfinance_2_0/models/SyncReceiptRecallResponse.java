// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class SyncReceiptRecallResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncReceiptRecallResponseBody body;

    public static SyncReceiptRecallResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncReceiptRecallResponse self = new SyncReceiptRecallResponse();
        return TeaModel.build(map, self);
    }

    public SyncReceiptRecallResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncReceiptRecallResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncReceiptRecallResponse setBody(SyncReceiptRecallResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncReceiptRecallResponseBody getBody() {
        return this.body;
    }

}
