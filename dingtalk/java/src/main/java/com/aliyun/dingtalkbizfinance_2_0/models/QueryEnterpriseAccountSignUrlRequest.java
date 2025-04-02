// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountSignUrlRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ACC_X12133</p>
     */
    @NameInMap("accountCode")
    public String accountCode;

    /**
     * <strong>example:</strong>
     * <p>5041145245</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryEnterpriseAccountSignUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseAccountSignUrlRequest self = new QueryEnterpriseAccountSignUrlRequest();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseAccountSignUrlRequest setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
    }

    public QueryEnterpriseAccountSignUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
