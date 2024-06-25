// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByMemberAuthResponseBody extends TeaModel {
    @NameInMap("groupMemberList")
    public java.util.List<QueryGroupMemberByMemberAuthResponseBodyGroupMemberList> groupMemberList;

    public static QueryGroupMemberByMemberAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberByMemberAuthResponseBody self = new QueryGroupMemberByMemberAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberByMemberAuthResponseBody setGroupMemberList(java.util.List<QueryGroupMemberByMemberAuthResponseBodyGroupMemberList> groupMemberList) {
        this.groupMemberList = groupMemberList;
        return this;
    }
    public java.util.List<QueryGroupMemberByMemberAuthResponseBodyGroupMemberList> getGroupMemberList() {
        return this.groupMemberList;
    }

    public static class QueryGroupMemberByMemberAuthResponseBodyGroupMemberList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("groupNickName")
        public String groupNickName;

        /**
         * <strong>example:</strong>
         * <p>张某某</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://xxx">https://xxx</a></p>
         */
        @NameInMap("profilePhotoUrl")
        public String profilePhotoUrl;

        /**
         * <strong>example:</strong>
         * <p>xxx</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryGroupMemberByMemberAuthResponseBodyGroupMemberList build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupMemberByMemberAuthResponseBodyGroupMemberList self = new QueryGroupMemberByMemberAuthResponseBodyGroupMemberList();
            return TeaModel.build(map, self);
        }

        public QueryGroupMemberByMemberAuthResponseBodyGroupMemberList setGroupNickName(String groupNickName) {
            this.groupNickName = groupNickName;
            return this;
        }
        public String getGroupNickName() {
            return this.groupNickName;
        }

        public QueryGroupMemberByMemberAuthResponseBodyGroupMemberList setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public QueryGroupMemberByMemberAuthResponseBodyGroupMemberList setProfilePhotoUrl(String profilePhotoUrl) {
            this.profilePhotoUrl = profilePhotoUrl;
            return this;
        }
        public String getProfilePhotoUrl() {
            return this.profilePhotoUrl;
        }

        public QueryGroupMemberByMemberAuthResponseBodyGroupMemberList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
