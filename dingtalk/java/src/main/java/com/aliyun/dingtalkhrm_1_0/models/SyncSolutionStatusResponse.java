// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SyncSolutionStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncSolutionStatusResponseBody body;

    public static SyncSolutionStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncSolutionStatusResponse self = new SyncSolutionStatusResponse();
        return TeaModel.build(map, self);
    }

    public SyncSolutionStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncSolutionStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncSolutionStatusResponse setBody(SyncSolutionStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncSolutionStatusResponseBody getBody() {
        return this.body;
    }

}
