// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MuteMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>mute</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>644272f14ba3311xxxxxxxxx</p>
         */
        @NameInMap("participantId")
        public String participantId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx</p>
         */
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
