// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdpaas_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppToGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InstallCoolAppToGroupResponseBody body;

    public static InstallCoolAppToGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppToGroupResponse self = new InstallCoolAppToGroupResponse();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppToGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InstallCoolAppToGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InstallCoolAppToGroupResponse setBody(InstallCoolAppToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public InstallCoolAppToGroupResponseBody getBody() {
        return this.body;
    }

}
