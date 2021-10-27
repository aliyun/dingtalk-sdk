// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenKnowledgeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddOpenKnowledgeResponseBody body;

    public static AddOpenKnowledgeResponse build(java.util.Map<String, ?> map) throws Exception {
        AddOpenKnowledgeResponse self = new AddOpenKnowledgeResponse();
        return TeaModel.build(map, self);
    }

    public AddOpenKnowledgeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddOpenKnowledgeResponse setBody(AddOpenKnowledgeResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOpenKnowledgeResponseBody getBody() {
        return this.body;
    }

}
