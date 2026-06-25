// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class EnableRobotResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    public static EnableRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EnableRobotResponseBody self = new EnableRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public EnableRobotResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public EnableRobotResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

}
