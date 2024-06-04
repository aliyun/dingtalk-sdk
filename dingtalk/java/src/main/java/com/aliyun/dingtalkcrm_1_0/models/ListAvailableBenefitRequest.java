// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListAvailableBenefitRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("benefitCodeList")
    public java.util.List<String> benefitCodeList;

    public static ListAvailableBenefitRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAvailableBenefitRequest self = new ListAvailableBenefitRequest();
        return TeaModel.build(map, self);
    }

    public ListAvailableBenefitRequest setBenefitCodeList(java.util.List<String> benefitCodeList) {
        this.benefitCodeList = benefitCodeList;
        return this;
    }
    public java.util.List<String> getBenefitCodeList() {
        return this.benefitCodeList;
    }

}
