// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupConversationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateCoupleGroupConversationResponseBody body;

    public static CreateCoupleGroupConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupConversationResponse self = new CreateCoupleGroupConversationResponse();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCoupleGroupConversationResponse setBody(CreateCoupleGroupConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCoupleGroupConversationResponseBody getBody() {
        return this.body;
    }

}
