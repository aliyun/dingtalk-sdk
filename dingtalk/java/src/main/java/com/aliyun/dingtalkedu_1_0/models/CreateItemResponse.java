// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateItemResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateItemResponseBody body;

    public static CreateItemResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateItemResponse self = new CreateItemResponse();
        return TeaModel.build(map, self);
    }

    public CreateItemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateItemResponse setBody(CreateItemResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateItemResponseBody getBody() {
        return this.body;
    }

}