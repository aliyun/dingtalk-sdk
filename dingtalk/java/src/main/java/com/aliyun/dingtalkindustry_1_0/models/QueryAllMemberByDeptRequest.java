// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByDeptRequest extends TeaModel {
    @NameInMap("monthMark")
    public String monthMark;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>200</p>
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
