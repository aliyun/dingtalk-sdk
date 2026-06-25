// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class InactiveAppRequest extends TeaModel {
    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    @NameInMap("userId")
    public String userId;

    public static InactiveAppRequest build(java.util.Map<String, ?> map) throws Exception {
        InactiveAppRequest self = new InactiveAppRequest();
        return TeaModel.build(map, self);
    }

    public InactiveAppRequest setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public InactiveAppRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
