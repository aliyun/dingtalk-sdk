// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CreateCoupleGroupConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCoupleGroupConversationResponse setBody(CreateCoupleGroupConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCoupleGroupConversationResponseBody getBody() {
        return this.body;
    }

}
