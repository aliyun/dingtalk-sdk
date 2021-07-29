// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class AddGroupMembersRequest extends TeaModel {
    @NameInMap("operatorUid")
    public String operatorUid;

    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("members")
    public java.util.List<AddGroupMembersRequestMembers> members;

    public static AddGroupMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        AddGroupMembersRequest self = new AddGroupMembersRequest();
        return TeaModel.build(map, self);
    }

    public AddGroupMembersRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

    public AddGroupMembersRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public AddGroupMembersRequest setMembers(java.util.List<AddGroupMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<AddGroupMembersRequestMembers> getMembers() {
        return this.members;
    }

    public static class AddGroupMembersRequestMembers extends TeaModel {
        @NameInMap("uid")
        public String uid;

        @NameInMap("nick")
        public String nick;

        public static AddGroupMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            AddGroupMembersRequestMembers self = new AddGroupMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public AddGroupMembersRequestMembers setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public AddGroupMembersRequestMembers setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

    }

}
