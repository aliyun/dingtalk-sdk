// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeptGroupSettingUpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("groupContainHiddenDept")
    public Boolean groupContainHiddenDept;

    @NameInMap("groupContainHrmEmployeeTypeLabels")
    public java.util.List<String> groupContainHrmEmployeeTypeLabels;

    @NameInMap("groupContainOuterDept")
    public Boolean groupContainOuterDept;

    @NameInMap("groupContainSubDept")
    public Boolean groupContainSubDept;

    @NameInMap("permissionCode")
    public String permissionCode;

    @NameInMap("syncMembers")
    public Boolean syncMembers;

    public static DeptGroupSettingUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        DeptGroupSettingUpdateRequest self = new DeptGroupSettingUpdateRequest();
        return TeaModel.build(map, self);
    }

    public DeptGroupSettingUpdateRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public DeptGroupSettingUpdateRequest setGroupContainHiddenDept(Boolean groupContainHiddenDept) {
        this.groupContainHiddenDept = groupContainHiddenDept;
        return this;
    }
    public Boolean getGroupContainHiddenDept() {
        return this.groupContainHiddenDept;
    }

    public DeptGroupSettingUpdateRequest setGroupContainHrmEmployeeTypeLabels(java.util.List<String> groupContainHrmEmployeeTypeLabels) {
        this.groupContainHrmEmployeeTypeLabels = groupContainHrmEmployeeTypeLabels;
        return this;
    }
    public java.util.List<String> getGroupContainHrmEmployeeTypeLabels() {
        return this.groupContainHrmEmployeeTypeLabels;
    }

    public DeptGroupSettingUpdateRequest setGroupContainOuterDept(Boolean groupContainOuterDept) {
        this.groupContainOuterDept = groupContainOuterDept;
        return this;
    }
    public Boolean getGroupContainOuterDept() {
        return this.groupContainOuterDept;
    }

    public DeptGroupSettingUpdateRequest setGroupContainSubDept(Boolean groupContainSubDept) {
        this.groupContainSubDept = groupContainSubDept;
        return this;
    }
    public Boolean getGroupContainSubDept() {
        return this.groupContainSubDept;
    }

    public DeptGroupSettingUpdateRequest setPermissionCode(String permissionCode) {
        this.permissionCode = permissionCode;
        return this;
    }
    public String getPermissionCode() {
        return this.permissionCode;
    }

    public DeptGroupSettingUpdateRequest setSyncMembers(Boolean syncMembers) {
        this.syncMembers = syncMembers;
        return this;
    }
    public Boolean getSyncMembers() {
        return this.syncMembers;
    }

}
