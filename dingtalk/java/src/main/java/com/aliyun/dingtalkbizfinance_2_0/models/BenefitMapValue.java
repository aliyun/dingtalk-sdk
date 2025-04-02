// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BenefitMapValue extends TeaModel {
    @NameInMap("canUse")
    public Boolean canUse;

    @NameInMap("canUseQuota")
    public Long canUseQuota;

    @NameInMap("usedQuota")
    public Long usedQuota;

    public static BenefitMapValue build(java.util.Map<String, ?> map) throws Exception {
        BenefitMapValue self = new BenefitMapValue();
        return TeaModel.build(map, self);
    }

    public BenefitMapValue setCanUse(Boolean canUse) {
        this.canUse = canUse;
        return this;
    }
    public Boolean getCanUse() {
        return this.canUse;
    }

    public BenefitMapValue setCanUseQuota(Long canUseQuota) {
        this.canUseQuota = canUseQuota;
        return this;
    }
    public Long getCanUseQuota() {
        return this.canUseQuota;
    }

    public BenefitMapValue setUsedQuota(Long usedQuota) {
        this.usedQuota = usedQuota;
        return this;
    }
    public Long getUsedQuota() {
        return this.usedQuota;
    }

}
