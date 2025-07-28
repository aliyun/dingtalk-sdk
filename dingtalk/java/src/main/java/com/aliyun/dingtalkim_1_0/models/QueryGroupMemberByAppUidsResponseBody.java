// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByAppUidsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupMembers")
    public java.util.List<QueryGroupMemberByAppUidsResponseBodyGroupMembers> groupMembers;

    public static QueryGroupMemberByAppUidsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberByAppUidsResponseBody self = new QueryGroupMemberByAppUidsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberByAppUidsResponseBody setGroupMembers(java.util.List<QueryGroupMemberByAppUidsResponseBodyGroupMembers> groupMembers) {
        this.groupMembers = groupMembers;
        return this;
    }
    public java.util.List<QueryGroupMemberByAppUidsResponseBodyGroupMembers> getGroupMembers() {
        return this.groupMembers;
    }

    public static class QueryGroupMemberByAppUidsResponseBodyGroupMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1000000</p>
         */
        @NameInMap("appUid")
        public Long appUid;

        /**
         * <strong>example:</strong>
         * <p>http://****.png</p>
         */
        @NameInMap("groupMemberAvatar")
        public String groupMemberAvatar;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("groupMemberAvatarMediaId")
        public String groupMemberAvatarMediaId;

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

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("groupMemberTypeV2")
        public Integer groupMemberTypeV2;

        public static QueryGroupMemberByAppUidsResponseBodyGroupMembers build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupMemberByAppUidsResponseBodyGroupMembers self = new QueryGroupMemberByAppUidsResponseBodyGroupMembers();
            return TeaModel.build(map, self);
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setAppUid(Long appUid) {
            this.appUid = appUid;
            return this;
        }
        public Long getAppUid() {
            return this.appUid;
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setGroupMemberAvatar(String groupMemberAvatar) {
            this.groupMemberAvatar = groupMemberAvatar;
            return this;
        }
        public String getGroupMemberAvatar() {
            return this.groupMemberAvatar;
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setGroupMemberAvatarMediaId(String groupMemberAvatarMediaId) {
            this.groupMemberAvatarMediaId = groupMemberAvatarMediaId;
            return this;
        }
        public String getGroupMemberAvatarMediaId() {
            return this.groupMemberAvatarMediaId;
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setGroupMemberDynamics(String groupMemberDynamics) {
            this.groupMemberDynamics = groupMemberDynamics;
            return this;
        }
        public String getGroupMemberDynamics() {
            return this.groupMemberDynamics;
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setGroupMemberId(String groupMemberId) {
            this.groupMemberId = groupMemberId;
            return this;
        }
        public String getGroupMemberId() {
            return this.groupMemberId;
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setGroupMemberName(String groupMemberName) {
            this.groupMemberName = groupMemberName;
            return this;
        }
        public String getGroupMemberName() {
            return this.groupMemberName;
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setGroupMemberType(Integer groupMemberType) {
            this.groupMemberType = groupMemberType;
            return this;
        }
        public Integer getGroupMemberType() {
            return this.groupMemberType;
        }

        public QueryGroupMemberByAppUidsResponseBodyGroupMembers setGroupMemberTypeV2(Integer groupMemberTypeV2) {
            this.groupMemberTypeV2 = groupMemberTypeV2;
            return this;
        }
        public Integer getGroupMemberTypeV2() {
            return this.groupMemberTypeV2;
        }

    }

}
