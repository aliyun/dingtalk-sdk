// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetColumnvalsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetColumnvalsResponseBodyResult> result;

    public static GetColumnvalsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetColumnvalsResponseBody self = new GetColumnvalsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetColumnvalsResponseBody setResult(java.util.List<GetColumnvalsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetColumnvalsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetColumnvalsResponseBodyResultColumnDataColumnValues extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1709222400000</p>
         */
        @NameInMap("date")
        public Long date;

        @NameInMap("value")
        public String value;

        public static GetColumnvalsResponseBodyResultColumnDataColumnValues build(java.util.Map<String, ?> map) throws Exception {
            GetColumnvalsResponseBodyResultColumnDataColumnValues self = new GetColumnvalsResponseBodyResultColumnDataColumnValues();
            return TeaModel.build(map, self);
        }

        public GetColumnvalsResponseBodyResultColumnDataColumnValues setDate(Long date) {
            this.date = date;
            return this;
        }
        public Long getDate() {
            return this.date;
        }

        public GetColumnvalsResponseBodyResultColumnDataColumnValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetColumnvalsResponseBodyResultColumnData extends TeaModel {
        @NameInMap("columnValues")
        public java.util.List<GetColumnvalsResponseBodyResultColumnDataColumnValues> columnValues;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("fixedValue")
        public String fixedValue;

        /**
         * <strong>example:</strong>
         * <p>129339038</p>
         */
        @NameInMap("id")
        public Long id;

        public static GetColumnvalsResponseBodyResultColumnData build(java.util.Map<String, ?> map) throws Exception {
            GetColumnvalsResponseBodyResultColumnData self = new GetColumnvalsResponseBodyResultColumnData();
            return TeaModel.build(map, self);
        }

        public GetColumnvalsResponseBodyResultColumnData setColumnValues(java.util.List<GetColumnvalsResponseBodyResultColumnDataColumnValues> columnValues) {
            this.columnValues = columnValues;
            return this;
        }
        public java.util.List<GetColumnvalsResponseBodyResultColumnDataColumnValues> getColumnValues() {
            return this.columnValues;
        }

        public GetColumnvalsResponseBodyResultColumnData setFixedValue(String fixedValue) {
            this.fixedValue = fixedValue;
            return this;
        }
        public String getFixedValue() {
            return this.fixedValue;
        }

        public GetColumnvalsResponseBodyResultColumnData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

    public static class GetColumnvalsResponseBodyResult extends TeaModel {
        @NameInMap("columnData")
        public java.util.List<GetColumnvalsResponseBodyResultColumnData> columnData;

        /**
         * <strong>example:</strong>
         * <p>manager123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetColumnvalsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetColumnvalsResponseBodyResult self = new GetColumnvalsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetColumnvalsResponseBodyResult setColumnData(java.util.List<GetColumnvalsResponseBodyResultColumnData> columnData) {
            this.columnData = columnData;
            return this;
        }
        public java.util.List<GetColumnvalsResponseBodyResultColumnData> getColumnData() {
            return this.columnData;
        }

        public GetColumnvalsResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
