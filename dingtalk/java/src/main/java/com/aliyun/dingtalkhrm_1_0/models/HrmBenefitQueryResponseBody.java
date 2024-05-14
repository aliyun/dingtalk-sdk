// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmBenefitQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public Object result;

    public static HrmBenefitQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmBenefitQueryResponseBody self = new HrmBenefitQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmBenefitQueryResponseBody setResult(Object result) {
        this.result = result;
        return this;
    }
    public Object getResult() {
        return this.result;
    }

}
