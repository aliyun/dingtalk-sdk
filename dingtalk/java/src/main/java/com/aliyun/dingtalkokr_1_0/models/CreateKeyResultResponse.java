// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateKeyResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateKeyResultResponseBody body;

    public static CreateKeyResultResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateKeyResultResponse self = new CreateKeyResultResponse();
        return TeaModel.build(map, self);
    }

    public CreateKeyResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateKeyResultResponse setBody(CreateKeyResultResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateKeyResultResponseBody getBody() {
        return this.body;
    }

}
