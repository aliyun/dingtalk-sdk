// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInOrgResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static UpdateRobotInOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotInOrgResponseBody self = new UpdateRobotInOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRobotInOrgResponseBody setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
