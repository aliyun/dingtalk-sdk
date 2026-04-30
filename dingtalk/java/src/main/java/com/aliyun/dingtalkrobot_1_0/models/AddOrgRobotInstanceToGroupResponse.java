// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class AddOrgRobotInstanceToGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddOrgRobotInstanceToGroupResponseBody body;

    public static AddOrgRobotInstanceToGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        AddOrgRobotInstanceToGroupResponse self = new AddOrgRobotInstanceToGroupResponse();
        return TeaModel.build(map, self);
    }

    public AddOrgRobotInstanceToGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddOrgRobotInstanceToGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddOrgRobotInstanceToGroupResponse setBody(AddOrgRobotInstanceToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOrgRobotInstanceToGroupResponseBody getBody() {
        return this.body;
    }

}
