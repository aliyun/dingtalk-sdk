// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetEmployeeRosterByFieldResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetEmployeeRosterByFieldResponseBodyResult> result;

    public static GetEmployeeRosterByFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEmployeeRosterByFieldResponseBody self = new GetEmployeeRosterByFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEmployeeRosterByFieldResponseBody setResult(java.util.List<GetEmployeeRosterByFieldResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetEmployeeRosterByFieldResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList extends TeaModel {
        @NameInMap("itemIndex")
        public Integer itemIndex;

        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList build(java.util.Map<String, ?> map) throws Exception {
            GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList self = new GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList();
            return TeaModel.build(map, self);
        }

        public GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList setItemIndex(Integer itemIndex) {
            this.itemIndex = itemIndex;
            return this;
        }
        public Integer getItemIndex() {
            return this.itemIndex;
        }

        public GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetEmployeeRosterByFieldResponseBodyResultFieldDataList extends TeaModel {
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldValueList")
        public java.util.List<GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList> fieldValueList;

        @NameInMap("groupId")
        public String groupId;

        public static GetEmployeeRosterByFieldResponseBodyResultFieldDataList build(java.util.Map<String, ?> map) throws Exception {
            GetEmployeeRosterByFieldResponseBodyResultFieldDataList self = new GetEmployeeRosterByFieldResponseBodyResultFieldDataList();
            return TeaModel.build(map, self);
        }

        public GetEmployeeRosterByFieldResponseBodyResultFieldDataList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public GetEmployeeRosterByFieldResponseBodyResultFieldDataList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public GetEmployeeRosterByFieldResponseBodyResultFieldDataList setFieldValueList(java.util.List<GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList> fieldValueList) {
            this.fieldValueList = fieldValueList;
            return this;
        }
        public java.util.List<GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList> getFieldValueList() {
            return this.fieldValueList;
        }

        public GetEmployeeRosterByFieldResponseBodyResultFieldDataList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

    }

    public static class GetEmployeeRosterByFieldResponseBodyResult extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("fieldDataList")
        public java.util.List<GetEmployeeRosterByFieldResponseBodyResultFieldDataList> fieldDataList;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static GetEmployeeRosterByFieldResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetEmployeeRosterByFieldResponseBodyResult self = new GetEmployeeRosterByFieldResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetEmployeeRosterByFieldResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetEmployeeRosterByFieldResponseBodyResult setFieldDataList(java.util.List<GetEmployeeRosterByFieldResponseBodyResultFieldDataList> fieldDataList) {
            this.fieldDataList = fieldDataList;
            return this;
        }
        public java.util.List<GetEmployeeRosterByFieldResponseBodyResultFieldDataList> getFieldDataList() {
            return this.fieldDataList;
        }

        public GetEmployeeRosterByFieldResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetEmployeeRosterByFieldResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
