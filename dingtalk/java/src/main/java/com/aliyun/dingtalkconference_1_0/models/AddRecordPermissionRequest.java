// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class AddRecordPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cloud_record</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFFXXXXXXX</p>
     */
    @NameInMap("ownerUnionId")
    public String ownerUnionId;

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

    public static AddRecordPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRecordPermissionRequest self = new AddRecordPermissionRequest();
        return TeaModel.build(map, self);
    }

    public AddRecordPermissionRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public AddRecordPermissionRequest setOwnerUnionId(String ownerUnionId) {
        this.ownerUnionId = ownerUnionId;
        return this;
    }
    public String getOwnerUnionId() {
        return this.ownerUnionId;
    }

    public AddRecordPermissionRequest setRoleSubResourceIds(java.util.List<String> roleSubResourceIds) {
        this.roleSubResourceIds = roleSubResourceIds;
        return this;
    }
    public java.util.List<String> getRoleSubResourceIds() {
        return this.roleSubResourceIds;
    }

    public AddRecordPermissionRequest setShareScope(Integer shareScope) {
        this.shareScope = shareScope;
        return this;
    }
    public Integer getShareScope() {
        return this.shareScope;
    }

    public AddRecordPermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
