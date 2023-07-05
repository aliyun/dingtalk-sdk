// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AyunTestOnlineResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AyunTestOnlineResponseBody body;

    public static AyunTestOnlineResponse build(java.util.Map<String, ?> map) throws Exception {
        AyunTestOnlineResponse self = new AyunTestOnlineResponse();
        return TeaModel.build(map, self);
    }

    public AyunTestOnlineResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AyunTestOnlineResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AyunTestOnlineResponse setBody(AyunTestOnlineResponseBody body) {
        this.body = body;
        return this;
    }
    public AyunTestOnlineResponseBody getBody() {
        return this.body;
    }

}
