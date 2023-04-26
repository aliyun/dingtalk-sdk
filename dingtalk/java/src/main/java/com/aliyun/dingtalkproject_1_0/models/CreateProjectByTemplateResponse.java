// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectByTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateProjectByTemplateResponseBody body;

    public static CreateProjectByTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectByTemplateResponse self = new CreateProjectByTemplateResponse();
        return TeaModel.build(map, self);
    }

    public CreateProjectByTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateProjectByTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateProjectByTemplateResponse setBody(CreateProjectByTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateProjectByTemplateResponseBody getBody() {
        return this.body;
    }

}
