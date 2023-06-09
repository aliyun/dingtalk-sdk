// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiPResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AnheiPResponseBody body;

    public static AnheiPResponse build(java.util.Map<String, ?> map) throws Exception {
        AnheiPResponse self = new AnheiPResponse();
        return TeaModel.build(map, self);
    }

    public AnheiPResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AnheiPResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AnheiPResponse setBody(AnheiPResponseBody body) {
        this.body = body;
        return this;
    }
    public AnheiPResponseBody getBody() {
        return this.body;
    }

}
