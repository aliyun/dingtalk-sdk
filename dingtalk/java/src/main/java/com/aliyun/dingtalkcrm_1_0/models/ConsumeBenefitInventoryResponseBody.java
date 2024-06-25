// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ConsumeBenefitInventoryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static ConsumeBenefitInventoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConsumeBenefitInventoryResponseBody self = new ConsumeBenefitInventoryResponseBody();
        return TeaModel.build(map, self);
    }

    public ConsumeBenefitInventoryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
