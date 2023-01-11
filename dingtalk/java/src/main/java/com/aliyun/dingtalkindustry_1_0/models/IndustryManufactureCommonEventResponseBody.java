// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCommonEventResponseBody extends TeaModel {
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public IndustryManufactureCommonEventResponseBodyResult result;

    public static IndustryManufactureCommonEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureCommonEventResponseBody self = new IndustryManufactureCommonEventResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureCommonEventResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public IndustryManufactureCommonEventResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public IndustryManufactureCommonEventResponseBody setResult(IndustryManufactureCommonEventResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureCommonEventResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureCommonEventResponseBodyResult extends TeaModel {
        /**
         * <p>返回内容</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>状态码</p>
         */
        @NameInMap("httpCode")
        public String httpCode;

        public static IndustryManufactureCommonEventResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureCommonEventResponseBodyResult self = new IndustryManufactureCommonEventResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureCommonEventResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public IndustryManufactureCommonEventResponseBodyResult setHttpCode(String httpCode) {
            this.httpCode = httpCode;
            return this;
        }
        public String getHttpCode() {
            return this.httpCode;
        }

    }

}
