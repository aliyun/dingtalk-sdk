// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddDeptRequest extends TeaModel {
    /**
     * <p>部门名字</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <p>供应商编号</p>
     */
    @NameInMap("partnerNumber")
    public String partnerNumber;

    /**
     * <p>上级部门id</p>
     */
    @NameInMap("superDeptId")
    public Long superDeptId;

    /**
     * <p>供应链部门类型</p>
     */
    @NameInMap("supplyDeptType")
    public String supplyDeptType;

    public static SupplyAddDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddDeptRequest self = new SupplyAddDeptRequest();
        return TeaModel.build(map, self);
    }

    public SupplyAddDeptRequest setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public SupplyAddDeptRequest setPartnerNumber(String partnerNumber) {
        this.partnerNumber = partnerNumber;
        return this;
    }
    public String getPartnerNumber() {
        return this.partnerNumber;
    }

    public SupplyAddDeptRequest setSuperDeptId(Long superDeptId) {
        this.superDeptId = superDeptId;
        return this;
    }
    public Long getSuperDeptId() {
        return this.superDeptId;
    }

    public SupplyAddDeptRequest setSupplyDeptType(String supplyDeptType) {
        this.supplyDeptType = supplyDeptType;
        return this;
    }
    public String getSupplyDeptType() {
        return this.supplyDeptType;
    }

}
