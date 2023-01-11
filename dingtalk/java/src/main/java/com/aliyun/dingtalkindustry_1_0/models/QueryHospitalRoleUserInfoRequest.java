// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRoleUserInfoRequest extends TeaModel {
    /**
     * <p>分页查询页码</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>分页查询分页大小</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryHospitalRoleUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalRoleUserInfoRequest self = new QueryHospitalRoleUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryHospitalRoleUserInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryHospitalRoleUserInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
