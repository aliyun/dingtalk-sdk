// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateReceiptResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("results")
    public java.util.List<CreateReceiptResponseBodyResults> results;

    public static CreateReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateReceiptResponseBody self = new CreateReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateReceiptResponseBody setResults(java.util.List<CreateReceiptResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<CreateReceiptResponseBodyResults> getResults() {
        return this.results;
    }

    public static class CreateReceiptResponseBodyResults extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abcef-efgh-123</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>success</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <strong>example:</strong>
         * <p>成功</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static CreateReceiptResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            CreateReceiptResponseBodyResults self = new CreateReceiptResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public CreateReceiptResponseBodyResults setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreateReceiptResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public CreateReceiptResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public CreateReceiptResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
