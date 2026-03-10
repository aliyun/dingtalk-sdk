// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotReplyEmotionResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RobotReplyEmotionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RobotReplyEmotionResponseBody self = new RobotReplyEmotionResponseBody();
        return TeaModel.build(map, self);
    }

    public RobotReplyEmotionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
