// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataQueryResponseBody extends TeaModel {
    @NameInMap("total")
    public Long total;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("result")
    public java.util.List<MasterDataQueryResponseBodyResult> result;

    public static MasterDataQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MasterDataQueryResponseBody self = new MasterDataQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public MasterDataQueryResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public MasterDataQueryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public MasterDataQueryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public MasterDataQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public MasterDataQueryResponseBody setResult(java.util.List<MasterDataQueryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<MasterDataQueryResponseBodyResult> getResult() {
        return this.result;
    }

    public static class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO self = new MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class MasterDataQueryResponseBodyResultViewEntityFieldVOList extends TeaModel {
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldDataVO")
        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("attrs")
        public java.util.Map<String, java.util.Map<String, ?>> attrs;

        public static MasterDataQueryResponseBodyResultViewEntityFieldVOList build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityFieldVOList self = new MasterDataQueryResponseBodyResultViewEntityFieldVOList();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldDataVO(MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO) {
            this.fieldDataVO = fieldDataVO;
            return this;
        }
        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO getFieldDataVO() {
            return this.fieldDataVO;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setAttrs(java.util.Map<String, java.util.Map<String, ?>> attrs) {
            this.attrs = attrs;
            return this;
        }
        public java.util.Map<String, java.util.Map<String, ?>> getAttrs() {
            return this.attrs;
        }

    }

    public static class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO self = new MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList extends TeaModel {
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldDataVO")
        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO fieldDataVO;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("attrs")
        public java.util.Map<String, java.util.Map<String, ?>> attrs;

        public static MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList self = new MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList setFieldDataVO(MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO fieldDataVO) {
            this.fieldDataVO = fieldDataVO;
            return this;
        }
        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO getFieldDataVO() {
            return this.fieldDataVO;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList setAttrs(java.util.Map<String, java.util.Map<String, ?>> attrs) {
            this.attrs = attrs;
            return this;
        }
        public java.util.Map<String, java.util.Map<String, ?>> getAttrs() {
            return this.attrs;
        }

    }

    public static class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields extends TeaModel {
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("viewEntityFieldList")
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList> viewEntityFieldList;

        public static MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields self = new MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields setViewEntityFieldList(java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList> viewEntityFieldList) {
            this.viewEntityFieldList = viewEntityFieldList;
            return this;
        }
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList> getViewEntityFieldList() {
            return this.viewEntityFieldList;
        }

    }

    public static class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList extends TeaModel {
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("rowFields")
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields> rowFields;

        public static MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList self = new MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList setRowFields(java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields> rowFields) {
            this.rowFields = rowFields;
            return this;
        }
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields> getRowFields() {
            return this.rowFields;
        }

    }

    public static class MasterDataQueryResponseBodyResult extends TeaModel {
        @NameInMap("outerId")
        public String outerId;

        @NameInMap("scopeCode")
        public String scopeCode;

        @NameInMap("viewEntityCode")
        public String viewEntityCode;

        @NameInMap("viewEntityFieldVOList")
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList;

        @NameInMap("viewEntityMultiFieldVOList")
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList> viewEntityMultiFieldVOList;

        public static MasterDataQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResult self = new MasterDataQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResult setOuterId(String outerId) {
            this.outerId = outerId;
            return this;
        }
        public String getOuterId() {
            return this.outerId;
        }

        public MasterDataQueryResponseBodyResult setScopeCode(String scopeCode) {
            this.scopeCode = scopeCode;
            return this;
        }
        public String getScopeCode() {
            return this.scopeCode;
        }

        public MasterDataQueryResponseBodyResult setViewEntityCode(String viewEntityCode) {
            this.viewEntityCode = viewEntityCode;
            return this;
        }
        public String getViewEntityCode() {
            return this.viewEntityCode;
        }

        public MasterDataQueryResponseBodyResult setViewEntityFieldVOList(java.util.List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList) {
            this.viewEntityFieldVOList = viewEntityFieldVOList;
            return this;
        }
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> getViewEntityFieldVOList() {
            return this.viewEntityFieldVOList;
        }

        public MasterDataQueryResponseBodyResult setViewEntityMultiFieldVOList(java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList> viewEntityMultiFieldVOList) {
            this.viewEntityMultiFieldVOList = viewEntityMultiFieldVOList;
            return this;
        }
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList> getViewEntityMultiFieldVOList() {
            return this.viewEntityMultiFieldVOList;
        }

    }

}
