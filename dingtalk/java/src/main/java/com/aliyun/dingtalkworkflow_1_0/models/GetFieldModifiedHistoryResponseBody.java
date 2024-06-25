// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetFieldModifiedHistoryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFieldModifiedHistoryResponseBodyResult> result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetFieldModifiedHistoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFieldModifiedHistoryResponseBody self = new GetFieldModifiedHistoryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFieldModifiedHistoryResponseBody setResult(java.util.List<GetFieldModifiedHistoryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetFieldModifiedHistoryResponseBodyResult> getResult() {
        return this.result;
    }

    public GetFieldModifiedHistoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFieldModifiedHistoryResponseBodyResult extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2024-04-02T11:52Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>TextField-abcd</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <strong>example:</strong>
         * <p>钉钉1</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>userId1</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>从 111 修改到 222</p>
         */
        @NameInMap("value")
        public String value;

        public static GetFieldModifiedHistoryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFieldModifiedHistoryResponseBodyResult self = new GetFieldModifiedHistoryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFieldModifiedHistoryResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetFieldModifiedHistoryResponseBodyResult setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public GetFieldModifiedHistoryResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFieldModifiedHistoryResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetFieldModifiedHistoryResponseBodyResult setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
