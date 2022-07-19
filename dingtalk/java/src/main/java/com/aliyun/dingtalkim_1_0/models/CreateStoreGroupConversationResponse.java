// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateStoreGroupConversationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateStoreGroupConversationResponse setBody(CreateStoreGroupConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateStoreGroupConversationResponseBody getBody() {
        return this.body;
    }

}
