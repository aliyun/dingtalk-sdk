// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncCostCenterEntityResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncCostCenterEntityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncCostCenterEntityResponseBody self = new SyncCostCenterEntityResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncCostCenterEntityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
