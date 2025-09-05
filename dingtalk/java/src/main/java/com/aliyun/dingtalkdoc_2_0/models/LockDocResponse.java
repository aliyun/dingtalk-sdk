// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class LockDocResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LockDocResponseBody body;

    public static LockDocResponse build(java.util.Map<String, ?> map) throws Exception {
        LockDocResponse self = new LockDocResponse();
        return TeaModel.build(map, self);
    }

    public LockDocResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LockDocResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LockDocResponse setBody(LockDocResponseBody body) {
        this.body = body;
        return this;
    }
    public LockDocResponseBody getBody() {
        return this.body;
    }

}
