// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateRangeProtectionRequest extends TeaModel {
    /**
     * <p>对于拥有「可编辑」权限的用户的细化权限配置。</p>
     */
    @NameInMap("editableSetting")
    public CreateRangeProtectionRequestEditableSetting editableSetting;

    /**
     * <p>其它用户的权限</p>
     */
    @NameInMap("otherUserPermission")
    public String otherUserPermission;

    /**
     * <p>操作人unionId</p>
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
        /**
         * <p>是否可删除列</p>
         */
        @NameInMap("deleteColumns")
        public Boolean deleteColumns;

        /**
         * <p>是否可删除行</p>
         */
        @NameInMap("deleteRows")
        public Boolean deleteRows;

        /**
         * <p>是否可修改单元格的值</p>
         */
        @NameInMap("editCells")
        public Boolean editCells;

        /**
         * <p>是否可修改单元格样式</p>
         */
        @NameInMap("formatCells")
        public Boolean formatCells;

        /**
         * <p>是否可插入列</p>
         */
        @NameInMap("insertColumns")
        public Boolean insertColumns;

        /**
         * <p>是否可插入行</p>
         */
        @NameInMap("insertRows")
        public Boolean insertRows;

        /**
         * <p>是否可显示、隐藏列</p>
         */
        @NameInMap("toggleColumnsVisibility")
        public Boolean toggleColumnsVisibility;

        /**
         * <p>是否可显示、隐藏行</p>
         */
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

}
