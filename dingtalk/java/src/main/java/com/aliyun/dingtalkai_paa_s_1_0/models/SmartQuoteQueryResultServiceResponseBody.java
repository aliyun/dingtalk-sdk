// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteQueryResultServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public SmartQuoteQueryResultServiceResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SmartQuoteQueryResultServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteQueryResultServiceResponseBody self = new SmartQuoteQueryResultServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SmartQuoteQueryResultServiceResponseBody setResult(SmartQuoteQueryResultServiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SmartQuoteQueryResultServiceResponseBodyResult getResult() {
        return this.result;
    }

    public SmartQuoteQueryResultServiceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SmartQuoteQueryResultServiceResponseBodyResult extends TeaModel {
        @NameInMap("response")
        public String response;

        @NameInMap("status")
        public String status;

        public static SmartQuoteQueryResultServiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SmartQuoteQueryResultServiceResponseBodyResult self = new SmartQuoteQueryResultServiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SmartQuoteQueryResultServiceResponseBodyResult setResponse(String response) {
            this.response = response;
            return this;
        }
        public String getResponse() {
            return this.response;
        }

        public SmartQuoteQueryResultServiceResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
