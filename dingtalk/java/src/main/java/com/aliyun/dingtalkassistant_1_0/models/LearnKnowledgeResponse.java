// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class LearnKnowledgeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LearnKnowledgeResponseBody body;

    public static LearnKnowledgeResponse build(java.util.Map<String, ?> map) throws Exception {
        LearnKnowledgeResponse self = new LearnKnowledgeResponse();
        return TeaModel.build(map, self);
    }

    public LearnKnowledgeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LearnKnowledgeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LearnKnowledgeResponse setBody(LearnKnowledgeResponseBody body) {
        this.body = body;
        return this;
    }
    public LearnKnowledgeResponseBody getBody() {
        return this.body;
    }

}
