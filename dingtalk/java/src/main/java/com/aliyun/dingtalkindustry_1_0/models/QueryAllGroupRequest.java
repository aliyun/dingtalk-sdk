// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupRequest extends TeaModel {
    // 分页查询页容量
    @NameInMap("pageSize")
    public Integer pageSize;

    // 分页查询页码
    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static QueryAllGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllGroupRequest self = new QueryAllGroupRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllGroupRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryAllGroupRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}
