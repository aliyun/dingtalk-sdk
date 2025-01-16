// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetInstFieldSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<PremiumGetInstFieldSettingResponseBodyResult> result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PremiumGetInstFieldSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetInstFieldSettingResponseBody self = new PremiumGetInstFieldSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetInstFieldSettingResponseBody setResult(java.util.List<PremiumGetInstFieldSettingResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<PremiumGetInstFieldSettingResponseBodyResult> getResult() {
        return this.result;
    }

    public PremiumGetInstFieldSettingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGetInstFieldSettingResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>TextField</p>
         */
        @NameInMap("componentType")
        public String componentType;

        /**
         * <strong>example:</strong>
         * <p>READONLY</p>
         */
        @NameInMap("fieldBehavior")
        public String fieldBehavior;

        /**
         * <strong>example:</strong>
         * <p>TextField-abcd</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        public static PremiumGetInstFieldSettingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetInstFieldSettingResponseBodyResult self = new PremiumGetInstFieldSettingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetInstFieldSettingResponseBodyResult setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumGetInstFieldSettingResponseBodyResult setFieldBehavior(String fieldBehavior) {
            this.fieldBehavior = fieldBehavior;
            return this;
        }
        public String getFieldBehavior() {
            return this.fieldBehavior;
        }

        public PremiumGetInstFieldSettingResponseBodyResult setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

}
