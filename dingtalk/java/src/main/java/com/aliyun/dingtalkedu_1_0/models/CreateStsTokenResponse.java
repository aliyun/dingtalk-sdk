// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateStsTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateStsTokenResponseBody body;

    public static CreateStsTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateStsTokenResponse self = new CreateStsTokenResponse();
        return TeaModel.build(map, self);
    }

    public CreateStsTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateStsTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateStsTokenResponse setBody(CreateStsTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateStsTokenResponseBody getBody() {
        return this.body;
    }

}
