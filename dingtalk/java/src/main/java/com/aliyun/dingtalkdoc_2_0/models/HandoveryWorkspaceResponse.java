// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class HandoveryWorkspaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HandoveryWorkspaceResponseBody body;

    public static HandoveryWorkspaceResponse build(java.util.Map<String, ?> map) throws Exception {
        HandoveryWorkspaceResponse self = new HandoveryWorkspaceResponse();
        return TeaModel.build(map, self);
    }

    public HandoveryWorkspaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HandoveryWorkspaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HandoveryWorkspaceResponse setBody(HandoveryWorkspaceResponseBody body) {
        this.body = body;
        return this;
    }
    public HandoveryWorkspaceResponseBody getBody() {
        return this.body;
    }

}
