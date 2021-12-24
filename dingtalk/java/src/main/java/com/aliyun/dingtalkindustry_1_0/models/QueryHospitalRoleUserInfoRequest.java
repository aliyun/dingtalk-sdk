// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRoleUserInfoRequest extends TeaModel {
    // 分页查询分页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 分页查询页码
    @NameInMap("pageNumber")
    public Long pageNumber;

    public static QueryHospitalRoleUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalRoleUserInfoRequest self = new QueryHospitalRoleUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryHospitalRoleUserInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryHospitalRoleUserInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

}
