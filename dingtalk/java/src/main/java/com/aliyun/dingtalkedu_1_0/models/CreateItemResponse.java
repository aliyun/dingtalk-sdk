// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateItemResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CreateItemResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateItemResponse setBody(CreateItemResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateItemResponseBody getBody() {
        return this.body;
    }

}
