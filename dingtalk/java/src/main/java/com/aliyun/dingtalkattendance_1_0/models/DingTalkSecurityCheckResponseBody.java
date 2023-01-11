// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DingTalkSecurityCheckResponseBody extends TeaModel {
    /**
     * <p>返回参数</p>
     */
    @NameInMap("result")
    public DingTalkSecurityCheckResponseBodyResult result;

    public static DingTalkSecurityCheckResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DingTalkSecurityCheckResponseBody self = new DingTalkSecurityCheckResponseBody();
        return TeaModel.build(map, self);
    }

    public DingTalkSecurityCheckResponseBody setResult(DingTalkSecurityCheckResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DingTalkSecurityCheckResponseBodyResult getResult() {
        return this.result;
    }

    public static class DingTalkSecurityCheckResponseBodyResult extends TeaModel {
        /**
         * <p>是否有风险</p>
         */
        @NameInMap("hasRisk")
        public Boolean hasRisk;

        /**
         * <p>风险信息</p>
         */
        @NameInMap("riskInfo")
        public java.util.Map<String, String> riskInfo;

        public static DingTalkSecurityCheckResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DingTalkSecurityCheckResponseBodyResult self = new DingTalkSecurityCheckResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DingTalkSecurityCheckResponseBodyResult setHasRisk(Boolean hasRisk) {
            this.hasRisk = hasRisk;
            return this;
        }
        public Boolean getHasRisk() {
            return this.hasRisk;
        }

        public DingTalkSecurityCheckResponseBodyResult setRiskInfo(java.util.Map<String, String> riskInfo) {
            this.riskInfo = riskInfo;
            return this;
        }
        public java.util.Map<String, String> getRiskInfo() {
            return this.riskInfo;
        }

    }

}
