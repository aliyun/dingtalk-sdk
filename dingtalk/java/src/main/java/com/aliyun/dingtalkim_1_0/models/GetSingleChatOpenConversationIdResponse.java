// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSingleChatOpenConversationIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSingleChatOpenConversationIdResponseBody body;

    public static GetSingleChatOpenConversationIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSingleChatOpenConversationIdResponse self = new GetSingleChatOpenConversationIdResponse();
        return TeaModel.build(map, self);
    }

    public GetSingleChatOpenConversationIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSingleChatOpenConversationIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSingleChatOpenConversationIdResponse setBody(GetSingleChatOpenConversationIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSingleChatOpenConversationIdResponseBody getBody() {
        return this.body;
    }

}
