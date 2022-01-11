// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateReceiptResponseBody extends TeaModel {
    // 结果列表
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
        // 数据唯一编号
        @NameInMap("code")
        public String code;

        // 错误码
        @NameInMap("errorCode")
        public String errorCode;

        // 错误信息
        @NameInMap("errorMsg")
        public String errorMsg;

        // 是否成功
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
