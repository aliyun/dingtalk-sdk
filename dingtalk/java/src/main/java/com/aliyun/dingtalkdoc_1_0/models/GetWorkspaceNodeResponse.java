// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceNodeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetWorkspaceNodeResponse setBody(GetWorkspaceNodeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWorkspaceNodeResponseBody getBody() {
        return this.body;
    }

}
