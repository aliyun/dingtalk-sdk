// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppOrderToGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InstallCoolAppOrderToGroupResponseBody body;

    public static InstallCoolAppOrderToGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppOrderToGroupResponse self = new InstallCoolAppOrderToGroupResponse();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppOrderToGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InstallCoolAppOrderToGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InstallCoolAppOrderToGroupResponse setBody(InstallCoolAppOrderToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public InstallCoolAppOrderToGroupResponseBody getBody() {
        return this.body;
    }

}
