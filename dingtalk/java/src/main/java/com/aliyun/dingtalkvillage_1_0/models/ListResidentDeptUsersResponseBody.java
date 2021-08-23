// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentDeptUsersResponseBody extends TeaModel {
    // 下一个游标
    @NameInMap("nextCursor")
    public Long nextCursor;

    // 是否还有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 分页数据
    @NameInMap("list")
    public java.util.List<ListResidentDeptUsersResponseBodyList> list;

    public static ListResidentDeptUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListResidentDeptUsersResponseBody self = new ListResidentDeptUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListResidentDeptUsersResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListResidentDeptUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListResidentDeptUsersResponseBody setList(java.util.List<ListResidentDeptUsersResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListResidentDeptUsersResponseBodyList> getList() {
        return this.list;
    }

    public static class ListResidentDeptUsersResponseBodyListRoles extends TeaModel {
        // 标签id
        @NameInMap("id")
        public Long id;

        // 标签名称
        @NameInMap("name")
        public String name;

        // 标签名称 tagCode
        @NameInMap("tagCode")
        public String tagCode;

        public static ListResidentDeptUsersResponseBodyListRoles build(java.util.Map<String, ?> map) throws Exception {
            ListResidentDeptUsersResponseBodyListRoles self = new ListResidentDeptUsersResponseBodyListRoles();
            return TeaModel.build(map, self);
        }

        public ListResidentDeptUsersResponseBodyListRoles setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public ListResidentDeptUsersResponseBodyListRoles setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListResidentDeptUsersResponseBodyListRoles setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

    }

    public static class ListResidentDeptUsersResponseBodyList extends TeaModel {
        // 员工id
        @NameInMap("userId")
        public String userId;

        // 员工名字
        @NameInMap("name")
        public String name;

        // 标签列表
        @NameInMap("roles")
        public java.util.List<ListResidentDeptUsersResponseBodyListRoles> roles;

        // 员工特征
        @NameInMap("feature")
        public String feature;

        // 钉钉唯一标识
        @NameInMap("unionId")
        public String unionId;

        public static ListResidentDeptUsersResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListResidentDeptUsersResponseBodyList self = new ListResidentDeptUsersResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListResidentDeptUsersResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListResidentDeptUsersResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListResidentDeptUsersResponseBodyList setRoles(java.util.List<ListResidentDeptUsersResponseBodyListRoles> roles) {
            this.roles = roles;
            return this;
        }
        public java.util.List<ListResidentDeptUsersResponseBodyListRoles> getRoles() {
            return this.roles;
        }

        public ListResidentDeptUsersResponseBodyList setFeature(String feature) {
            this.feature = feature;
            return this;
        }
        public String getFeature() {
            return this.feature;
        }

        public ListResidentDeptUsersResponseBodyList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
