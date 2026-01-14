// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CopyLinkToWorkspaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CopyLinkToWorkspaceResponseBody body;

    public static CopyLinkToWorkspaceResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyLinkToWorkspaceResponse self = new CopyLinkToWorkspaceResponse();
        return TeaModel.build(map, self);
    }

    public CopyLinkToWorkspaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyLinkToWorkspaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyLinkToWorkspaceResponse setBody(CopyLinkToWorkspaceResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyLinkToWorkspaceResponseBody getBody() {
        return this.body;
    }

}
