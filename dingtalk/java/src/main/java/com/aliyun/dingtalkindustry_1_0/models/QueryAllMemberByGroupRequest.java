// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByGroupRequest extends TeaModel {
    /**
     * <p>按月查询标识</p>
     */
    @NameInMap("monthMark")
    public String monthMark;

    /**
     * <p>分页查询页码</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页查询分页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryAllMemberByGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByGroupRequest self = new QueryAllMemberByGroupRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByGroupRequest setMonthMark(String monthMark) {
        this.monthMark = monthMark;
        return this;
    }
    public String getMonthMark() {
        return this.monthMark;
    }

    public QueryAllMemberByGroupRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryAllMemberByGroupRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
