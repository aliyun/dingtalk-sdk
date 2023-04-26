// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstalledRobotResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateInstalledRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstalledRobotResponseBody self = new UpdateInstalledRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInstalledRobotResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
