// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>标签名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>862</p>
     */
    @NameInMap("superId")
    public Long superId;

    public static SupplyAddPartnerTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerTypeRequest self = new SupplyAddPartnerTypeRequest();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerTypeRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SupplyAddPartnerTypeRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

}
