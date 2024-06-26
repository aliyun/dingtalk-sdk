// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<UpdatePermissionRequestMembers> members;

    @NameInMap("option")
    public UpdatePermissionRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>MANAGER</p>
     */
    @NameInMap("roleId")
    public String roleId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdatePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionRequest self = new UpdatePermissionRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionRequest setMembers(java.util.List<UpdatePermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<UpdatePermissionRequestMembers> getMembers() {
        return this.members;
    }

    public UpdatePermissionRequest setOption(UpdatePermissionRequestOption option) {
        this.option = option;
        return this;
    }
    public UpdatePermissionRequestOption getOption() {
        return this.option;
    }

    public UpdatePermissionRequest setRoleId(String roleId) {
        this.roleId = roleId;
        return this;
    }
    public String getRoleId() {
        return this.roleId;
    }

    public UpdatePermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class UpdatePermissionRequestMembers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>corp_id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>member_id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>USER</p>
         */
        @NameInMap("type")
        public String type;

        public static UpdatePermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionRequestMembers self = new UpdatePermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionRequestMembers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public UpdatePermissionRequestMembers setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdatePermissionRequestMembers setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class UpdatePermissionRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3600</p>
         */
        @NameInMap("duration")
        public Long duration;

        public static UpdatePermissionRequestOption build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionRequestOption self = new UpdatePermissionRequestOption();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionRequestOption setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

    }

}
