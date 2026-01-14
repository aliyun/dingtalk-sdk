// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class EnableEnterpriseAccountRequest extends TeaModel {
    @NameInMap("accountCode")
    public String accountCode;

    @NameInMap("userId")
    public String userId;

    public static EnableEnterpriseAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        EnableEnterpriseAccountRequest self = new EnableEnterpriseAccountRequest();
        return TeaModel.build(map, self);
    }

    public EnableEnterpriseAccountRequest setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
    }

    public EnableEnterpriseAccountRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
