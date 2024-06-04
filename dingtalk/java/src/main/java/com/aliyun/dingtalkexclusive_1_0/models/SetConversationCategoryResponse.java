// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetConversationCategoryResponseBody body;

    public static SetConversationCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        SetConversationCategoryResponse self = new SetConversationCategoryResponse();
        return TeaModel.build(map, self);
    }

    public SetConversationCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetConversationCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetConversationCategoryResponse setBody(SetConversationCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public SetConversationCategoryResponseBody getBody() {
        return this.body;
    }

}
