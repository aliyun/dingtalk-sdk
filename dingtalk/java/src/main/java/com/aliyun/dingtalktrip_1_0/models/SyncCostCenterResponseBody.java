// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncCostCenterResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncCostCenterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncCostCenterResponseBody self = new SyncCostCenterResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncCostCenterResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
