// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterMemberResponseBody extends TeaModel {
    @NameInMap("extend")
    public String extend;

    @NameInMap("inviteState")
    public Integer inviteState;

    @NameInMap("name")
    public String name;

    @NameInMap("state")
    public String state;

    @NameInMap("type")
    public String type;

    @NameInMap("userId")
    public String userId;

    public static CampusGetRenterMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusGetRenterMemberResponseBody self = new CampusGetRenterMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusGetRenterMemberResponseBody setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusGetRenterMemberResponseBody setInviteState(Integer inviteState) {
        this.inviteState = inviteState;
        return this;
    }
    public Integer getInviteState() {
        return this.inviteState;
    }

    public CampusGetRenterMemberResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CampusGetRenterMemberResponseBody setState(String state) {
        this.state = state;
        return this;
    }
    public String getState() {
        return this.state;
    }

    public CampusGetRenterMemberResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public CampusGetRenterMemberResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
