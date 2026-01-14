// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class RebuildRoleMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("defaultRoleDTO")
    public RebuildRoleMembersRequestDefaultRoleDTO defaultRoleDTO;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("toRoleMemberDTOMap")
    public java.util.Map<String, java.util.List<ToRoleMemberDTOMapValue>> toRoleMemberDTOMap;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static RebuildRoleMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        RebuildRoleMembersRequest self = new RebuildRoleMembersRequest();
        return TeaModel.build(map, self);
    }

    public RebuildRoleMembersRequest setDefaultRoleDTO(RebuildRoleMembersRequestDefaultRoleDTO defaultRoleDTO) {
        this.defaultRoleDTO = defaultRoleDTO;
        return this;
    }
    public RebuildRoleMembersRequestDefaultRoleDTO getDefaultRoleDTO() {
        return this.defaultRoleDTO;
    }

    public RebuildRoleMembersRequest setToRoleMemberDTOMap(java.util.Map<String, java.util.List<ToRoleMemberDTOMapValue>> toRoleMemberDTOMap) {
        this.toRoleMemberDTOMap = toRoleMemberDTOMap;
        return this;
    }
    public java.util.Map<String, java.util.List<ToRoleMemberDTOMapValue>> getToRoleMemberDTOMap() {
        return this.toRoleMemberDTOMap;
    }

    public RebuildRoleMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class RebuildRoleMembersRequestDefaultRoleDTO extends TeaModel {
        @NameInMap("mode")
        public Integer mode;

        @NameInMap("roleId")
        public Long roleId;

        public static RebuildRoleMembersRequestDefaultRoleDTO build(java.util.Map<String, ?> map) throws Exception {
            RebuildRoleMembersRequestDefaultRoleDTO self = new RebuildRoleMembersRequestDefaultRoleDTO();
            return TeaModel.build(map, self);
        }

        public RebuildRoleMembersRequestDefaultRoleDTO setMode(Integer mode) {
            this.mode = mode;
            return this;
        }
        public Integer getMode() {
            return this.mode;
        }

        public RebuildRoleMembersRequestDefaultRoleDTO setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

    }

}
