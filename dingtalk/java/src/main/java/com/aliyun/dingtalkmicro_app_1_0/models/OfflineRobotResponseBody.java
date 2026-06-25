// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class OfflineRobotResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    public static OfflineRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OfflineRobotResponseBody self = new OfflineRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public OfflineRobotResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public OfflineRobotResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

}
