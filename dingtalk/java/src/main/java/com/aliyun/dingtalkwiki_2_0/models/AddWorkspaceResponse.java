// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddWorkspaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddWorkspaceResponseBody body;

    public static AddWorkspaceResponse build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspaceResponse self = new AddWorkspaceResponse();
        return TeaModel.build(map, self);
    }

    public AddWorkspaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddWorkspaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddWorkspaceResponse setBody(AddWorkspaceResponseBody body) {
        this.body = body;
        return this;
    }
    public AddWorkspaceResponseBody getBody() {
        return this.body;
    }

}
