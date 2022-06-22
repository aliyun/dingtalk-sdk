// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListRenterMembersResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<CampusListRenterMembersResponseBodyResult> result;

    public static CampusListRenterMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusListRenterMembersResponseBody self = new CampusListRenterMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusListRenterMembersResponseBody setResult(java.util.List<CampusListRenterMembersResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CampusListRenterMembersResponseBodyResult> getResult() {
        return this.result;
    }

    public static class CampusListRenterMembersResponseBodyResult extends TeaModel {
        @NameInMap("extend")
        public String extend;

        @NameInMap("inviteState")
        public String inviteState;

        @NameInMap("name")
        public String name;

        @NameInMap("state")
        public String state;

        @NameInMap("type")
        public String type;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static CampusListRenterMembersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CampusListRenterMembersResponseBodyResult self = new CampusListRenterMembersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CampusListRenterMembersResponseBodyResult setExtend(String extend) {
            this.extend = extend;
            return this;
        }
        public String getExtend() {
            return this.extend;
        }

        public CampusListRenterMembersResponseBodyResult setInviteState(String inviteState) {
            this.inviteState = inviteState;
            return this;
        }
        public String getInviteState() {
            return this.inviteState;
        }

        public CampusListRenterMembersResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CampusListRenterMembersResponseBodyResult setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public CampusListRenterMembersResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CampusListRenterMembersResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public CampusListRenterMembersResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
