// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotSendDingResponseBody extends TeaModel {
    @NameInMap("failedList")
    public java.util.Map<String, ?> failedList;

    @NameInMap("openDingId")
    public String openDingId;

    public static RobotSendDingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RobotSendDingResponseBody self = new RobotSendDingResponseBody();
        return TeaModel.build(map, self);
    }

    public RobotSendDingResponseBody setFailedList(java.util.Map<String, ?> failedList) {
        this.failedList = failedList;
        return this;
    }
    public java.util.Map<String, ?> getFailedList() {
        return this.failedList;
    }

    public RobotSendDingResponseBody setOpenDingId(String openDingId) {
        this.openDingId = openDingId;
        return this;
    }
    public String getOpenDingId() {
        return this.openDingId;
    }

}
