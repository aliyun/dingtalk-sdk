// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class CreateFeedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateFeedResponseBody body;

    public static CreateFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateFeedResponse self = new CreateFeedResponse();
        return TeaModel.build(map, self);
    }

    public CreateFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateFeedResponse setBody(CreateFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateFeedResponseBody getBody() {
        return this.body;
    }

}
