// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class AddGroupMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("members")
    public java.util.List<AddGroupMembersRequestMembers> members;

    @NameInMap("operatorUid")
    public String operatorUid;

    public static AddGroupMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        AddGroupMembersRequest self = new AddGroupMembersRequest();
        return TeaModel.build(map, self);
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

    public AddGroupMembersRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

    public static class AddGroupMembersRequestMembers extends TeaModel {
        @NameInMap("nick")
        public String nick;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uid")
        public String uid;

        public static AddGroupMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            AddGroupMembersRequestMembers self = new AddGroupMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public AddGroupMembersRequestMembers setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public AddGroupMembersRequestMembers setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

    }

}
