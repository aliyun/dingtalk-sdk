// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class InactiveAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InactiveAppResponseBody body;

    public static InactiveAppResponse build(java.util.Map<String, ?> map) throws Exception {
        InactiveAppResponse self = new InactiveAppResponse();
        return TeaModel.build(map, self);
    }

    public InactiveAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InactiveAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InactiveAppResponse setBody(InactiveAppResponseBody body) {
        this.body = body;
        return this;
    }
    public InactiveAppResponseBody getBody() {
        return this.body;
    }

}
