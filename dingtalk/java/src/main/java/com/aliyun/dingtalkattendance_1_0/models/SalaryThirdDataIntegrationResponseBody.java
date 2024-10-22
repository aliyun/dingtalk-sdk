// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SalaryThirdDataIntegrationResponseBody extends TeaModel {
    @NameInMap("result")
    public SalaryThirdDataIntegrationResponseBodyResult result;

    public static SalaryThirdDataIntegrationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SalaryThirdDataIntegrationResponseBody self = new SalaryThirdDataIntegrationResponseBody();
        return TeaModel.build(map, self);
    }

    public SalaryThirdDataIntegrationResponseBody setResult(SalaryThirdDataIntegrationResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SalaryThirdDataIntegrationResponseBodyResult getResult() {
        return this.result;
    }

    public static class SalaryThirdDataIntegrationResponseBodyResult extends TeaModel {
        @NameInMap("reason")
        public java.util.Map<String, ?> reason;

        public static SalaryThirdDataIntegrationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SalaryThirdDataIntegrationResponseBodyResult self = new SalaryThirdDataIntegrationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SalaryThirdDataIntegrationResponseBodyResult setReason(java.util.Map<String, ?> reason) {
            this.reason = reason;
            return this;
        }
        public java.util.Map<String, ?> getReason() {
            return this.reason;
        }

    }

}
