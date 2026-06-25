// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class EnableRobotRequest extends TeaModel {
    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    @NameInMap("userId")
    public String userId;

    public static EnableRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        EnableRobotRequest self = new EnableRobotRequest();
        return TeaModel.build(map, self);
    }

    public EnableRobotRequest setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public EnableRobotRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
