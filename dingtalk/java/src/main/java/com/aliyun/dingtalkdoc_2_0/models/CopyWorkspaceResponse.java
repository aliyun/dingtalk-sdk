// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyWorkspaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CopyWorkspaceResponseBody body;

    public static CopyWorkspaceResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkspaceResponse self = new CopyWorkspaceResponse();
        return TeaModel.build(map, self);
    }

    public CopyWorkspaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyWorkspaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyWorkspaceResponse setBody(CopyWorkspaceResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyWorkspaceResponseBody getBody() {
        return this.body;
    }

}
