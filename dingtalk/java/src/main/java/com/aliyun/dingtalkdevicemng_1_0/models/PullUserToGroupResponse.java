// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class PullUserToGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PullUserToGroupResponseBody body;

    public static PullUserToGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        PullUserToGroupResponse self = new PullUserToGroupResponse();
        return TeaModel.build(map, self);
    }

    public PullUserToGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PullUserToGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PullUserToGroupResponse setBody(PullUserToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public PullUserToGroupResponseBody getBody() {
        return this.body;
    }

}
