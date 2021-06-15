// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsRequest extends TeaModel {
    // 分页查询页容量
    @NameInMap("pageSize")
    public Integer pageSize;

    // 分页查询页码
    @NameInMap("pageNum")
    public Integer pageNum;

    public static QueryAllDoctorsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDoctorsRequest self = new QueryAllDoctorsRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllDoctorsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryAllDoctorsRequest setPageNum(Integer pageNum) {
        this.pageNum = pageNum;
        return this;
    }
    public Integer getPageNum() {
        return this.pageNum;
    }

}
