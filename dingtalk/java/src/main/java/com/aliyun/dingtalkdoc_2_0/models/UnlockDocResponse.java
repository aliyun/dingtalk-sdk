// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnlockDocResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UnlockDocResponseBody body;

    public static UnlockDocResponse build(java.util.Map<String, ?> map) throws Exception {
        UnlockDocResponse self = new UnlockDocResponse();
        return TeaModel.build(map, self);
    }

    public UnlockDocResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnlockDocResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UnlockDocResponse setBody(UnlockDocResponseBody body) {
        this.body = body;
        return this;
    }
    public UnlockDocResponseBody getBody() {
        return this.body;
    }

}
