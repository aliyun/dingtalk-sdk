// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListPermissionsResponseBody extends TeaModel {
    // 分页游标, nextToken不为空表示有更多数据
    @NameInMap("nextToken")
    public String nextToken;

    // 权限列表分页数据
    @NameInMap("permissions")
    public java.util.List<ListPermissionsResponseBodyPermissions> permissions;

    public static ListPermissionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPermissionsResponseBody self = new ListPermissionsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPermissionsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListPermissionsResponseBody setPermissions(java.util.List<ListPermissionsResponseBodyPermissions> permissions) {
        this.permissions = permissions;
        return this;
    }
    public java.util.List<ListPermissionsResponseBodyPermissions> getPermissions() {
        return this.permissions;
    }

    public static class ListPermissionsResponseBodyPermissionsMember extends TeaModel {
        // 权限归属的企业
        // 如果存在企业id, 对应member离职的时候会自动清理权限
        // 如果memberType是dept类型，必须要有企业id
        @NameInMap("corpId")
        public String corpId;

        // 权限成员id
        @NameInMap("id")
        public String id;

        // 权限成员类型
        // 枚举值:
        // 	ORG: 企业
        // 	DEPT: 部门
        // 	TAG: 自定义tag
        // 	CONVERSATION: 会话
        // 	GG: 通用组
        // 	USER: 用户
        // 	ALL_USERS: 所有用户
        @NameInMap("type")
        public String type;

        public static ListPermissionsResponseBodyPermissionsMember build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyPermissionsMember self = new ListPermissionsResponseBodyPermissionsMember();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyPermissionsMember setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListPermissionsResponseBodyPermissionsMember setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListPermissionsResponseBodyPermissionsMember setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListPermissionsResponseBodyPermissionsRole extends TeaModel {
        // 角色id
        @NameInMap("id")
        public String id;

        // 角色名称
        @NameInMap("name")
        public String name;

        public static ListPermissionsResponseBodyPermissionsRole build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyPermissionsRole self = new ListPermissionsResponseBodyPermissionsRole();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyPermissionsRole setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListPermissionsResponseBodyPermissionsRole setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListPermissionsResponseBodyPermissions extends TeaModel {
        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 文件id
        @NameInMap("dentryId")
        public String dentryId;

        // 有效时间
        @NameInMap("duration")
        public Long duration;

        // 权限成员
        @NameInMap("member")
        public ListPermissionsResponseBodyPermissionsMember member;

        // 修改时间
        @NameInMap("modifiedTime")
        public String modifiedTime;

        // 操作人id
        @NameInMap("operatorId")
        public String operatorId;

        // 权限角色
        @NameInMap("role")
        public ListPermissionsResponseBodyPermissionsRole role;

        // 空间id
        @NameInMap("spaceId")
        public String spaceId;

        public static ListPermissionsResponseBodyPermissions build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyPermissions self = new ListPermissionsResponseBodyPermissions();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyPermissions setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListPermissionsResponseBodyPermissions setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public ListPermissionsResponseBodyPermissions setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public ListPermissionsResponseBodyPermissions setMember(ListPermissionsResponseBodyPermissionsMember member) {
            this.member = member;
            return this;
        }
        public ListPermissionsResponseBodyPermissionsMember getMember() {
            return this.member;
        }

        public ListPermissionsResponseBodyPermissions setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListPermissionsResponseBodyPermissions setOperatorId(String operatorId) {
            this.operatorId = operatorId;
            return this;
        }
        public String getOperatorId() {
            return this.operatorId;
        }

        public ListPermissionsResponseBodyPermissions setRole(ListPermissionsResponseBodyPermissionsRole role) {
            this.role = role;
            return this;
        }
        public ListPermissionsResponseBodyPermissionsRole getRole() {
            return this.role;
        }

        public ListPermissionsResponseBodyPermissions setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
