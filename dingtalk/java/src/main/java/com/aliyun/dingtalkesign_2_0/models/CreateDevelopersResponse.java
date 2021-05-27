// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateDevelopersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDevelopersResponseBody body;

    public static CreateDevelopersResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDevelopersResponse self = new CreateDevelopersResponse();
        return TeaModel.build(map, self);
    }

    public CreateDevelopersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDevelopersResponse setBody(CreateDevelopersResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDevelopersResponseBody getBody() {
        return this.body;
    }

}
