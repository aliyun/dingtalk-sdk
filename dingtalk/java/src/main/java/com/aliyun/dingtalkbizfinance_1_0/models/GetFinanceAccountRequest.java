// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetFinanceAccountRequest extends TeaModel {
    @NameInMap("accountCode")
    public String accountCode;

    public static GetFinanceAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFinanceAccountRequest self = new GetFinanceAccountRequest();
        return TeaModel.build(map, self);
    }

    public GetFinanceAccountRequest setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
    }

}
