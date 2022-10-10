// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateStsTokenResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateStsTokenResponse setBody(CreateStsTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateStsTokenResponseBody getBody() {
        return this.body;
    }

}
