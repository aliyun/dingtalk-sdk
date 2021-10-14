// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetIntelligentRobotInfoRequest extends TeaModel {
    // 机器人业务标识
    @NameInMap("robotAppKey")
    public String robotAppKey;

    public static GetIntelligentRobotInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetIntelligentRobotInfoRequest self = new GetIntelligentRobotInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetIntelligentRobotInfoRequest setRobotAppKey(String robotAppKey) {
        this.robotAppKey = robotAppKey;
        return this;
    }
    public String getRobotAppKey() {
        return this.robotAppKey;
    }

}
