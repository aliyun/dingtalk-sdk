// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QuerySupplierByPageRequest extends TeaModel {
    // 分页，从1开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小，默认10
    @NameInMap("pageSize")
    public Long pageSize;

    public static QuerySupplierByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySupplierByPageRequest self = new QuerySupplierByPageRequest();
        return TeaModel.build(map, self);
    }

    public QuerySupplierByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QuerySupplierByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
