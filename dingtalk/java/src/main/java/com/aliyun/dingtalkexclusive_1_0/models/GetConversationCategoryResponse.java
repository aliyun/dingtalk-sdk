// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConversationCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetConversationCategoryResponseBody body;

    public static GetConversationCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConversationCategoryResponse self = new GetConversationCategoryResponse();
        return TeaModel.build(map, self);
    }

    public GetConversationCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConversationCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConversationCategoryResponse setBody(GetConversationCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConversationCategoryResponseBody getBody() {
        return this.body;
    }

}
