// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotRecallEmotionResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RobotRecallEmotionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RobotRecallEmotionResponseBody self = new RobotRecallEmotionResponseBody();
        return TeaModel.build(map, self);
    }

    public RobotRecallEmotionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
