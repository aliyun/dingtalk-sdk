// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelKitTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CancelKitTaskResponseBody body;

    public static CancelKitTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelKitTaskResponse self = new CancelKitTaskResponse();
        return TeaModel.build(map, self);
    }

    public CancelKitTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelKitTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelKitTaskResponse setBody(CancelKitTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelKitTaskResponseBody getBody() {
        return this.body;
    }

}
