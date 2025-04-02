// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AddFinanceEnterpriseAccountResponseBody extends TeaModel {
    @NameInMap("accountCode")
    public String accountCode;

    public static AddFinanceEnterpriseAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddFinanceEnterpriseAccountResponseBody self = new AddFinanceEnterpriseAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public AddFinanceEnterpriseAccountResponseBody setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
    }

}
