// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmeter_1_0.models;

import com.aliyun.tea.*;

public class GetResourceUseInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("benefitCodeList")
    public java.util.List<String> benefitCodeList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("period")
    public String period;

    public static GetResourceUseInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetResourceUseInfoRequest self = new GetResourceUseInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetResourceUseInfoRequest setBenefitCodeList(java.util.List<String> benefitCodeList) {
        this.benefitCodeList = benefitCodeList;
        return this;
    }
    public java.util.List<String> getBenefitCodeList() {
        return this.benefitCodeList;
    }

    public GetResourceUseInfoRequest setPeriod(String period) {
        this.period = period;
        return this;
    }
    public String getPeriod() {
        return this.period;
    }

}
