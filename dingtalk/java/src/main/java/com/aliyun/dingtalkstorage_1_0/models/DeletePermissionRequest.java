// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeletePermissionRequest extends TeaModel {
    // 权限成员列表
    @NameInMap("members")
    public java.util.List<DeletePermissionRequestMembers> members;

    // 权限角色id
    @NameInMap("roleId")
    public String roleId;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static DeletePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeletePermissionRequest self = new DeletePermissionRequest();
        return TeaModel.build(map, self);
    }

    public DeletePermissionRequest setMembers(java.util.List<DeletePermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<DeletePermissionRequestMembers> getMembers() {
        return this.members;
    }

    public DeletePermissionRequest setRoleId(String roleId) {
        this.roleId = roleId;
        return this;
    }
    public String getRoleId() {
        return this.roleId;
    }

    public DeletePermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class DeletePermissionRequestMembers extends TeaModel {
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

        public static DeletePermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            DeletePermissionRequestMembers self = new DeletePermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public DeletePermissionRequestMembers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public DeletePermissionRequestMembers setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DeletePermissionRequestMembers setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
