// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceEnterpriseAccountResponseBody extends TeaModel {
    @NameInMap("accountCode")
    public String accountCode;

    public static UpdateFinanceEnterpriseAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceEnterpriseAccountResponseBody self = new UpdateFinanceEnterpriseAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceEnterpriseAccountResponseBody setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
    }

}
