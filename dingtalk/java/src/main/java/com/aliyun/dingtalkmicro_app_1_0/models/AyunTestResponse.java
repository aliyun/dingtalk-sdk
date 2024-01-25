// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AyunTestResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AyunTestResponseBody body;

    public static AyunTestResponse build(java.util.Map<String, ?> map) throws Exception {
        AyunTestResponse self = new AyunTestResponse();
        return TeaModel.build(map, self);
    }

    public AyunTestResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AyunTestResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AyunTestResponse setBody(AyunTestResponseBody body) {
        this.body = body;
        return this;
    }
    public AyunTestResponseBody getBody() {
        return this.body;
    }

}
