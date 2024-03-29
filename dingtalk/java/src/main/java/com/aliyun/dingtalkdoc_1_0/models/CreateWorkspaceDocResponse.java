// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkspaceDocResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateWorkspaceDocResponseBody body;

    public static CreateWorkspaceDocResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkspaceDocResponse self = new CreateWorkspaceDocResponse();
        return TeaModel.build(map, self);
    }

    public CreateWorkspaceDocResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateWorkspaceDocResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateWorkspaceDocResponse setBody(CreateWorkspaceDocResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateWorkspaceDocResponseBody getBody() {
        return this.body;
    }

}
