// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PreventCheatingCheckRiskResponseBody extends TeaModel {
    @NameInMap("result")
    public PreventCheatingCheckRiskResponseBodyResult result;

    public static PreventCheatingCheckRiskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PreventCheatingCheckRiskResponseBody self = new PreventCheatingCheckRiskResponseBody();
        return TeaModel.build(map, self);
    }

    public PreventCheatingCheckRiskResponseBody setResult(PreventCheatingCheckRiskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PreventCheatingCheckRiskResponseBodyResult getResult() {
        return this.result;
    }

    public static class PreventCheatingCheckRiskResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("hasRisk")
        public Boolean hasRisk;

        @NameInMap("riskInfo")
        public java.util.Map<String, String> riskInfo;

        public static PreventCheatingCheckRiskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PreventCheatingCheckRiskResponseBodyResult self = new PreventCheatingCheckRiskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PreventCheatingCheckRiskResponseBodyResult setHasRisk(Boolean hasRisk) {
            this.hasRisk = hasRisk;
            return this;
        }
        public Boolean getHasRisk() {
            return this.hasRisk;
        }

        public PreventCheatingCheckRiskResponseBodyResult setRiskInfo(java.util.Map<String, String> riskInfo) {
            this.riskInfo = riskInfo;
            return this;
        }
        public java.util.Map<String, String> getRiskInfo() {
            return this.riskInfo;
        }

    }

}
