// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionRequest extends TeaModel {
    @NameInMap("memberInfoList")
    public java.util.List<UpdatePermissionRequestMemberInfoList> memberInfoList;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("opType")
    public Integer opType;

    /**
     * <strong>example:</strong>
     * <p>1000</p>
     */
    @NameInMap("roleCode")
    public String roleCode;

    @NameInMap("roleSubResourceIds")
    public java.util.List<String> roleSubResourceIds;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("shareScope")
    public Integer shareScope;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdatePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionRequest self = new UpdatePermissionRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionRequest setMemberInfoList(java.util.List<UpdatePermissionRequestMemberInfoList> memberInfoList) {
        this.memberInfoList = memberInfoList;
        return this;
    }
    public java.util.List<UpdatePermissionRequestMemberInfoList> getMemberInfoList() {
        return this.memberInfoList;
    }

    public UpdatePermissionRequest setOpType(Integer opType) {
        this.opType = opType;
        return this;
    }
    public Integer getOpType() {
        return this.opType;
    }

    public UpdatePermissionRequest setRoleCode(String roleCode) {
        this.roleCode = roleCode;
        return this;
    }
    public String getRoleCode() {
        return this.roleCode;
    }

    public UpdatePermissionRequest setRoleSubResourceIds(java.util.List<String> roleSubResourceIds) {
        this.roleSubResourceIds = roleSubResourceIds;
        return this;
    }
    public java.util.List<String> getRoleSubResourceIds() {
        return this.roleSubResourceIds;
    }

    public UpdatePermissionRequest setShareScope(Integer shareScope) {
        this.shareScope = shareScope;
        return this;
    }
    public Integer getShareScope() {
        return this.shareScope;
    }

    public UpdatePermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class UpdatePermissionRequestMemberInfoList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

        /**
         * <strong>example:</strong>
         * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
         */
        @NameInMap("memberUnionId")
        public String memberUnionId;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("policyId")
        public Long policyId;

        public static UpdatePermissionRequestMemberInfoList build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionRequestMemberInfoList self = new UpdatePermissionRequestMemberInfoList();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionRequestMemberInfoList setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public UpdatePermissionRequestMemberInfoList setMemberUnionId(String memberUnionId) {
            this.memberUnionId = memberUnionId;
            return this;
        }
        public String getMemberUnionId() {
            return this.memberUnionId;
        }

        public UpdatePermissionRequestMemberInfoList setPolicyId(Long policyId) {
            this.policyId = policyId;
            return this;
        }
        public Long getPolicyId() {
            return this.policyId;
        }

    }

}
