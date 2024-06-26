// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupMembers")
    public java.util.List<QueryGroupMemberResponseBodyGroupMembers> groupMembers;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>14da****2760</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberResponseBody self = new QueryGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberResponseBody setGroupMembers(java.util.List<QueryGroupMemberResponseBodyGroupMembers> groupMembers) {
        this.groupMembers = groupMembers;
        return this;
    }
    public java.util.List<QueryGroupMemberResponseBodyGroupMembers> getGroupMembers() {
        return this.groupMembers;
    }

    public QueryGroupMemberResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public static class QueryGroupMemberResponseBodyGroupMembers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>http://****.png</p>
         */
        @NameInMap("groupMemberAvatar")
        public String groupMemberAvatar;

        /**
         * <strong>example:</strong>
         * <p>认真工作,快乐生活</p>
         */
        @NameInMap("groupMemberDynamics")
        public String groupMemberDynamics;

        /**
         * <strong>example:</strong>
         * <p>1107****2120</p>
         */
        @NameInMap("groupMemberId")
        public String groupMemberId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>Foo</p>
         */
        @NameInMap("groupMemberName")
        public String groupMemberName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("groupMemberType")
        public Integer groupMemberType;

        public static QueryGroupMemberResponseBodyGroupMembers build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupMemberResponseBodyGroupMembers self = new QueryGroupMemberResponseBodyGroupMembers();
            return TeaModel.build(map, self);
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberAvatar(String groupMemberAvatar) {
            this.groupMemberAvatar = groupMemberAvatar;
            return this;
        }
        public String getGroupMemberAvatar() {
            return this.groupMemberAvatar;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberDynamics(String groupMemberDynamics) {
            this.groupMemberDynamics = groupMemberDynamics;
            return this;
        }
        public String getGroupMemberDynamics() {
            return this.groupMemberDynamics;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberId(String groupMemberId) {
            this.groupMemberId = groupMemberId;
            return this;
        }
        public String getGroupMemberId() {
            return this.groupMemberId;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberName(String groupMemberName) {
            this.groupMemberName = groupMemberName;
            return this;
        }
        public String getGroupMemberName() {
            return this.groupMemberName;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberType(Integer groupMemberType) {
            this.groupMemberType = groupMemberType;
            return this;
        }
        public Integer getGroupMemberType() {
            return this.groupMemberType;
        }

    }

}
