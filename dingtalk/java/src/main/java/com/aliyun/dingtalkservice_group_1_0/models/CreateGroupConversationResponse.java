// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupConversationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateGroupConversationResponseBody body;

    public static CreateGroupConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupConversationResponse self = new CreateGroupConversationResponse();
        return TeaModel.build(map, self);
    }

    public CreateGroupConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateGroupConversationResponse setBody(CreateGroupConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateGroupConversationResponseBody getBody() {
        return this.body;
    }

}
