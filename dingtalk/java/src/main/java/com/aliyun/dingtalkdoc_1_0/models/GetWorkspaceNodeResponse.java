// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceNodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetWorkspaceNodeResponseBody body;

    public static GetWorkspaceNodeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspaceNodeResponse self = new GetWorkspaceNodeResponse();
        return TeaModel.build(map, self);
    }

    public GetWorkspaceNodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWorkspaceNodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetWorkspaceNodeResponse setBody(GetWorkspaceNodeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWorkspaceNodeResponseBody getBody() {
        return this.body;
    }

}
