// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumUpdateProcessInstanceVariablesResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static PremiumUpdateProcessInstanceVariablesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumUpdateProcessInstanceVariablesResponseBody self = new PremiumUpdateProcessInstanceVariablesResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumUpdateProcessInstanceVariablesResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
