// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAiTravelListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatAiTravelListResponseBody body;

    public static ChatAiTravelListResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatAiTravelListResponse self = new ChatAiTravelListResponse();
        return TeaModel.build(map, self);
    }

    public ChatAiTravelListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatAiTravelListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatAiTravelListResponse setBody(ChatAiTravelListResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatAiTravelListResponseBody getBody() {
        return this.body;
    }

}
