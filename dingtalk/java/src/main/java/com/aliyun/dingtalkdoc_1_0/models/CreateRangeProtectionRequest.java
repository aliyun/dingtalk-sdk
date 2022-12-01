// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateRangeProtectionRequest extends TeaModel {
    // 对于拥有「可编辑」权限的用户的细化权限配置。
    @NameInMap("editableSetting")
    public CreateRangeProtectionRequestEditableSetting editableSetting;

    // 其它用户的权限
    @NameInMap("otherUserPermission")
    public String otherUserPermission;

    // 操作人unionId
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
        // 是否可删除列
        @NameInMap("deleteColumns")
        public Boolean deleteColumns;

        // 是否可删除行
        @NameInMap("deleteRows")
        public Boolean deleteRows;

        // 是否可修改单元格的值
        @NameInMap("editCells")
        public Boolean editCells;

        // 是否可修改单元格样式
        @NameInMap("formatCells")
        public Boolean formatCells;

        // 是否可插入列
        @NameInMap("insertColumns")
        public Boolean insertColumns;

        // 是否可插入行
        @NameInMap("insertRows")
        public Boolean insertRows;

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

    }

}
