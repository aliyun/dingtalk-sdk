// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListDeptMembersRequest extends TeaModel {
    /**
     * <p>页码</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>单页的条目数</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>供应链部门id</p>
     */
    @NameInMap("supplyDeptId")
    public Long supplyDeptId;

    public static SupplyListDeptMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyListDeptMembersRequest self = new SupplyListDeptMembersRequest();
        return TeaModel.build(map, self);
    }

    public SupplyListDeptMembersRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public SupplyListDeptMembersRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public SupplyListDeptMembersRequest setSupplyDeptId(Long supplyDeptId) {
        this.supplyDeptId = supplyDeptId;
        return this;
    }
    public Long getSupplyDeptId() {
        return this.supplyDeptId;
    }

}
