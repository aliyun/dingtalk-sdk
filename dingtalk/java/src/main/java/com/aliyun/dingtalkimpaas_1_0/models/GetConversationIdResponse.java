// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetConversationIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetConversationIdResponseBody body;

    public static GetConversationIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConversationIdResponse self = new GetConversationIdResponse();
        return TeaModel.build(map, self);
    }

    public GetConversationIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConversationIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConversationIdResponse setBody(GetConversationIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConversationIdResponseBody getBody() {
        return this.body;
    }

}
