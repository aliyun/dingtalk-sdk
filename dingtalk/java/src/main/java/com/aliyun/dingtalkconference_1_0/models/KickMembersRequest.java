// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class KickMembersRequest extends TeaModel {
    @NameInMap("forbiddenRejoin")
    public Boolean forbiddenRejoin;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userList")
    public java.util.List<KickMembersRequestUserList> userList;

    public static KickMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        KickMembersRequest self = new KickMembersRequest();
        return TeaModel.build(map, self);
    }

    public KickMembersRequest setForbiddenRejoin(Boolean forbiddenRejoin) {
        this.forbiddenRejoin = forbiddenRejoin;
        return this;
    }
    public Boolean getForbiddenRejoin() {
        return this.forbiddenRejoin;
    }

    public KickMembersRequest setUserList(java.util.List<KickMembersRequestUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<KickMembersRequestUserList> getUserList() {
        return this.userList;
    }

    public static class KickMembersRequestUserList extends TeaModel {
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

        public static KickMembersRequestUserList build(java.util.Map<String, ?> map) throws Exception {
            KickMembersRequestUserList self = new KickMembersRequestUserList();
            return TeaModel.build(map, self);
        }

        public KickMembersRequestUserList setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public KickMembersRequestUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
