// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class InstallRobotToOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public InstallRobotToOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InstallRobotToOrgResponse setBody(InstallRobotToOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public InstallRobotToOrgResponseBody getBody() {
        return this.body;
    }

}
