// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDepartmentRequest extends TeaModel {
    // 分页查询分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 分页查询页码
    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static QueryAllDepartmentRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDepartmentRequest self = new QueryAllDepartmentRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllDepartmentRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryAllDepartmentRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}
