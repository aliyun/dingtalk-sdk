// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentDeptUsersResponseBody extends TeaModel {
    // 是否还有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下一个游标
    @NameInMap("nextCursor")
    public Long nextCursor;

    // 用户列表
    @NameInMap("userList")
    public java.util.List<ListResidentDeptUsersResponseBodyUserList> userList;

    public static ListResidentDeptUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListResidentDeptUsersResponseBody self = new ListResidentDeptUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListResidentDeptUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListResidentDeptUsersResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListResidentDeptUsersResponseBody setUserList(java.util.List<ListResidentDeptUsersResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<ListResidentDeptUsersResponseBodyUserList> getUserList() {
        return this.userList;
    }

    public static class ListResidentDeptUsersResponseBodyUserListRoles extends TeaModel {
        // 标签名称 tagCode
        @NameInMap("tagCode")
        public String tagCode;

        // 标签id
        @NameInMap("tagId")
        public Long tagId;

        // 标签名称
        @NameInMap("tagName")
        public String tagName;

        public static ListResidentDeptUsersResponseBodyUserListRoles build(java.util.Map<String, ?> map) throws Exception {
            ListResidentDeptUsersResponseBodyUserListRoles self = new ListResidentDeptUsersResponseBodyUserListRoles();
            return TeaModel.build(map, self);
        }

        public ListResidentDeptUsersResponseBodyUserListRoles setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public ListResidentDeptUsersResponseBodyUserListRoles setTagId(Long tagId) {
            this.tagId = tagId;
            return this;
        }
        public Long getTagId() {
            return this.tagId;
        }

        public ListResidentDeptUsersResponseBodyUserListRoles setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class ListResidentDeptUsersResponseBodyUserList extends TeaModel {
        // 员工特征
        @NameInMap("feature")
        public String feature;

        // 员工名字
        @NameInMap("name")
        public String name;

        // 标签列表
        @NameInMap("roles")
        public java.util.List<ListResidentDeptUsersResponseBodyUserListRoles> roles;

        // 钉钉唯一标识
        @NameInMap("unionId")
        public String unionId;

        // 员工id
        @NameInMap("userId")
        public String userId;

        public static ListResidentDeptUsersResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListResidentDeptUsersResponseBodyUserList self = new ListResidentDeptUsersResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListResidentDeptUsersResponseBodyUserList setFeature(String feature) {
            this.feature = feature;
            return this;
        }
        public String getFeature() {
            return this.feature;
        }

        public ListResidentDeptUsersResponseBodyUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListResidentDeptUsersResponseBodyUserList setRoles(java.util.List<ListResidentDeptUsersResponseBodyUserListRoles> roles) {
            this.roles = roles;
            return this;
        }
        public java.util.List<ListResidentDeptUsersResponseBodyUserListRoles> getRoles() {
            return this.roles;
        }

        public ListResidentDeptUsersResponseBodyUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ListResidentDeptUsersResponseBodyUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
