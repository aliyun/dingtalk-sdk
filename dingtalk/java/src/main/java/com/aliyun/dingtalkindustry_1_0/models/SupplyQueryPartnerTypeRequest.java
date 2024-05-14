// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyQueryPartnerTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("labelId")
    public Long labelId;

    public static SupplyQueryPartnerTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyQueryPartnerTypeRequest self = new SupplyQueryPartnerTypeRequest();
        return TeaModel.build(map, self);
    }

    public SupplyQueryPartnerTypeRequest setLabelId(Long labelId) {
        this.labelId = labelId;
        return this;
    }
    public Long getLabelId() {
        return this.labelId;
    }

}
