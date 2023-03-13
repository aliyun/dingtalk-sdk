// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryProductByPageRequest extends TeaModel {
    /**
     * <p>分页数</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryProductByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryProductByPageRequest self = new QueryProductByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryProductByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryProductByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
