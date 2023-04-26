// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class WearOrgHonorRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    @NameInMap("wear")
    public Boolean wear;

    public static WearOrgHonorRequest build(java.util.Map<String, ?> map) throws Exception {
        WearOrgHonorRequest self = new WearOrgHonorRequest();
        return TeaModel.build(map, self);
    }

    public WearOrgHonorRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public WearOrgHonorRequest setWear(Boolean wear) {
        this.wear = wear;
        return this;
    }
    public Boolean getWear() {
        return this.wear;
    }

}
