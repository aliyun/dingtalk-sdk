// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusAddRenterMemberRequest extends TeaModel {
    @NameInMap("extend")
    public String extend;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    @NameInMap("type")
    public String type;

    public static CampusAddRenterMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusAddRenterMemberRequest self = new CampusAddRenterMemberRequest();
        return TeaModel.build(map, self);
    }

    public CampusAddRenterMemberRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusAddRenterMemberRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public CampusAddRenterMemberRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CampusAddRenterMemberRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

    public CampusAddRenterMemberRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
