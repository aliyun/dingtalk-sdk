// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerManagersRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("interfaceId")
    public String interfaceId;

    @NameInMap("interfaceType")
    public String interfaceType;

    public static SupplyDeletePartnerManagersRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerManagersRequest self = new SupplyDeletePartnerManagersRequest();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerManagersRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public SupplyDeletePartnerManagersRequest setInterfaceId(String interfaceId) {
        this.interfaceId = interfaceId;
        return this;
    }
    public String getInterfaceId() {
        return this.interfaceId;
    }

    public SupplyDeletePartnerManagersRequest setInterfaceType(String interfaceType) {
        this.interfaceType = interfaceType;
        return this;
    }
    public String getInterfaceType() {
        return this.interfaceType;
    }

}
