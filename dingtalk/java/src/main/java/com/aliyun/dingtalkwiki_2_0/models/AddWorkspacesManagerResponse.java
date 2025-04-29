// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddWorkspacesManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddWorkspacesManagerResponseBody body;

    public static AddWorkspacesManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspacesManagerResponse self = new AddWorkspacesManagerResponse();
        return TeaModel.build(map, self);
    }

    public AddWorkspacesManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddWorkspacesManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddWorkspacesManagerResponse setBody(AddWorkspacesManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public AddWorkspacesManagerResponseBody getBody() {
        return this.body;
    }

}
