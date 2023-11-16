// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaAvailableFieldListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<RosterMetaAvailableFieldListResponseBodyResult> result;

    public static RosterMetaAvailableFieldListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RosterMetaAvailableFieldListResponseBody self = new RosterMetaAvailableFieldListResponseBody();
        return TeaModel.build(map, self);
    }

    public RosterMetaAvailableFieldListResponseBody setResult(java.util.List<RosterMetaAvailableFieldListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<RosterMetaAvailableFieldListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class RosterMetaAvailableFieldListResponseBodyResult extends TeaModel {
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("optionText")
        public String optionText;

        public static RosterMetaAvailableFieldListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RosterMetaAvailableFieldListResponseBodyResult self = new RosterMetaAvailableFieldListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RosterMetaAvailableFieldListResponseBodyResult setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public RosterMetaAvailableFieldListResponseBodyResult setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public RosterMetaAvailableFieldListResponseBodyResult setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public RosterMetaAvailableFieldListResponseBodyResult setOptionText(String optionText) {
            this.optionText = optionText;
            return this;
        }
        public String getOptionText() {
            return this.optionText;
        }

    }

}
