// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCidsByBotCodeRequest extends TeaModel {
    @NameInMap("robotCode")
    public String robotCode;

    public static GetCidsByBotCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCidsByBotCodeRequest self = new GetCidsByBotCodeRequest();
        return TeaModel.build(map, self);
    }

    public GetCidsByBotCodeRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
