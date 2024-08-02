// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class InviteUsersRequest extends TeaModel {
    @NameInMap("inviteeList")
    public java.util.List<InviteUsersRequestInviteeList> inviteeList;

    @NameInMap("phoneInviteeList")
    public java.util.List<InviteUsersRequestPhoneInviteeList> phoneInviteeList;

    /**
     * <strong>example:</strong>
     * <p>qzR1iSMDvzR9iPXXXXXXXXXXXXXX</p>
     */
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

    public InviteUsersRequest setPhoneInviteeList(java.util.List<InviteUsersRequestPhoneInviteeList> phoneInviteeList) {
        this.phoneInviteeList = phoneInviteeList;
        return this;
    }
    public java.util.List<InviteUsersRequestPhoneInviteeList> getPhoneInviteeList() {
        return this.phoneInviteeList;
    }

    public InviteUsersRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class InviteUsersRequestInviteeList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>测试用户</p>
         */
        @NameInMap("nick")
        public String nick;

        /**
         * <strong>example:</strong>
         * <p>qzR1iSMDvzR9kXXXXXXXx</p>
         */
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

    public static class InviteUsersRequestPhoneInviteeList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("inviteClient")
        public Boolean inviteClient;

        /**
         * <strong>example:</strong>
         * <p>测试电话用户</p>
         */
        @NameInMap("nick")
        public String nick;

        /**
         * <strong>example:</strong>
         * <p>1xxxxxxxxxx9</p>
         */
        @NameInMap("phoneNumber")
        public String phoneNumber;

        /**
         * <strong>example:</strong>
         * <p>86</p>
         */
        @NameInMap("statusCode")
        public String statusCode;

        public static InviteUsersRequestPhoneInviteeList build(java.util.Map<String, ?> map) throws Exception {
            InviteUsersRequestPhoneInviteeList self = new InviteUsersRequestPhoneInviteeList();
            return TeaModel.build(map, self);
        }

        public InviteUsersRequestPhoneInviteeList setInviteClient(Boolean inviteClient) {
            this.inviteClient = inviteClient;
            return this;
        }
        public Boolean getInviteClient() {
            return this.inviteClient;
        }

        public InviteUsersRequestPhoneInviteeList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public InviteUsersRequestPhoneInviteeList setPhoneNumber(String phoneNumber) {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public String getPhoneNumber() {
            return this.phoneNumber;
        }

        public InviteUsersRequestPhoneInviteeList setStatusCode(String statusCode) {
            this.statusCode = statusCode;
            return this;
        }
        public String getStatusCode() {
            return this.statusCode;
        }

    }

}
