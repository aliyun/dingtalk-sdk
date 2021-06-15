// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByGroupRequest extends TeaModel {
    // 分页查询分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 分页查询页码
    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static QueryAllMemberByGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByGroupRequest self = new QueryAllMemberByGroupRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByGroupRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryAllMemberByGroupRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}
