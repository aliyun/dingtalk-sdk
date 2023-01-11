// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptResponseBody extends TeaModel {
    /**
     * <p>结果列表</p>
     */
    @NameInMap("results")
    public java.util.List<UpdateReceiptResponseBodyResults> results;

    public static UpdateReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateReceiptResponseBody self = new UpdateReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateReceiptResponseBody setResults(java.util.List<UpdateReceiptResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<UpdateReceiptResponseBodyResults> getResults() {
        return this.results;
    }

    public static class UpdateReceiptResponseBodyResults extends TeaModel {
        /**
         * <p>数据唯一编号</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>错误码</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <p>错误信息</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <p>是否成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static UpdateReceiptResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            UpdateReceiptResponseBodyResults self = new UpdateReceiptResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public UpdateReceiptResponseBodyResults setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public UpdateReceiptResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public UpdateReceiptResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public UpdateReceiptResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
