// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsRequest extends TeaModel {
    @NameInMap("monthMark")
    public String monthMark;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNum")
    public Integer pageNum;

    /**
     * <strong>example:</strong>
     * <p>200</p>
     */
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
