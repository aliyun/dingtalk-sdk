// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CancelSignEnterpriseAccountResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CancelSignEnterpriseAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelSignEnterpriseAccountResponseBody self = new CancelSignEnterpriseAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelSignEnterpriseAccountResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
