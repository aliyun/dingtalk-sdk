// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateDeveloperMetadataRequest extends TeaModel {
    /**
     * <p>元数据所关联到的列</p>
     */
    @NameInMap("associatedColumn")
    public CreateDeveloperMetadataRequestAssociatedColumn associatedColumn;

    /**
     * <p>元数据所关联到的行</p>
     */
    @NameInMap("associatedRow")
    public CreateDeveloperMetadataRequestAssociatedRow associatedRow;

    /**
     * <p>元数据值</p>
     */
    @NameInMap("value")
    public String value;

    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateDeveloperMetadataRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDeveloperMetadataRequest self = new CreateDeveloperMetadataRequest();
        return TeaModel.build(map, self);
    }

    public CreateDeveloperMetadataRequest setAssociatedColumn(CreateDeveloperMetadataRequestAssociatedColumn associatedColumn) {
        this.associatedColumn = associatedColumn;
        return this;
    }
    public CreateDeveloperMetadataRequestAssociatedColumn getAssociatedColumn() {
        return this.associatedColumn;
    }

    public CreateDeveloperMetadataRequest setAssociatedRow(CreateDeveloperMetadataRequestAssociatedRow associatedRow) {
        this.associatedRow = associatedRow;
        return this;
    }
    public CreateDeveloperMetadataRequestAssociatedRow getAssociatedRow() {
        return this.associatedRow;
    }

    public CreateDeveloperMetadataRequest setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

    public CreateDeveloperMetadataRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateDeveloperMetadataRequestAssociatedColumn extends TeaModel {
        /**
         * <p>列号，从0开始</p>
         */
        @NameInMap("column")
        public Integer column;

        @NameInMap("sheet")
        public String sheet;

        public static CreateDeveloperMetadataRequestAssociatedColumn build(java.util.Map<String, ?> map) throws Exception {
            CreateDeveloperMetadataRequestAssociatedColumn self = new CreateDeveloperMetadataRequestAssociatedColumn();
            return TeaModel.build(map, self);
        }

        public CreateDeveloperMetadataRequestAssociatedColumn setColumn(Integer column) {
            this.column = column;
            return this;
        }
        public Integer getColumn() {
            return this.column;
        }

        public CreateDeveloperMetadataRequestAssociatedColumn setSheet(String sheet) {
            this.sheet = sheet;
            return this;
        }
        public String getSheet() {
            return this.sheet;
        }

    }

    public static class CreateDeveloperMetadataRequestAssociatedRow extends TeaModel {
        /**
         * <p>行号，从0开始</p>
         */
        @NameInMap("row")
        public Integer row;

        /**
         * <p>工作表ID或名称</p>
         */
        @NameInMap("sheet")
        public String sheet;

        public static CreateDeveloperMetadataRequestAssociatedRow build(java.util.Map<String, ?> map) throws Exception {
            CreateDeveloperMetadataRequestAssociatedRow self = new CreateDeveloperMetadataRequestAssociatedRow();
            return TeaModel.build(map, self);
        }

        public CreateDeveloperMetadataRequestAssociatedRow setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

        public CreateDeveloperMetadataRequestAssociatedRow setSheet(String sheet) {
            this.sheet = sheet;
            return this;
        }
        public String getSheet() {
            return this.sheet;
        }

    }

}
