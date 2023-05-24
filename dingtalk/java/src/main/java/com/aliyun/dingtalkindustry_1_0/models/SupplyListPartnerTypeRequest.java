// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerTypeRequest extends TeaModel {
    @NameInMap("labelId")
    public Long labelId;

    public static SupplyListPartnerTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerTypeRequest self = new SupplyListPartnerTypeRequest();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerTypeRequest setLabelId(Long labelId) {
        this.labelId = labelId;
        return this;
    }
    public Long getLabelId() {
        return this.labelId;
    }

}
