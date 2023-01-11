// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceResponseBody extends TeaModel {
    /**
     * <p>指标数据</p>
     */
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    /**
     * <p>指标元数据</p>
     */
    @NameInMap("metaList")
    public java.util.List<QueryGeneralDataServiceResponseBodyMetaList> metaList;

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

    public static class QueryGeneralDataServiceResponseBodyMetaList extends TeaModel {
        /**
         * <p>指标名称</p>
         */
        @NameInMap("fieldDesc")
        public String fieldDesc;

        /**
         * <p>指标口径</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>指标ID</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <p>指标单位</p>
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
