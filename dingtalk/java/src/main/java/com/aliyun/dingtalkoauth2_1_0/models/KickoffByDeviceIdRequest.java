// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class KickoffByDeviceIdRequest extends TeaModel {
    @NameInMap("openDeviceId")
    public String openDeviceId;

    @NameInMap("userId")
    public String userId;

    public static KickoffByDeviceIdRequest build(java.util.Map<String, ?> map) throws Exception {
        KickoffByDeviceIdRequest self = new KickoffByDeviceIdRequest();
        return TeaModel.build(map, self);
    }

    public KickoffByDeviceIdRequest setOpenDeviceId(String openDeviceId) {
        this.openDeviceId = openDeviceId;
        return this;
    }
    public String getOpenDeviceId() {
        return this.openDeviceId;
    }

    public KickoffByDeviceIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
