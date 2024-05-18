// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class OpenBenefitPackageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("benefitPackage")
    public Integer benefitPackage;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endDate")
    public Long endDate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startDate")
    public Long startDate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static OpenBenefitPackageRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenBenefitPackageRequest self = new OpenBenefitPackageRequest();
        return TeaModel.build(map, self);
    }

    public OpenBenefitPackageRequest setBenefitPackage(Integer benefitPackage) {
        this.benefitPackage = benefitPackage;
        return this;
    }
    public Integer getBenefitPackage() {
        return this.benefitPackage;
    }

    public OpenBenefitPackageRequest setEndDate(Long endDate) {
        this.endDate = endDate;
        return this;
    }
    public Long getEndDate() {
        return this.endDate;
    }

    public OpenBenefitPackageRequest setStartDate(Long startDate) {
        this.startDate = startDate;
        return this;
    }
    public Long getStartDate() {
        return this.startDate;
    }

    public OpenBenefitPackageRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
