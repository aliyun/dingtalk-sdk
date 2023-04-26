// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskObjectLinkResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateTaskObjectLinkResponseBody body;

    public static CreateTaskObjectLinkResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTaskObjectLinkResponse self = new CreateTaskObjectLinkResponse();
        return TeaModel.build(map, self);
    }

    public CreateTaskObjectLinkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTaskObjectLinkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTaskObjectLinkResponse setBody(CreateTaskObjectLinkResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTaskObjectLinkResponseBody getBody() {
        return this.body;
    }

}
