// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreatePayableReceiptResponseBody extends TeaModel {
    @NameInMap("result")
    public CreatePayableReceiptResponseBodyResult result;

    public static CreatePayableReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreatePayableReceiptResponseBody self = new CreatePayableReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public CreatePayableReceiptResponseBody setResult(CreatePayableReceiptResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreatePayableReceiptResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreatePayableReceiptResponseBodyResult extends TeaModel {
        @NameInMap("businessId")
        public String businessId;

        @NameInMap("code")
        public String code;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("success")
        public Boolean success;

        @NameInMap("url")
        public String url;

        public static CreatePayableReceiptResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreatePayableReceiptResponseBodyResult self = new CreatePayableReceiptResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreatePayableReceiptResponseBodyResult setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public CreatePayableReceiptResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreatePayableReceiptResponseBodyResult setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public CreatePayableReceiptResponseBodyResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public CreatePayableReceiptResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public CreatePayableReceiptResponseBodyResult setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
