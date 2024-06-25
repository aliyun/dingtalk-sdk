// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDeleteRenterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    public static CampusDeleteRenterRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusDeleteRenterRequest self = new CampusDeleteRenterRequest();
        return TeaModel.build(map, self);
    }

    public CampusDeleteRenterRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

}
