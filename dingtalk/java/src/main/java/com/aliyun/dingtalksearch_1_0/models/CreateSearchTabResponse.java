// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class CreateSearchTabResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateSearchTabResponseBody body;

    public static CreateSearchTabResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSearchTabResponse self = new CreateSearchTabResponse();
        return TeaModel.build(map, self);
    }

    public CreateSearchTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSearchTabResponse setBody(CreateSearchTabResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSearchTabResponseBody getBody() {
        return this.body;
    }

}
