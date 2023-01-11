// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterRequest extends TeaModel {
    /**
     * <p>租客ID</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    public static CampusGetRenterRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusGetRenterRequest self = new CampusGetRenterRequest();
        return TeaModel.build(map, self);
    }

    public CampusGetRenterRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

}
