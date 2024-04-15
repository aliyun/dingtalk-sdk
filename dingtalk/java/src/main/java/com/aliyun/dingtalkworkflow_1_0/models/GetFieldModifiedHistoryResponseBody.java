// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetFieldModifiedHistoryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFieldModifiedHistoryResponseBodyResult> result;

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
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

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
