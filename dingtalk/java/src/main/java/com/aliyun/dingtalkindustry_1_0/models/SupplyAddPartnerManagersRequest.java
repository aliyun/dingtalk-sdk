// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerManagersRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("interfaceId")
    public String interfaceId;

    @NameInMap("interfaceType")
    public String interfaceType;

    public static SupplyAddPartnerManagersRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerManagersRequest self = new SupplyAddPartnerManagersRequest();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerManagersRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public SupplyAddPartnerManagersRequest setInterfaceId(String interfaceId) {
        this.interfaceId = interfaceId;
        return this;
    }
    public String getInterfaceId() {
        return this.interfaceId;
    }

    public SupplyAddPartnerManagersRequest setInterfaceType(String interfaceType) {
        this.interfaceType = interfaceType;
        return this;
    }
    public String getInterfaceType() {
        return this.interfaceType;
    }

}
