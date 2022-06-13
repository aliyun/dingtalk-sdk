// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsRequest extends TeaModel {
    @NameInMap("monthMark")
    public String monthMark;

    // 分页查询页码
    @NameInMap("pageNum")
    public Integer pageNum;

    // 分页查询页容量
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryAllDoctorsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDoctorsRequest self = new QueryAllDoctorsRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllDoctorsRequest setMonthMark(String monthMark) {
        this.monthMark = monthMark;
        return this;
    }
    public String getMonthMark() {
        return this.monthMark;
    }

    public QueryAllDoctorsRequest setPageNum(Integer pageNum) {
        this.pageNum = pageNum;
        return this;
    }
    public Integer getPageNum() {
        return this.pageNum;
    }

    public QueryAllDoctorsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
