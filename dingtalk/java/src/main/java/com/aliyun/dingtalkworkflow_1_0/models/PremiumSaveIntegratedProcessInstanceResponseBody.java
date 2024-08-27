// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedProcessInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumSaveIntegratedProcessInstanceResponseBodyResult result;

    public static PremiumSaveIntegratedProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedProcessInstanceResponseBody self = new PremiumSaveIntegratedProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedProcessInstanceResponseBody setResult(PremiumSaveIntegratedProcessInstanceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumSaveIntegratedProcessInstanceResponseBodyResult getResult() {
        return this.result;
    }

    public static class PremiumSaveIntegratedProcessInstanceResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>proc-abc</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        public static PremiumSaveIntegratedProcessInstanceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessInstanceResponseBodyResult self = new PremiumSaveIntegratedProcessInstanceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessInstanceResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

    }

}
