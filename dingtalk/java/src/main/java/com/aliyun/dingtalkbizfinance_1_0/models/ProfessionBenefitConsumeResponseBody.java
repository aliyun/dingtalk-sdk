// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class ProfessionBenefitConsumeResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ProfessionBenefitConsumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProfessionBenefitConsumeResponseBody self = new ProfessionBenefitConsumeResponseBody();
        return TeaModel.build(map, self);
    }

    public ProfessionBenefitConsumeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
