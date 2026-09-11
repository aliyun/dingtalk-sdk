// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryA1IndustryDeviceBindingResponseBody extends TeaModel {
    @NameInMap("result")
    public BatchQueryA1IndustryDeviceBindingResponseBodyResult result;

    public static BatchQueryA1IndustryDeviceBindingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryA1IndustryDeviceBindingResponseBody self = new BatchQueryA1IndustryDeviceBindingResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryA1IndustryDeviceBindingResponseBody setResult(BatchQueryA1IndustryDeviceBindingResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchQueryA1IndustryDeviceBindingResponseBodyResult getResult() {
        return this.result;
    }

    public static class BatchQueryA1IndustryDeviceBindingResponseBodyResultResults extends TeaModel {
        @NameInMap("bindTimestamp")
        public Long bindTimestamp;

        @NameInMap("bindingStatus")
        public String bindingStatus;

        @NameInMap("errorCode")
        public Integer errorCode;

        @NameInMap("errorMessage")
        public String errorMessage;

        @NameInMap("sn")
        public String sn;

        @NameInMap("success")
        public Boolean success;

        @NameInMap("unionId")
        public String unionId;

        public static BatchQueryA1IndustryDeviceBindingResponseBodyResultResults build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryA1IndustryDeviceBindingResponseBodyResultResults self = new BatchQueryA1IndustryDeviceBindingResponseBodyResultResults();
            return TeaModel.build(map, self);
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResultResults setBindTimestamp(Long bindTimestamp) {
            this.bindTimestamp = bindTimestamp;
            return this;
        }
        public Long getBindTimestamp() {
            return this.bindTimestamp;
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResultResults setBindingStatus(String bindingStatus) {
            this.bindingStatus = bindingStatus;
            return this;
        }
        public String getBindingStatus() {
            return this.bindingStatus;
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResultResults setErrorCode(Integer errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public Integer getErrorCode() {
            return this.errorCode;
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResultResults setErrorMessage(String errorMessage) {
            this.errorMessage = errorMessage;
            return this;
        }
        public String getErrorMessage() {
            return this.errorMessage;
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResultResults setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResultResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResultResults setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class BatchQueryA1IndustryDeviceBindingResponseBodyResult extends TeaModel {
        @NameInMap("partialSuccess")
        public Boolean partialSuccess;

        @NameInMap("results")
        public java.util.List<BatchQueryA1IndustryDeviceBindingResponseBodyResultResults> results;

        public static BatchQueryA1IndustryDeviceBindingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryA1IndustryDeviceBindingResponseBodyResult self = new BatchQueryA1IndustryDeviceBindingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResult setPartialSuccess(Boolean partialSuccess) {
            this.partialSuccess = partialSuccess;
            return this;
        }
        public Boolean getPartialSuccess() {
            return this.partialSuccess;
        }

        public BatchQueryA1IndustryDeviceBindingResponseBodyResult setResults(java.util.List<BatchQueryA1IndustryDeviceBindingResponseBodyResultResults> results) {
            this.results = results;
            return this;
        }
        public java.util.List<BatchQueryA1IndustryDeviceBindingResponseBodyResultResults> getResults() {
            return this.results;
        }

    }

}
