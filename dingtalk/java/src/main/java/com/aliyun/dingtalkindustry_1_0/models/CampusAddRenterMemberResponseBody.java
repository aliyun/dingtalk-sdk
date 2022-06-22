// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusAddRenterMemberResponseBody extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userState")
    public String userState;

    public static CampusAddRenterMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusAddRenterMemberResponseBody self = new CampusAddRenterMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusAddRenterMemberResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public CampusAddRenterMemberResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CampusAddRenterMemberResponseBody setUserState(String userState) {
        this.userState = userState;
        return this;
    }
    public String getUserState() {
        return this.userState;
    }

}
