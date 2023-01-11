// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryGroupMemberResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberResponseBody self = new QueryGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberResponseBody setResult(QueryGroupMemberResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryGroupMemberResponseBodyResult getResult() {
        return this.result;
    }

    public QueryGroupMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryGroupMemberResponseBodyResultGroupMemberList extends TeaModel {
        /**
         * <p>头像mediaId</p>
         */
        @NameInMap("avatarMediaId")
        public String avatarMediaId;

        /**
         * <p>是否企业员工</p>
         */
        @NameInMap("isUser")
        public Boolean isUser;

        /**
         * <p>昵称</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>是否群主</p>
         */
        @NameInMap("owner")
        public Boolean owner;

        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>企业员工id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryGroupMemberResponseBodyResultGroupMemberList build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupMemberResponseBodyResultGroupMemberList self = new QueryGroupMemberResponseBodyResultGroupMemberList();
            return TeaModel.build(map, self);
        }

        public QueryGroupMemberResponseBodyResultGroupMemberList setAvatarMediaId(String avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public String getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public QueryGroupMemberResponseBodyResultGroupMemberList setIsUser(Boolean isUser) {
            this.isUser = isUser;
            return this;
        }
        public Boolean getIsUser() {
            return this.isUser;
        }

        public QueryGroupMemberResponseBodyResultGroupMemberList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryGroupMemberResponseBodyResultGroupMemberList setOwner(Boolean owner) {
            this.owner = owner;
            return this;
        }
        public Boolean getOwner() {
            return this.owner;
        }

        public QueryGroupMemberResponseBodyResultGroupMemberList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryGroupMemberResponseBodyResultGroupMemberList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryGroupMemberResponseBodyResult extends TeaModel {
        /**
         * <p>群成员列表</p>
         */
        @NameInMap("groupMemberList")
        public java.util.List<QueryGroupMemberResponseBodyResultGroupMemberList> groupMemberList;

        /**
         * <p>群开放id</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        public static QueryGroupMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupMemberResponseBodyResult self = new QueryGroupMemberResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryGroupMemberResponseBodyResult setGroupMemberList(java.util.List<QueryGroupMemberResponseBodyResultGroupMemberList> groupMemberList) {
            this.groupMemberList = groupMemberList;
            return this;
        }
        public java.util.List<QueryGroupMemberResponseBodyResultGroupMemberList> getGroupMemberList() {
            return this.groupMemberList;
        }

        public QueryGroupMemberResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
