// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRoleMemberByPageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxResults")
    public String maxResults;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>financeManager</p>
     */
    @NameInMap("roleCode")
    public String roleCode;

    public static QueryRoleMemberByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRoleMemberByPageRequest self = new QueryRoleMemberByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryRoleMemberByPageRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public QueryRoleMemberByPageRequest setMaxResults(String maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public String getMaxResults() {
        return this.maxResults;
    }

    public QueryRoleMemberByPageRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryRoleMemberByPageRequest setRoleCode(String roleCode) {
        this.roleCode = roleCode;
        return this;
    }
    public String getRoleCode() {
        return this.roleCode;
    }

}
