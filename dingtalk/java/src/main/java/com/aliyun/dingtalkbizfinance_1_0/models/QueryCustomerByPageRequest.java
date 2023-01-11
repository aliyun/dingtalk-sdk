// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerByPageRequest extends TeaModel {
    /**
     * <p>分页，从1开始</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>分页大小，默认10</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryCustomerByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerByPageRequest self = new QueryCustomerByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomerByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryCustomerByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
