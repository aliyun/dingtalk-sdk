// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartFormulaResultServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public SmartFormulaResultServiceResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SmartFormulaResultServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SmartFormulaResultServiceResponseBody self = new SmartFormulaResultServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SmartFormulaResultServiceResponseBody setResult(SmartFormulaResultServiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SmartFormulaResultServiceResponseBodyResult getResult() {
        return this.result;
    }

    public SmartFormulaResultServiceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SmartFormulaResultServiceResponseBodyResult extends TeaModel {
        @NameInMap("response")
        public String response;

        @NameInMap("status")
        public String status;

        public static SmartFormulaResultServiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SmartFormulaResultServiceResponseBodyResult self = new SmartFormulaResultServiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SmartFormulaResultServiceResponseBodyResult setResponse(String response) {
            this.response = response;
            return this;
        }
        public String getResponse() {
            return this.response;
        }

        public SmartFormulaResultServiceResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
