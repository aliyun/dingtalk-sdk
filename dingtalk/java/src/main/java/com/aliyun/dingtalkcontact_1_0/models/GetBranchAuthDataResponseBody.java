// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetBranchAuthDataResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetBranchAuthDataResponseBodyResult> result;

    public static GetBranchAuthDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBranchAuthDataResponseBody self = new GetBranchAuthDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBranchAuthDataResponseBody setResult(java.util.List<GetBranchAuthDataResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetBranchAuthDataResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetBranchAuthDataResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>teacherCnt</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>老师数量</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <strong>example:</strong>
         * <p>120</p>
         */
        @NameInMap("fieldValue")
        public String fieldValue;

        public static GetBranchAuthDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetBranchAuthDataResponseBodyResult self = new GetBranchAuthDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetBranchAuthDataResponseBodyResult setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public GetBranchAuthDataResponseBodyResult setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public GetBranchAuthDataResponseBodyResult setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

    }

}
