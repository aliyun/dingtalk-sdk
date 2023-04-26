// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateApaasAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateApaasAppResponseBody body;

    public static CreateApaasAppResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateApaasAppResponse self = new CreateApaasAppResponse();
        return TeaModel.build(map, self);
    }

    public CreateApaasAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateApaasAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateApaasAppResponse setBody(CreateApaasAppResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateApaasAppResponseBody getBody() {
        return this.body;
    }

}
