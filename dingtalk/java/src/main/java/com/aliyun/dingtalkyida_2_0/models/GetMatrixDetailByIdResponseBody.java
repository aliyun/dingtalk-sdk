// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetMatrixDetailByIdResponseBody extends TeaModel {
    @NameInMap("result")
    public GetMatrixDetailByIdResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetMatrixDetailByIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMatrixDetailByIdResponseBody self = new GetMatrixDetailByIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMatrixDetailByIdResponseBody setResult(GetMatrixDetailByIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetMatrixDetailByIdResponseBodyResult getResult() {
        return this.result;
    }

    public GetMatrixDetailByIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetMatrixDetailByIdResponseBodyResultDescription extends TeaModel {
        @NameInMap("en_US")
        public String enUS;

        @NameInMap("type")
        public String type;

        @NameInMap("zh_CN")
        public String zhCN;

        public static GetMatrixDetailByIdResponseBodyResultDescription build(java.util.Map<String, ?> map) throws Exception {
            GetMatrixDetailByIdResponseBodyResultDescription self = new GetMatrixDetailByIdResponseBodyResultDescription();
            return TeaModel.build(map, self);
        }

        public GetMatrixDetailByIdResponseBodyResultDescription setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetMatrixDetailByIdResponseBodyResultDescription setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetMatrixDetailByIdResponseBodyResultDescription setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetMatrixDetailByIdResponseBodyResultMatrixData extends TeaModel {
        @NameInMap("currentPage")
        public Integer currentPage;

        @NameInMap("data")
        public Object data;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static GetMatrixDetailByIdResponseBodyResultMatrixData build(java.util.Map<String, ?> map) throws Exception {
            GetMatrixDetailByIdResponseBodyResultMatrixData self = new GetMatrixDetailByIdResponseBodyResultMatrixData();
            return TeaModel.build(map, self);
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixData setCurrentPage(Integer currentPage) {
            this.currentPage = currentPage;
            return this;
        }
        public Integer getCurrentPage() {
            return this.currentPage;
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixData setData(Object data) {
            this.data = data;
            return this;
        }
        public Object getData() {
            return this.data;
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixData setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

    public static class GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn extends TeaModel {
        @NameInMap("columnId")
        public String columnId;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("name")
        public String name;

        public static GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn build(java.util.Map<String, ?> map) throws Exception {
            GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn self = new GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn();
            return TeaModel.build(map, self);
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn setColumnId(String columnId) {
            this.columnId = columnId;
            return this;
        }
        public String getColumnId() {
            return this.columnId;
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn extends TeaModel {
        @NameInMap("columnId")
        public String columnId;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("name")
        public String name;

        public static GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn build(java.util.Map<String, ?> map) throws Exception {
            GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn self = new GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn();
            return TeaModel.build(map, self);
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn setColumnId(String columnId) {
            this.columnId = columnId;
            return this;
        }
        public String getColumnId() {
            return this.columnId;
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetMatrixDetailByIdResponseBodyResultMatrixTable extends TeaModel {
        @NameInMap("conditionColumn")
        public java.util.List<GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn> conditionColumn;

        @NameInMap("resultColumn")
        public java.util.List<GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn> resultColumn;

        public static GetMatrixDetailByIdResponseBodyResultMatrixTable build(java.util.Map<String, ?> map) throws Exception {
            GetMatrixDetailByIdResponseBodyResultMatrixTable self = new GetMatrixDetailByIdResponseBodyResultMatrixTable();
            return TeaModel.build(map, self);
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTable setConditionColumn(java.util.List<GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn> conditionColumn) {
            this.conditionColumn = conditionColumn;
            return this;
        }
        public java.util.List<GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn> getConditionColumn() {
            return this.conditionColumn;
        }

        public GetMatrixDetailByIdResponseBodyResultMatrixTable setResultColumn(java.util.List<GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn> resultColumn) {
            this.resultColumn = resultColumn;
            return this;
        }
        public java.util.List<GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn> getResultColumn() {
            return this.resultColumn;
        }

    }

    public static class GetMatrixDetailByIdResponseBodyResultName extends TeaModel {
        @NameInMap("en_US")
        public String enUS;

        @NameInMap("type")
        public String type;

        @NameInMap("zh_CN")
        public String zhCN;

        public static GetMatrixDetailByIdResponseBodyResultName build(java.util.Map<String, ?> map) throws Exception {
            GetMatrixDetailByIdResponseBodyResultName self = new GetMatrixDetailByIdResponseBodyResultName();
            return TeaModel.build(map, self);
        }

        public GetMatrixDetailByIdResponseBodyResultName setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetMatrixDetailByIdResponseBodyResultName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetMatrixDetailByIdResponseBodyResultName setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetMatrixDetailByIdResponseBodyResult extends TeaModel {
        @NameInMap("description")
        public GetMatrixDetailByIdResponseBodyResultDescription description;

        @NameInMap("matrixData")
        public GetMatrixDetailByIdResponseBodyResultMatrixData matrixData;

        @NameInMap("matrixId")
        public String matrixId;

        @NameInMap("matrixTable")
        public GetMatrixDetailByIdResponseBodyResultMatrixTable matrixTable;

        @NameInMap("name")
        public GetMatrixDetailByIdResponseBodyResultName name;

        @NameInMap("rowTotalCount")
        public Integer rowTotalCount;

        public static GetMatrixDetailByIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetMatrixDetailByIdResponseBodyResult self = new GetMatrixDetailByIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetMatrixDetailByIdResponseBodyResult setDescription(GetMatrixDetailByIdResponseBodyResultDescription description) {
            this.description = description;
            return this;
        }
        public GetMatrixDetailByIdResponseBodyResultDescription getDescription() {
            return this.description;
        }

        public GetMatrixDetailByIdResponseBodyResult setMatrixData(GetMatrixDetailByIdResponseBodyResultMatrixData matrixData) {
            this.matrixData = matrixData;
            return this;
        }
        public GetMatrixDetailByIdResponseBodyResultMatrixData getMatrixData() {
            return this.matrixData;
        }

        public GetMatrixDetailByIdResponseBodyResult setMatrixId(String matrixId) {
            this.matrixId = matrixId;
            return this;
        }
        public String getMatrixId() {
            return this.matrixId;
        }

        public GetMatrixDetailByIdResponseBodyResult setMatrixTable(GetMatrixDetailByIdResponseBodyResultMatrixTable matrixTable) {
            this.matrixTable = matrixTable;
            return this;
        }
        public GetMatrixDetailByIdResponseBodyResultMatrixTable getMatrixTable() {
            return this.matrixTable;
        }

        public GetMatrixDetailByIdResponseBodyResult setName(GetMatrixDetailByIdResponseBodyResultName name) {
            this.name = name;
            return this;
        }
        public GetMatrixDetailByIdResponseBodyResultName getName() {
            return this.name;
        }

        public GetMatrixDetailByIdResponseBodyResult setRowTotalCount(Integer rowTotalCount) {
            this.rowTotalCount = rowTotalCount;
            return this;
        }
        public Integer getRowTotalCount() {
            return this.rowTotalCount;
        }

    }

}
