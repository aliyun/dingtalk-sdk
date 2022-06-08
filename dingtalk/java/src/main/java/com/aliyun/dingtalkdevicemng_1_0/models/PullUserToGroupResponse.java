// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class PullUserToGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public PullUserToGroupResponse setBody(PullUserToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public PullUserToGroupResponseBody getBody() {
        return this.body;
    }

}
