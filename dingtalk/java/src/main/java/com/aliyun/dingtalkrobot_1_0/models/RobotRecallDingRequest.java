// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotRecallDingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openDingId")
    public String openDingId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static RobotRecallDingRequest build(java.util.Map<String, ?> map) throws Exception {
        RobotRecallDingRequest self = new RobotRecallDingRequest();
        return TeaModel.build(map, self);
    }

    public RobotRecallDingRequest setOpenDingId(String openDingId) {
        this.openDingId = openDingId;
        return this;
    }
    public String getOpenDingId() {
        return this.openDingId;
    }

    public RobotRecallDingRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
