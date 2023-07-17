// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotRecallDingResponseBody extends TeaModel {
    @NameInMap("openDingId")
    public String openDingId;

    public static RobotRecallDingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RobotRecallDingResponseBody self = new RobotRecallDingResponseBody();
        return TeaModel.build(map, self);
    }

    public RobotRecallDingResponseBody setOpenDingId(String openDingId) {
        this.openDingId = openDingId;
        return this;
    }
    public String getOpenDingId() {
        return this.openDingId;
    }

}
