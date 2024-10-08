// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryGeneralDataServiceResponseBodyMetaList> metaList;

    @NameInMap("total")
    public String total;

    public static QueryGeneralDataServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataServiceResponseBody self = new QueryGeneralDataServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataServiceResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryGeneralDataServiceResponseBody setMetaList(java.util.List<QueryGeneralDataServiceResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryGeneralDataServiceResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public QueryGeneralDataServiceResponseBody setTotal(String total) {
        this.total = total;
        return this;
    }
    public String getTotal() {
        return this.total;
    }

    public static class QueryGeneralDataServiceResponseBodyMetaList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldDesc")
        public String fieldDesc;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        public static QueryGeneralDataServiceResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryGeneralDataServiceResponseBodyMetaList self = new QueryGeneralDataServiceResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryGeneralDataServiceResponseBodyMetaList setFieldDesc(String fieldDesc) {
            this.fieldDesc = fieldDesc;
            return this;
        }
        public String getFieldDesc() {
            return this.fieldDesc;
        }

        public QueryGeneralDataServiceResponseBodyMetaList setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public QueryGeneralDataServiceResponseBodyMetaList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public QueryGeneralDataServiceResponseBodyMetaList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

}
