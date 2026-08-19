// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateTemplateProcessTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateTemplateProcessTaskResponseBody body;

    public static CreateTemplateProcessTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTemplateProcessTaskResponse self = new CreateTemplateProcessTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateTemplateProcessTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTemplateProcessTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTemplateProcessTaskResponse setBody(CreateTemplateProcessTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTemplateProcessTaskResponseBody getBody() {
        return this.body;
    }

}
