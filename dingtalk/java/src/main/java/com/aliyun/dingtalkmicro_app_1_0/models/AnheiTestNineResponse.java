// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiTestNineResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AnheiTestNineResponseBody body;

    public static AnheiTestNineResponse build(java.util.Map<String, ?> map) throws Exception {
        AnheiTestNineResponse self = new AnheiTestNineResponse();
        return TeaModel.build(map, self);
    }

    public AnheiTestNineResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AnheiTestNineResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AnheiTestNineResponse setBody(AnheiTestNineResponseBody body) {
        this.body = body;
        return this;
    }
    public AnheiTestNineResponseBody getBody() {
        return this.body;
    }

}
