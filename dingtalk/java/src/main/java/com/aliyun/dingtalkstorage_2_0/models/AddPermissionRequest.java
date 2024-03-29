// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class AddPermissionRequest extends TeaModel {
    @NameInMap("members")
    public java.util.List<AddPermissionRequestMembers> members;

    @NameInMap("option")
    public AddPermissionRequestOption option;

    @NameInMap("roleId")
    public String roleId;

    @NameInMap("unionId")
    public String unionId;

    public static AddPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        AddPermissionRequest self = new AddPermissionRequest();
        return TeaModel.build(map, self);
    }

    public AddPermissionRequest setMembers(java.util.List<AddPermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<AddPermissionRequestMembers> getMembers() {
        return this.members;
    }

    public AddPermissionRequest setOption(AddPermissionRequestOption option) {
        this.option = option;
        return this;
    }
    public AddPermissionRequestOption getOption() {
        return this.option;
    }

    public AddPermissionRequest setRoleId(String roleId) {
        this.roleId = roleId;
        return this;
    }
    public String getRoleId() {
        return this.roleId;
    }

    public AddPermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class AddPermissionRequestMembers extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("id")
        public String id;

        @NameInMap("type")
        public String type;

        public static AddPermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            AddPermissionRequestMembers self = new AddPermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public AddPermissionRequestMembers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddPermissionRequestMembers setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AddPermissionRequestMembers setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class AddPermissionRequestOption extends TeaModel {
        @NameInMap("duration")
        public Long duration;

        public static AddPermissionRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddPermissionRequestOption self = new AddPermissionRequestOption();
            return TeaModel.build(map, self);
        }

        public AddPermissionRequestOption setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

    }

}
