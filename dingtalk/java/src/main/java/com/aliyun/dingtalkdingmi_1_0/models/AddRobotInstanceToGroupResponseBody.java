// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AddRobotInstanceToGroupResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static AddRobotInstanceToGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRobotInstanceToGroupResponseBody self = new AddRobotInstanceToGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRobotInstanceToGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
