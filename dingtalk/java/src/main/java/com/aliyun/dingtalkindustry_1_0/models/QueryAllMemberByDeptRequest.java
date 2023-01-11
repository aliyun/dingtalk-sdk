// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByDeptRequest extends TeaModel {
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
     * <p>分页查询页容量</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryAllMemberByDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByDeptRequest self = new QueryAllMemberByDeptRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByDeptRequest setMonthMark(String monthMark) {
        this.monthMark = monthMark;
        return this;
    }
    public String getMonthMark() {
        return this.monthMark;
    }

    public QueryAllMemberByDeptRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryAllMemberByDeptRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
