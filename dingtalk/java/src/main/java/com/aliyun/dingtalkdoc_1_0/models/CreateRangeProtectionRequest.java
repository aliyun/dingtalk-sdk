// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateRangeProtectionRequest extends TeaModel {
    @NameInMap("editableSetting")
    public CreateRangeProtectionRequestEditableSetting editableSetting;

    @NameInMap("members")
    public java.util.List<CreateRangeProtectionRequestMembers> members;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("otherUserPermission")
    public String otherUserPermission;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateRangeProtectionRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRangeProtectionRequest self = new CreateRangeProtectionRequest();
        return TeaModel.build(map, self);
    }

    public CreateRangeProtectionRequest setEditableSetting(CreateRangeProtectionRequestEditableSetting editableSetting) {
        this.editableSetting = editableSetting;
        return this;
    }
    public CreateRangeProtectionRequestEditableSetting getEditableSetting() {
        return this.editableSetting;
    }

    public CreateRangeProtectionRequest setMembers(java.util.List<CreateRangeProtectionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<CreateRangeProtectionRequestMembers> getMembers() {
        return this.members;
    }

    public CreateRangeProtectionRequest setOtherUserPermission(String otherUserPermission) {
        this.otherUserPermission = otherUserPermission;
        return this;
    }
    public String getOtherUserPermission() {
        return this.otherUserPermission;
    }

    public CreateRangeProtectionRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateRangeProtectionRequestEditableSetting extends TeaModel {
        @NameInMap("deleteColumns")
        public Boolean deleteColumns;

        @NameInMap("deleteRows")
        public Boolean deleteRows;

        @NameInMap("editCells")
        public Boolean editCells;

        @NameInMap("formatCells")
        public Boolean formatCells;

        @NameInMap("insertColumns")
        public Boolean insertColumns;

        @NameInMap("insertRows")
        public Boolean insertRows;

        @NameInMap("toggleColumnsVisibility")
        public Boolean toggleColumnsVisibility;

        @NameInMap("toggleRowsVisibility")
        public Boolean toggleRowsVisibility;

        public static CreateRangeProtectionRequestEditableSetting build(java.util.Map<String, ?> map) throws Exception {
            CreateRangeProtectionRequestEditableSetting self = new CreateRangeProtectionRequestEditableSetting();
            return TeaModel.build(map, self);
        }

        public CreateRangeProtectionRequestEditableSetting setDeleteColumns(Boolean deleteColumns) {
            this.deleteColumns = deleteColumns;
            return this;
        }
        public Boolean getDeleteColumns() {
            return this.deleteColumns;
        }

        public CreateRangeProtectionRequestEditableSetting setDeleteRows(Boolean deleteRows) {
            this.deleteRows = deleteRows;
            return this;
        }
        public Boolean getDeleteRows() {
            return this.deleteRows;
        }

        public CreateRangeProtectionRequestEditableSetting setEditCells(Boolean editCells) {
            this.editCells = editCells;
            return this;
        }
        public Boolean getEditCells() {
            return this.editCells;
        }

        public CreateRangeProtectionRequestEditableSetting setFormatCells(Boolean formatCells) {
            this.formatCells = formatCells;
            return this;
        }
        public Boolean getFormatCells() {
            return this.formatCells;
        }

        public CreateRangeProtectionRequestEditableSetting setInsertColumns(Boolean insertColumns) {
            this.insertColumns = insertColumns;
            return this;
        }
        public Boolean getInsertColumns() {
            return this.insertColumns;
        }

        public CreateRangeProtectionRequestEditableSetting setInsertRows(Boolean insertRows) {
            this.insertRows = insertRows;
            return this;
        }
        public Boolean getInsertRows() {
            return this.insertRows;
        }

        public CreateRangeProtectionRequestEditableSetting setToggleColumnsVisibility(Boolean toggleColumnsVisibility) {
            this.toggleColumnsVisibility = toggleColumnsVisibility;
            return this;
        }
        public Boolean getToggleColumnsVisibility() {
            return this.toggleColumnsVisibility;
        }

        public CreateRangeProtectionRequestEditableSetting setToggleRowsVisibility(Boolean toggleRowsVisibility) {
            this.toggleRowsVisibility = toggleRowsVisibility;
            return this;
        }
        public Boolean getToggleRowsVisibility() {
            return this.toggleRowsVisibility;
        }

    }

    public static class CreateRangeProtectionRequestMembers extends TeaModel {
        @NameInMap("deptId")
        public String deptId;

        @NameInMap("memberType")
        public String memberType;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("permission")
        public String permission;

        @NameInMap("unionId")
        public String unionId;

        public static CreateRangeProtectionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            CreateRangeProtectionRequestMembers self = new CreateRangeProtectionRequestMembers();
            return TeaModel.build(map, self);
        }

        public CreateRangeProtectionRequestMembers setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public CreateRangeProtectionRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public CreateRangeProtectionRequestMembers setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public CreateRangeProtectionRequestMembers setPermission(String permission) {
            this.permission = permission;
            return this;
        }
        public String getPermission() {
            return this.permission;
        }

        public CreateRangeProtectionRequestMembers setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
