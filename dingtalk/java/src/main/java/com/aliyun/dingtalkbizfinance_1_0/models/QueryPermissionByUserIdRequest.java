// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionByUserIdRequest extends TeaModel {
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("userId")
    public String userId;

    public static QueryPermissionByUserIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionByUserIdRequest self = new QueryPermissionByUserIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryPermissionByUserIdRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public QueryPermissionByUserIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
