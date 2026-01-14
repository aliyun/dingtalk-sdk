// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class CreateAssistantRunResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAssistantRunResponseBody body;

    public static CreateAssistantRunResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantRunResponse self = new CreateAssistantRunResponse();
        return TeaModel.build(map, self);
    }

    public CreateAssistantRunResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAssistantRunResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAssistantRunResponse setBody(CreateAssistantRunResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAssistantRunResponseBody getBody() {
        return this.body;
    }

}
