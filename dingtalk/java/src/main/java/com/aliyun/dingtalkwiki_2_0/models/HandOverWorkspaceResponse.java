// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class HandOverWorkspaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HandOverWorkspaceResponseBody body;

    public static HandOverWorkspaceResponse build(java.util.Map<String, ?> map) throws Exception {
        HandOverWorkspaceResponse self = new HandOverWorkspaceResponse();
        return TeaModel.build(map, self);
    }

    public HandOverWorkspaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HandOverWorkspaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HandOverWorkspaceResponse setBody(HandOverWorkspaceResponseBody body) {
        this.body = body;
        return this;
    }
    public HandOverWorkspaceResponseBody getBody() {
        return this.body;
    }

}
