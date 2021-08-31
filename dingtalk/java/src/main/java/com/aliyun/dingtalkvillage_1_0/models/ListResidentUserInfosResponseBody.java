// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentUserInfosResponseBody extends TeaModel {
    // 员工信息列表
    @NameInMap("userList")
    public java.util.List<ListResidentUserInfosResponseBodyUserList> userList;

    public static ListResidentUserInfosResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListResidentUserInfosResponseBody self = new ListResidentUserInfosResponseBody();
        return TeaModel.build(map, self);
    }

    public ListResidentUserInfosResponseBody setUserList(java.util.List<ListResidentUserInfosResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<ListResidentUserInfosResponseBodyUserList> getUserList() {
        return this.userList;
    }

    public static class ListResidentUserInfosResponseBodyUserListRoles extends TeaModel {
        // 标签id
        @NameInMap("tagId")
        public Long tagId;

        // 标签名称
        @NameInMap("tagName")
        public String tagName;

        // 标签名称 tagCode
        @NameInMap("tagCode")
        public String tagCode;

        public static ListResidentUserInfosResponseBodyUserListRoles build(java.util.Map<String, ?> map) throws Exception {
            ListResidentUserInfosResponseBodyUserListRoles self = new ListResidentUserInfosResponseBodyUserListRoles();
            return TeaModel.build(map, self);
        }

        public ListResidentUserInfosResponseBodyUserListRoles setTagId(Long tagId) {
            this.tagId = tagId;
            return this;
        }
        public Long getTagId() {
            return this.tagId;
        }

        public ListResidentUserInfosResponseBodyUserListRoles setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

        public ListResidentUserInfosResponseBodyUserListRoles setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

    }

    public static class ListResidentUserInfosResponseBodyUserList extends TeaModel {
        // 员工 ID
        @NameInMap("userId")
        public String userId;

        // 员工名字
        @NameInMap("userName")
        public String userName;

        // 标签列表
        @NameInMap("roles")
        public java.util.List<ListResidentUserInfosResponseBodyUserListRoles> roles;

        // 员工特征
        @NameInMap("feature")
        public String feature;

        // 钉钉唯一标识
        @NameInMap("unionId")
        public String unionId;

        public static ListResidentUserInfosResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListResidentUserInfosResponseBodyUserList self = new ListResidentUserInfosResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListResidentUserInfosResponseBodyUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListResidentUserInfosResponseBodyUserList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public ListResidentUserInfosResponseBodyUserList setRoles(java.util.List<ListResidentUserInfosResponseBodyUserListRoles> roles) {
            this.roles = roles;
            return this;
        }
        public java.util.List<ListResidentUserInfosResponseBodyUserListRoles> getRoles() {
            return this.roles;
        }

        public ListResidentUserInfosResponseBodyUserList setFeature(String feature) {
            this.feature = feature;
            return this;
        }
        public String getFeature() {
            return this.feature;
        }

        public ListResidentUserInfosResponseBodyUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
