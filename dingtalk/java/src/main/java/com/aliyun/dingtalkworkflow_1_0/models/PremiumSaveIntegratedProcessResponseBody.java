// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedProcessResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumSaveIntegratedProcessResponseBodyResult result;

    public static PremiumSaveIntegratedProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedProcessResponseBody self = new PremiumSaveIntegratedProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedProcessResponseBody setResult(PremiumSaveIntegratedProcessResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumSaveIntegratedProcessResponseBodyResult getResult() {
        return this.result;
    }

    public static class PremiumSaveIntegratedProcessResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PROC-abcdef-example</p>
         */
        @NameInMap("processCode")
        public String processCode;

        public static PremiumSaveIntegratedProcessResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessResponseBodyResult self = new PremiumSaveIntegratedProcessResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
