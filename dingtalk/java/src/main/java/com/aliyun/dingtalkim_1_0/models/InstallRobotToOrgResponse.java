// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class InstallRobotToOrgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public InstallRobotToOrgResponseBody body;

    public static InstallRobotToOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        InstallRobotToOrgResponse self = new InstallRobotToOrgResponse();
        return TeaModel.build(map, self);
    }

    public InstallRobotToOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InstallRobotToOrgResponse setBody(InstallRobotToOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public InstallRobotToOrgResponseBody getBody() {
        return this.body;
    }

}
