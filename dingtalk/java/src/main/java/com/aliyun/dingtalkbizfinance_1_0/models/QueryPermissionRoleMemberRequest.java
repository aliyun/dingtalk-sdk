// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionRoleMemberRequest extends TeaModel {
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("roleCodeList")
    public java.util.List<String> roleCodeList;

    public static QueryPermissionRoleMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionRoleMemberRequest self = new QueryPermissionRoleMemberRequest();
        return TeaModel.build(map, self);
    }

    public QueryPermissionRoleMemberRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public QueryPermissionRoleMemberRequest setRoleCodeList(java.util.List<String> roleCodeList) {
        this.roleCodeList = roleCodeList;
        return this;
    }
    public java.util.List<String> getRoleCodeList() {
        return this.roleCodeList;
    }

}
