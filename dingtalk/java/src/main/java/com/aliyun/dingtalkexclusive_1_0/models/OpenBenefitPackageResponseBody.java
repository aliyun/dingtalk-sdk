// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class OpenBenefitPackageResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static OpenBenefitPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenBenefitPackageResponseBody self = new OpenBenefitPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenBenefitPackageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
