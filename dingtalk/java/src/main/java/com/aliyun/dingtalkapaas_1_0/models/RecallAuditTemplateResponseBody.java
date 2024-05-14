// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class RecallAuditTemplateResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recallResult")
    public java.util.List<RecallAuditTemplateResponseBodyRecallResult> recallResult;

    public static RecallAuditTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RecallAuditTemplateResponseBody self = new RecallAuditTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public RecallAuditTemplateResponseBody setRecallResult(java.util.List<RecallAuditTemplateResponseBodyRecallResult> recallResult) {
        this.recallResult = recallResult;
        return this;
    }
    public java.util.List<RecallAuditTemplateResponseBodyRecallResult> getRecallResult() {
        return this.recallResult;
    }

    public static class RecallAuditTemplateResponseBodyRecallResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("templateKey")
        public String templateKey;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static RecallAuditTemplateResponseBodyRecallResult build(java.util.Map<String, ?> map) throws Exception {
            RecallAuditTemplateResponseBodyRecallResult self = new RecallAuditTemplateResponseBodyRecallResult();
            return TeaModel.build(map, self);
        }

        public RecallAuditTemplateResponseBodyRecallResult setTemplateKey(String templateKey) {
            this.templateKey = templateKey;
            return this;
        }
        public String getTemplateKey() {
            return this.templateKey;
        }

        public RecallAuditTemplateResponseBodyRecallResult setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
