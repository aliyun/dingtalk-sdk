// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyWorkspaceAsyncResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CopyWorkspaceAsyncResponseBody body;

    public static CopyWorkspaceAsyncResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkspaceAsyncResponse self = new CopyWorkspaceAsyncResponse();
        return TeaModel.build(map, self);
    }

    public CopyWorkspaceAsyncResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyWorkspaceAsyncResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyWorkspaceAsyncResponse setBody(CopyWorkspaceAsyncResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyWorkspaceAsyncResponseBody getBody() {
        return this.body;
    }

}
