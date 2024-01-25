// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateStoreGroupConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateStoreGroupConversationResponseBody body;

    public static CreateStoreGroupConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateStoreGroupConversationResponse self = new CreateStoreGroupConversationResponse();
        return TeaModel.build(map, self);
    }

    public CreateStoreGroupConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateStoreGroupConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateStoreGroupConversationResponse setBody(CreateStoreGroupConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateStoreGroupConversationResponseBody getBody() {
        return this.body;
    }

}
