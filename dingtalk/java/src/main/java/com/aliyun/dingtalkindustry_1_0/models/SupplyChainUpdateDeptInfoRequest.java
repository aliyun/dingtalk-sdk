// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainUpdateDeptInfoRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("partnerNumber")
    public String partnerNumber;

    @NameInMap("partnerTypeList")
    public java.util.List<Long> partnerTypeList;

    @NameInMap("superId")
    public Long superId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("supplyDeptId")
    public Long supplyDeptId;

    public static SupplyChainUpdateDeptInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainUpdateDeptInfoRequest self = new SupplyChainUpdateDeptInfoRequest();
        return TeaModel.build(map, self);
    }

    public SupplyChainUpdateDeptInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SupplyChainUpdateDeptInfoRequest setPartnerNumber(String partnerNumber) {
        this.partnerNumber = partnerNumber;
        return this;
    }
    public String getPartnerNumber() {
        return this.partnerNumber;
    }

    public SupplyChainUpdateDeptInfoRequest setPartnerTypeList(java.util.List<Long> partnerTypeList) {
        this.partnerTypeList = partnerTypeList;
        return this;
    }
    public java.util.List<Long> getPartnerTypeList() {
        return this.partnerTypeList;
    }

    public SupplyChainUpdateDeptInfoRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

    public SupplyChainUpdateDeptInfoRequest setSupplyDeptId(Long supplyDeptId) {
        this.supplyDeptId = supplyDeptId;
        return this;
    }
    public Long getSupplyDeptId() {
        return this.supplyDeptId;
    }

}
