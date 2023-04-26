// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateSceneGroupConversationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateSceneGroupConversationResponseBody body;

    public static CreateSceneGroupConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSceneGroupConversationResponse self = new CreateSceneGroupConversationResponse();
        return TeaModel.build(map, self);
    }

    public CreateSceneGroupConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSceneGroupConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSceneGroupConversationResponse setBody(CreateSceneGroupConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSceneGroupConversationResponseBody getBody() {
        return this.body;
    }

}
