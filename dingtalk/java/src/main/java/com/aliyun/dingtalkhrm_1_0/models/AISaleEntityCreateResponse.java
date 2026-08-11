// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityCreateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleEntityCreateResponseBody body;

    public static AISaleEntityCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityCreateResponse self = new AISaleEntityCreateResponse();
        return TeaModel.build(map, self);
    }

    public AISaleEntityCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleEntityCreateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleEntityCreateResponse setBody(AISaleEntityCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleEntityCreateResponseBody getBody() {
        return this.body;
    }

}
