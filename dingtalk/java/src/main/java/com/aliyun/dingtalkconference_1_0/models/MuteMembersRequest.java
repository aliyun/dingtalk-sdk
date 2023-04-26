// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MuteMembersRequest extends TeaModel {
    @NameInMap("action")
    public String action;

    @NameInMap("userList")
    public java.util.List<MuteMembersRequestUserList> userList;

    public static MuteMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        MuteMembersRequest self = new MuteMembersRequest();
        return TeaModel.build(map, self);
    }

    public MuteMembersRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public MuteMembersRequest setUserList(java.util.List<MuteMembersRequestUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<MuteMembersRequestUserList> getUserList() {
        return this.userList;
    }

    public static class MuteMembersRequestUserList extends TeaModel {
        @NameInMap("participantId")
        public String participantId;

        @NameInMap("unionId")
        public String unionId;

        public static MuteMembersRequestUserList build(java.util.Map<String, ?> map) throws Exception {
            MuteMembersRequestUserList self = new MuteMembersRequestUserList();
            return TeaModel.build(map, self);
        }

        public MuteMembersRequestUserList setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public MuteMembersRequestUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
