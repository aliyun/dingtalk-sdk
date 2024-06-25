// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddDeptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>闪电供应商</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <strong>example:</strong>
     * <p>G12345</p>
     */
    @NameInMap("partnerNumber")
    public String partnerNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1111</p>
     */
    @NameInMap("superDeptId")
    public Long superDeptId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUPPLY_CHAIN_DEPT_TYPE</p>
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
