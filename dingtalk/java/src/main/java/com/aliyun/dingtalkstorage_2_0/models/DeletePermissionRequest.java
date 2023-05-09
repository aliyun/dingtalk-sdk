// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class DeletePermissionRequest extends TeaModel {
    @NameInMap("members")
    public java.util.List<DeletePermissionRequestMembers> members;

    @NameInMap("roleId")
    public String roleId;

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
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("id")
        public String id;

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
