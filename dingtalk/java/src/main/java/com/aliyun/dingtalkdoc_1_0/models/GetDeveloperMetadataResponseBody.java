// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetDeveloperMetadataResponseBody extends TeaModel {
    @NameInMap("associatedColumn")
    public GetDeveloperMetadataResponseBodyAssociatedColumn associatedColumn;

    @NameInMap("associatedRow")
    public GetDeveloperMetadataResponseBodyAssociatedRow associatedRow;

    @NameInMap("value")
    public Object value;

    public static GetDeveloperMetadataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeveloperMetadataResponseBody self = new GetDeveloperMetadataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeveloperMetadataResponseBody setAssociatedColumn(GetDeveloperMetadataResponseBodyAssociatedColumn associatedColumn) {
        this.associatedColumn = associatedColumn;
        return this;
    }
    public GetDeveloperMetadataResponseBodyAssociatedColumn getAssociatedColumn() {
        return this.associatedColumn;
    }

    public GetDeveloperMetadataResponseBody setAssociatedRow(GetDeveloperMetadataResponseBodyAssociatedRow associatedRow) {
        this.associatedRow = associatedRow;
        return this;
    }
    public GetDeveloperMetadataResponseBodyAssociatedRow getAssociatedRow() {
        return this.associatedRow;
    }

    public GetDeveloperMetadataResponseBody setValue(Object value) {
        this.value = value;
        return this;
    }
    public Object getValue() {
        return this.value;
    }

    public static class GetDeveloperMetadataResponseBodyAssociatedColumn extends TeaModel {
        @NameInMap("column")
        public Integer column;

        @NameInMap("sheetId")
        public String sheetId;

        public static GetDeveloperMetadataResponseBodyAssociatedColumn build(java.util.Map<String, ?> map) throws Exception {
            GetDeveloperMetadataResponseBodyAssociatedColumn self = new GetDeveloperMetadataResponseBodyAssociatedColumn();
            return TeaModel.build(map, self);
        }

        public GetDeveloperMetadataResponseBodyAssociatedColumn setColumn(Integer column) {
            this.column = column;
            return this;
        }
        public Integer getColumn() {
            return this.column;
        }

        public GetDeveloperMetadataResponseBodyAssociatedColumn setSheetId(String sheetId) {
            this.sheetId = sheetId;
            return this;
        }
        public String getSheetId() {
            return this.sheetId;
        }

    }

    public static class GetDeveloperMetadataResponseBodyAssociatedRow extends TeaModel {
        @NameInMap("row")
        public Integer row;

        @NameInMap("sheetId")
        public String sheetId;

        public static GetDeveloperMetadataResponseBodyAssociatedRow build(java.util.Map<String, ?> map) throws Exception {
            GetDeveloperMetadataResponseBodyAssociatedRow self = new GetDeveloperMetadataResponseBodyAssociatedRow();
            return TeaModel.build(map, self);
        }

        public GetDeveloperMetadataResponseBodyAssociatedRow setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

        public GetDeveloperMetadataResponseBodyAssociatedRow setSheetId(String sheetId) {
            this.sheetId = sheetId;
            return this;
        }
        public String getSheetId() {
            return this.sheetId;
        }

    }

}
