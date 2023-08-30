// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetConversationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetConversationResponseBody body;

    public static GetConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConversationResponse self = new GetConversationResponse();
        return TeaModel.build(map, self);
    }

    public GetConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConversationResponse setBody(GetConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConversationResponseBody getBody() {
        return this.body;
    }

}
