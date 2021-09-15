// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountByPageRequest extends TeaModel {
    // 分页，从1开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小，默认10
    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryEnterpriseAccountByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseAccountByPageRequest self = new QueryEnterpriseAccountByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseAccountByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryEnterpriseAccountByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
