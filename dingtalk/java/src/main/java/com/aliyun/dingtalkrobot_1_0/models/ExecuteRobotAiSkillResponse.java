// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ExecuteRobotAiSkillResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ExecuteRobotAiSkillResponseBody body;

    public static ExecuteRobotAiSkillResponse build(java.util.Map<String, ?> map) throws Exception {
        ExecuteRobotAiSkillResponse self = new ExecuteRobotAiSkillResponse();
        return TeaModel.build(map, self);
    }

    public ExecuteRobotAiSkillResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExecuteRobotAiSkillResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExecuteRobotAiSkillResponse setBody(ExecuteRobotAiSkillResponseBody body) {
        this.body = body;
        return this;
    }
    public ExecuteRobotAiSkillResponseBody getBody() {
        return this.body;
    }

}
