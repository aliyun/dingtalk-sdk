// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFieldModifiedHistoryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<PremiumGetFieldModifiedHistoryResponseBodyResult> result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PremiumGetFieldModifiedHistoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFieldModifiedHistoryResponseBody self = new PremiumGetFieldModifiedHistoryResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetFieldModifiedHistoryResponseBody setResult(java.util.List<PremiumGetFieldModifiedHistoryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<PremiumGetFieldModifiedHistoryResponseBodyResult> getResult() {
        return this.result;
    }

    public PremiumGetFieldModifiedHistoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGetFieldModifiedHistoryResponseBodyResult extends TeaModel {
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

        public static PremiumGetFieldModifiedHistoryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFieldModifiedHistoryResponseBodyResult self = new PremiumGetFieldModifiedHistoryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetFieldModifiedHistoryResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public PremiumGetFieldModifiedHistoryResponseBodyResult setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public PremiumGetFieldModifiedHistoryResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumGetFieldModifiedHistoryResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public PremiumGetFieldModifiedHistoryResponseBodyResult setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
