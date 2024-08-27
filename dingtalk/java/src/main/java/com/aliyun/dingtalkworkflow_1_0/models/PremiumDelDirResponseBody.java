// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumDelDirResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static PremiumDelDirResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumDelDirResponseBody self = new PremiumDelDirResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumDelDirResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
