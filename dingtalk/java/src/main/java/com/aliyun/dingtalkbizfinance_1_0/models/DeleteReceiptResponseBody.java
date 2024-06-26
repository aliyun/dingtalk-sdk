// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class DeleteReceiptResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("results")
    public java.util.List<DeleteReceiptResponseBodyResults> results;

    public static DeleteReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteReceiptResponseBody self = new DeleteReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteReceiptResponseBody setResults(java.util.List<DeleteReceiptResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<DeleteReceiptResponseBodyResults> getResults() {
        return this.results;
    }

    public static class DeleteReceiptResponseBodyResults extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abcd_efgh</p>
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

        public static DeleteReceiptResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            DeleteReceiptResponseBodyResults self = new DeleteReceiptResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public DeleteReceiptResponseBodyResults setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public DeleteReceiptResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public DeleteReceiptResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public DeleteReceiptResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
