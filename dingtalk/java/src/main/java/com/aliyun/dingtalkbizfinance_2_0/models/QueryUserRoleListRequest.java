// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryUserRoleListRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    /**
     * <strong>example:</strong>
     * <p>12312231231</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryUserRoleListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserRoleListRequest self = new QueryUserRoleListRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserRoleListRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public QueryUserRoleListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
