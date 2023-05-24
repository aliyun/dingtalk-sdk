// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyGetMemberRequest extends TeaModel {
    @NameInMap("mobile")
    public String mobile;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userId")
    public String userId;

    public static SupplyGetMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyGetMemberRequest self = new SupplyGetMemberRequest();
        return TeaModel.build(map, self);
    }

    public SupplyGetMemberRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public SupplyGetMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public SupplyGetMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
