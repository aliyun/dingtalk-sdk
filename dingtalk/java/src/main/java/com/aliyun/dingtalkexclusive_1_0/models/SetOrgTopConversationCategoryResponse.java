// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetOrgTopConversationCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetOrgTopConversationCategoryResponseBody body;

    public static SetOrgTopConversationCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        SetOrgTopConversationCategoryResponse self = new SetOrgTopConversationCategoryResponse();
        return TeaModel.build(map, self);
    }

    public SetOrgTopConversationCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetOrgTopConversationCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetOrgTopConversationCategoryResponse setBody(SetOrgTopConversationCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public SetOrgTopConversationCategoryResponseBody getBody() {
        return this.body;
    }

}
