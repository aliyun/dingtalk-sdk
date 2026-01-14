// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CancelSignEnterpriseAccountRequest extends TeaModel {
    @NameInMap("accountCode")
    public String accountCode;

    @NameInMap("userId")
    public String userId;

    public static CancelSignEnterpriseAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelSignEnterpriseAccountRequest self = new CancelSignEnterpriseAccountRequest();
        return TeaModel.build(map, self);
    }

    public CancelSignEnterpriseAccountRequest setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
    }

    public CancelSignEnterpriseAccountRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
