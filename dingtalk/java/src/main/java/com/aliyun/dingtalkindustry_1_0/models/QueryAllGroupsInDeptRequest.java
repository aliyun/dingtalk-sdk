// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupsInDeptRequest extends TeaModel {
    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryAllGroupsInDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllGroupsInDeptRequest self = new QueryAllGroupsInDeptRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllGroupsInDeptRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryAllGroupsInDeptRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
