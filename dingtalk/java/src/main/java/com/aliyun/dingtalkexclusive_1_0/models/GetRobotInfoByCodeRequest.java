// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRobotInfoByCodeRequest extends TeaModel {
    @NameInMap("robotCode")
    public String robotCode;

    public static GetRobotInfoByCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRobotInfoByCodeRequest self = new GetRobotInfoByCodeRequest();
        return TeaModel.build(map, self);
    }

    public GetRobotInfoByCodeRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
