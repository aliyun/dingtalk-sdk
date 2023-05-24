// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerTypeRequest extends TeaModel {
    @NameInMap("labelId")
    public Long labelId;

    public static SupplyDeletePartnerTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerTypeRequest self = new SupplyDeletePartnerTypeRequest();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerTypeRequest setLabelId(Long labelId) {
        this.labelId = labelId;
        return this;
    }
    public Long getLabelId() {
        return this.labelId;
    }

}
