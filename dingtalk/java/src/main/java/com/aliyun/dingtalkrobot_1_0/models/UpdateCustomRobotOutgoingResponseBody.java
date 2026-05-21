// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomRobotOutgoingResponseBody extends TeaModel {
    @NameInMap("originalUrl")
    public String originalUrl;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("targetUrl")
    public String targetUrl;

    public static UpdateCustomRobotOutgoingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomRobotOutgoingResponseBody self = new UpdateCustomRobotOutgoingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCustomRobotOutgoingResponseBody setOriginalUrl(String originalUrl) {
        this.originalUrl = originalUrl;
        return this;
    }
    public String getOriginalUrl() {
        return this.originalUrl;
    }

    public UpdateCustomRobotOutgoingResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public UpdateCustomRobotOutgoingResponseBody setTargetUrl(String targetUrl) {
        this.targetUrl = targetUrl;
        return this;
    }
    public String getTargetUrl() {
        return this.targetUrl;
    }

}
