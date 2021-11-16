// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedWorkspacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRelatedWorkspacesResponseBody body;

    public static GetRelatedWorkspacesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedWorkspacesResponse self = new GetRelatedWorkspacesResponse();
        return TeaModel.build(map, self);
    }

    public GetRelatedWorkspacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRelatedWorkspacesResponse setBody(GetRelatedWorkspacesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRelatedWorkspacesResponseBody getBody() {
        return this.body;
    }

}
