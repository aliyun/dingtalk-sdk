// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceBatchResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryGeneralDataServiceBatchResponseBodyMetaList> metaList;

    public static QueryGeneralDataServiceBatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataServiceBatchResponseBody self = new QueryGeneralDataServiceBatchResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataServiceBatchResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryGeneralDataServiceBatchResponseBody setMetaList(java.util.List<QueryGeneralDataServiceBatchResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryGeneralDataServiceBatchResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryGeneralDataServiceBatchResponseBodyMetaList extends TeaModel {
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

        public static QueryGeneralDataServiceBatchResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryGeneralDataServiceBatchResponseBodyMetaList self = new QueryGeneralDataServiceBatchResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryGeneralDataServiceBatchResponseBodyMetaList setFieldDesc(String fieldDesc) {
            this.fieldDesc = fieldDesc;
            return this;
        }
        public String getFieldDesc() {
            return this.fieldDesc;
        }

        public QueryGeneralDataServiceBatchResponseBodyMetaList setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public QueryGeneralDataServiceBatchResponseBodyMetaList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public QueryGeneralDataServiceBatchResponseBodyMetaList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

}
