// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteBatchQueryResultServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public SmartQuoteBatchQueryResultServiceResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SmartQuoteBatchQueryResultServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteBatchQueryResultServiceResponseBody self = new SmartQuoteBatchQueryResultServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SmartQuoteBatchQueryResultServiceResponseBody setResult(SmartQuoteBatchQueryResultServiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SmartQuoteBatchQueryResultServiceResponseBodyResult getResult() {
        return this.result;
    }

    public SmartQuoteBatchQueryResultServiceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SmartQuoteBatchQueryResultServiceResponseBodyResult extends TeaModel {
        @NameInMap("response")
        public String response;

        @NameInMap("status")
        public String status;

        public static SmartQuoteBatchQueryResultServiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SmartQuoteBatchQueryResultServiceResponseBodyResult self = new SmartQuoteBatchQueryResultServiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SmartQuoteBatchQueryResultServiceResponseBodyResult setResponse(String response) {
            this.response = response;
            return this;
        }
        public String getResponse() {
            return this.response;
        }

        public SmartQuoteBatchQueryResultServiceResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
