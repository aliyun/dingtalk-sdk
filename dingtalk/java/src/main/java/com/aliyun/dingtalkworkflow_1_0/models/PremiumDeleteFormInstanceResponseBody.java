// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumDeleteFormInstanceResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static PremiumDeleteFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumDeleteFormInstanceResponseBody self = new PremiumDeleteFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumDeleteFormInstanceResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
