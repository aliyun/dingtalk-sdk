// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationTopCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetConversationTopCategoryResponseBody body;

    public static SetConversationTopCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        SetConversationTopCategoryResponse self = new SetConversationTopCategoryResponse();
        return TeaModel.build(map, self);
    }

    public SetConversationTopCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetConversationTopCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetConversationTopCategoryResponse setBody(SetConversationTopCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public SetConversationTopCategoryResponseBody getBody() {
        return this.body;
    }

}
