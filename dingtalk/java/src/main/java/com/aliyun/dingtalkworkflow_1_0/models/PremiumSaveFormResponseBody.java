// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveFormResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumSaveFormResponseBodyResult result;

    public static PremiumSaveFormResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveFormResponseBody self = new PremiumSaveFormResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumSaveFormResponseBody setResult(PremiumSaveFormResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumSaveFormResponseBodyResult getResult() {
        return this.result;
    }

    public static class PremiumSaveFormResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PROC-abcdef-example</p>
         */
        @NameInMap("processCode")
        public String processCode;

        public static PremiumSaveFormResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveFormResponseBodyResult self = new PremiumSaveFormResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumSaveFormResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
