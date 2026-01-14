// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class EnableEnterpriseAccountResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static EnableEnterpriseAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EnableEnterpriseAccountResponseBody self = new EnableEnterpriseAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public EnableEnterpriseAccountResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
