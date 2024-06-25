// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListRenterMembersRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>836213123</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    public static CampusListRenterMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusListRenterMembersRequest self = new CampusListRenterMembersRequest();
        return TeaModel.build(map, self);
    }

    public CampusListRenterMembersRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

}
