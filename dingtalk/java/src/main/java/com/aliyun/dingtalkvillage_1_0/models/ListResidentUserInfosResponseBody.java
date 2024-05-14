// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentUserInfosResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("tagCode")
        public String tagCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("tagId")
        public Long tagId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("tagName")
        public String tagName;

        public static ListResidentUserInfosResponseBodyUserListRoles build(java.util.Map<String, ?> map) throws Exception {
            ListResidentUserInfosResponseBodyUserListRoles self = new ListResidentUserInfosResponseBodyUserListRoles();
            return TeaModel.build(map, self);
        }

        public ListResidentUserInfosResponseBodyUserListRoles setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
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

    }

    public static class ListResidentUserInfosResponseBodyUserList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("feature")
        public String feature;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("roles")
        public java.util.List<ListResidentUserInfosResponseBodyUserListRoles> roles;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userName")
        public String userName;

        public static ListResidentUserInfosResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListResidentUserInfosResponseBodyUserList self = new ListResidentUserInfosResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListResidentUserInfosResponseBodyUserList setFeature(String feature) {
            this.feature = feature;
            return this;
        }
        public String getFeature() {
            return this.feature;
        }

        public ListResidentUserInfosResponseBodyUserList setRoles(java.util.List<ListResidentUserInfosResponseBodyUserListRoles> roles) {
            this.roles = roles;
            return this;
        }
        public java.util.List<ListResidentUserInfosResponseBodyUserListRoles> getRoles() {
            return this.roles;
        }

        public ListResidentUserInfosResponseBodyUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
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

    }

}
