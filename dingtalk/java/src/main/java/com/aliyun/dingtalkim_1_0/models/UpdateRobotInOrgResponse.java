// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInOrgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateRobotInOrgResponseBody body;

    public static UpdateRobotInOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotInOrgResponse self = new UpdateRobotInOrgResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRobotInOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRobotInOrgResponse setBody(UpdateRobotInOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRobotInOrgResponseBody getBody() {
        return this.body;
    }

}
