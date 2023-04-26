// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterResponseBody extends TeaModel {
    @NameInMap("renterId")
    public String renterId;

    public static CampusUpdateRenterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateRenterResponseBody self = new CampusUpdateRenterResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusUpdateRenterResponseBody setRenterId(String renterId) {
        this.renterId = renterId;
        return this;
    }
    public String getRenterId() {
        return this.renterId;
    }

}
