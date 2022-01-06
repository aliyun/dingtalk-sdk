// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalDistrictInfoRequest extends TeaModel {
    // 分页查询分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 分页查询页码
    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static QueryHospitalDistrictInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalDistrictInfoRequest self = new QueryHospitalDistrictInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryHospitalDistrictInfoRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryHospitalDistrictInfoRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}