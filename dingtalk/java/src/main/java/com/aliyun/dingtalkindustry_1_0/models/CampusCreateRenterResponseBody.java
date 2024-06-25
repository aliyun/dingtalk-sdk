// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateRenterResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("renterId")
    public String renterId;

    public static CampusCreateRenterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateRenterResponseBody self = new CampusCreateRenterResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusCreateRenterResponseBody setRenterId(String renterId) {
        this.renterId = renterId;
        return this;
    }
    public String getRenterId() {
        return this.renterId;
    }

}
