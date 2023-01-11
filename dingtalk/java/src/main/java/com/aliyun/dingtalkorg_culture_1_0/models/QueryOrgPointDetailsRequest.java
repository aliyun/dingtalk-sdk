// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgPointDetailsRequest extends TeaModel {
    /**
     * <p>查询企业账号明细，ORG,ORG_DEDUCTIONS两种。     ORG:企业账户明细 查询的是企业积分发放明细       ORG_DEDUCTIONS:扣除账户明细，查询的是企业扣减积分明细</p>
     */
    @NameInMap("accountType")
    public String accountType;

    /**
     * <p>查询页数 第一页是1 非空必传</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>每页大小最多50，默认10</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>操作人userId 必须是管理员</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryOrgPointDetailsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgPointDetailsRequest self = new QueryOrgPointDetailsRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgPointDetailsRequest setAccountType(String accountType) {
        this.accountType = accountType;
        return this;
    }
    public String getAccountType() {
        return this.accountType;
    }

    public QueryOrgPointDetailsRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryOrgPointDetailsRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryOrgPointDetailsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
