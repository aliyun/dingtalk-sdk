// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpgradeToServiceGroupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpgradeToServiceGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpgradeToServiceGroupResponseBody self = new UpgradeToServiceGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public UpgradeToServiceGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
