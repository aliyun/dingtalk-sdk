// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpgradeToExternalGroupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpgradeToExternalGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpgradeToExternalGroupResponseBody self = new UpgradeToExternalGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public UpgradeToExternalGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
