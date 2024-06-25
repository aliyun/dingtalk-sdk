// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateDeveloperMetadataRequest extends TeaModel {
    @NameInMap("associatedColumn")
    public CreateDeveloperMetadataRequestAssociatedColumn associatedColumn;

    @NameInMap("associatedRow")
    public CreateDeveloperMetadataRequestAssociatedRow associatedRow;

    @NameInMap("value")
    public String value;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("column")
        public Integer column;

        /**
         * <p>This parameter is required.</p>
         */
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("row")
        public Integer row;

        /**
         * <p>This parameter is required.</p>
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
