// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdatePartnerTypeRequest extends TeaModel {
    @NameInMap("labelId")
    public Long labelId;

    @NameInMap("name")
    public String name;

    @NameInMap("superId")
    public Long superId;

    public static SupplyUpdatePartnerTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdatePartnerTypeRequest self = new SupplyUpdatePartnerTypeRequest();
        return TeaModel.build(map, self);
    }

    public SupplyUpdatePartnerTypeRequest setLabelId(Long labelId) {
        this.labelId = labelId;
        return this;
    }
    public Long getLabelId() {
        return this.labelId;
    }

    public SupplyUpdatePartnerTypeRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SupplyUpdatePartnerTypeRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

}
