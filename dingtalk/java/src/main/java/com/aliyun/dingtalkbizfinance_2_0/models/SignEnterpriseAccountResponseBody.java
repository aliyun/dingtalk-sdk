// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class SignEnterpriseAccountResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SignEnterpriseAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SignEnterpriseAccountResponseBody self = new SignEnterpriseAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public SignEnterpriseAccountResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
