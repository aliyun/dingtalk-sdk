// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDelRenterMemberRequest extends TeaModel {
    // 租客唯一id
    @NameInMap("renterId")
    public Long renterId;

    // 人员唯一标识
    @NameInMap("unionId")
    public String unionId;

    public static CampusDelRenterMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusDelRenterMemberRequest self = new CampusDelRenterMemberRequest();
        return TeaModel.build(map, self);
    }

    public CampusDelRenterMemberRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

    public CampusDelRenterMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
