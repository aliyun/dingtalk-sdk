// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RelearnKnowledgeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RelearnKnowledgeResponseBody body;

    public static RelearnKnowledgeResponse build(java.util.Map<String, ?> map) throws Exception {
        RelearnKnowledgeResponse self = new RelearnKnowledgeResponse();
        return TeaModel.build(map, self);
    }

    public RelearnKnowledgeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RelearnKnowledgeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RelearnKnowledgeResponse setBody(RelearnKnowledgeResponseBody body) {
        this.body = body;
        return this;
    }
    public RelearnKnowledgeResponseBody getBody() {
        return this.body;
    }

}
