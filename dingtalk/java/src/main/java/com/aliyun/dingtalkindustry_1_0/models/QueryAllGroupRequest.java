// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupRequest extends TeaModel {
    /**
     * <p>分页查询页码</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页查询页容量</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryAllGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllGroupRequest self = new QueryAllGroupRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllGroupRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryAllGroupRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
