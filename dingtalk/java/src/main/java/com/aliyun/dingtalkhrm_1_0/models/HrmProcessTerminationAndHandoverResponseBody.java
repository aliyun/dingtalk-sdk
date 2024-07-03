// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTerminationAndHandoverResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static HrmProcessTerminationAndHandoverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessTerminationAndHandoverResponseBody self = new HrmProcessTerminationAndHandoverResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmProcessTerminationAndHandoverResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
