// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddKnowledgeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddKnowledgeResponseBody body;

    public static AddKnowledgeResponse build(java.util.Map<String, ?> map) throws Exception {
        AddKnowledgeResponse self = new AddKnowledgeResponse();
        return TeaModel.build(map, self);
    }

    public AddKnowledgeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddKnowledgeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddKnowledgeResponse setBody(AddKnowledgeResponseBody body) {
        this.body = body;
        return this;
    }
    public AddKnowledgeResponseBody getBody() {
        return this.body;
    }

}
