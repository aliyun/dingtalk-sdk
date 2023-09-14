// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryConversationMessageForAIResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryConversationMessageForAIResponseBody body;

    public static QueryConversationMessageForAIResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryConversationMessageForAIResponse self = new QueryConversationMessageForAIResponse();
        return TeaModel.build(map, self);
    }

    public QueryConversationMessageForAIResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryConversationMessageForAIResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryConversationMessageForAIResponse setBody(QueryConversationMessageForAIResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryConversationMessageForAIResponseBody getBody() {
        return this.body;
    }

}
