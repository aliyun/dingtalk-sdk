// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class InstallRobotToOrgResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static InstallRobotToOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InstallRobotToOrgResponseBody self = new InstallRobotToOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public InstallRobotToOrgResponseBody setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
