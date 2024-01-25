// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateRobotInOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRobotInOrgResponse setBody(UpdateRobotInOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRobotInOrgResponseBody getBody() {
        return this.body;
    }

}
