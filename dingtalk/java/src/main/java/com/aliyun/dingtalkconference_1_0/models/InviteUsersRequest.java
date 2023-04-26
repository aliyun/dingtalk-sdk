// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class InviteUsersRequest extends TeaModel {
    @NameInMap("inviteeList")
    public java.util.List<InviteUsersRequestInviteeList> inviteeList;

    @NameInMap("unionId")
    public String unionId;

    public static InviteUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        InviteUsersRequest self = new InviteUsersRequest();
        return TeaModel.build(map, self);
    }

    public InviteUsersRequest setInviteeList(java.util.List<InviteUsersRequestInviteeList> inviteeList) {
        this.inviteeList = inviteeList;
        return this;
    }
    public java.util.List<InviteUsersRequestInviteeList> getInviteeList() {
        return this.inviteeList;
    }

    public InviteUsersRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class InviteUsersRequestInviteeList extends TeaModel {
        @NameInMap("nick")
        public String nick;

        @NameInMap("unionId")
        public String unionId;

        public static InviteUsersRequestInviteeList build(java.util.Map<String, ?> map) throws Exception {
            InviteUsersRequestInviteeList self = new InviteUsersRequestInviteeList();
            return TeaModel.build(map, self);
        }

        public InviteUsersRequestInviteeList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public InviteUsersRequestInviteeList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
