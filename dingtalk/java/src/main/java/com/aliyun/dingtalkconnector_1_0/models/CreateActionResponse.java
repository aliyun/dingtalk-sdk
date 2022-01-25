// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateActionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateActionResponseBody body;

    public static CreateActionResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateActionResponse self = new CreateActionResponse();
        return TeaModel.build(map, self);
    }

    public CreateActionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateActionResponse setBody(CreateActionResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateActionResponseBody getBody() {
        return this.body;
    }

}
