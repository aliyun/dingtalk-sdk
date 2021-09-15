// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCategoryByPageRequest extends TeaModel {
    // 分页，从1开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小，默认10
    @NameInMap("pageSize")
    public Long pageSize;

    // 类型：income收入，expense支出
    @NameInMap("type")
    public String type;

    public static QueryCategoryByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCategoryByPageRequest self = new QueryCategoryByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryCategoryByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryCategoryByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryCategoryByPageRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
