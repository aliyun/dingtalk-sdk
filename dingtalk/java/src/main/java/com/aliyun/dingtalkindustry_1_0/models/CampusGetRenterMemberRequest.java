// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterMemberRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1987215</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1iasndkjas8</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CampusGetRenterMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusGetRenterMemberRequest self = new CampusGetRenterMemberRequest();
        return TeaModel.build(map, self);
    }

    public CampusGetRenterMemberRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

    public CampusGetRenterMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
