// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ReleaseUnfurlingRegisterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReleaseUnfurlingRegisterResponseBody body;

    public static ReleaseUnfurlingRegisterResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseUnfurlingRegisterResponse self = new ReleaseUnfurlingRegisterResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseUnfurlingRegisterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseUnfurlingRegisterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseUnfurlingRegisterResponse setBody(ReleaseUnfurlingRegisterResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseUnfurlingRegisterResponseBody getBody() {
        return this.body;
    }

}
