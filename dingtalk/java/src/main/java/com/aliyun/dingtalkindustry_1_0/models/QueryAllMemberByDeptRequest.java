// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByDeptRequest extends TeaModel {
    // 分页查询页容量
    @NameInMap("pageSize")
    public Integer pageSize;

    // 分页查询页码
    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static QueryAllMemberByDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByDeptRequest self = new QueryAllMemberByDeptRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByDeptRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryAllMemberByDeptRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}
