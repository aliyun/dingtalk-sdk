// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDpaasDataPackageResponseBody extends TeaModel {
    @NameInMap("buy")
    public Boolean buy;

    @NameInMap("quota")
    public Long quota;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("usedNum")
    public Long usedNum;

    @NameInMap("whiteCustomer")
    public Boolean whiteCustomer;

    public static QueryDpaasDataPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDpaasDataPackageResponseBody self = new QueryDpaasDataPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDpaasDataPackageResponseBody setBuy(Boolean buy) {
        this.buy = buy;
        return this;
    }
    public Boolean getBuy() {
        return this.buy;
    }

    public QueryDpaasDataPackageResponseBody setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public QueryDpaasDataPackageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public QueryDpaasDataPackageResponseBody setUsedNum(Long usedNum) {
        this.usedNum = usedNum;
        return this;
    }
    public Long getUsedNum() {
        return this.usedNum;
    }

    public QueryDpaasDataPackageResponseBody setWhiteCustomer(Boolean whiteCustomer) {
        this.whiteCustomer = whiteCustomer;
        return this;
    }
    public Boolean getWhiteCustomer() {
        return this.whiteCustomer;
    }

}
