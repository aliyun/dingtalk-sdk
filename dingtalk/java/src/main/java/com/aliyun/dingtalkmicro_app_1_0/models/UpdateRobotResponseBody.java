// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    public static UpdateRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotResponseBody self = new UpdateRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRobotResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public UpdateRobotResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

}
