// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetConversationUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetConversationUrlResponseBody body;

    public static GetConversationUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConversationUrlResponse self = new GetConversationUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetConversationUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConversationUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConversationUrlResponse setBody(GetConversationUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConversationUrlResponseBody getBody() {
        return this.body;
    }

}
