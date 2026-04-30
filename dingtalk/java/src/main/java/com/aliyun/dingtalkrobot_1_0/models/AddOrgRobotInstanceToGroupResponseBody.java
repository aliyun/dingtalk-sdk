// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class AddOrgRobotInstanceToGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static AddOrgRobotInstanceToGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOrgRobotInstanceToGroupResponseBody self = new AddOrgRobotInstanceToGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOrgRobotInstanceToGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
