// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AddRobotInstanceToGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddRobotInstanceToGroupResponseBody body;

    public static AddRobotInstanceToGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        AddRobotInstanceToGroupResponse self = new AddRobotInstanceToGroupResponse();
        return TeaModel.build(map, self);
    }

    public AddRobotInstanceToGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddRobotInstanceToGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddRobotInstanceToGroupResponse setBody(AddRobotInstanceToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public AddRobotInstanceToGroupResponseBody getBody() {
        return this.body;
    }

}
