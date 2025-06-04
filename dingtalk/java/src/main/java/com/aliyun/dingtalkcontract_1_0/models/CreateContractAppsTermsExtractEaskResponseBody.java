// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsTermsExtractEaskResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractAppsTermsExtractEaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractAppsTermsExtractEaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsTermsExtractEaskResponseBody self = new CreateContractAppsTermsExtractEaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsTermsExtractEaskResponseBody setResult(CreateContractAppsTermsExtractEaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractAppsTermsExtractEaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractAppsTermsExtractEaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractAppsTermsExtractEaskResponseBodyResultData extends TeaModel {
        @NameInMap("extractTaskId")
        public String extractTaskId;

        public static CreateContractAppsTermsExtractEaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsTermsExtractEaskResponseBodyResultData self = new CreateContractAppsTermsExtractEaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsTermsExtractEaskResponseBodyResultData setExtractTaskId(String extractTaskId) {
            this.extractTaskId = extractTaskId;
            return this;
        }
        public String getExtractTaskId() {
            return this.extractTaskId;
        }

    }

    public static class CreateContractAppsTermsExtractEaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateContractAppsTermsExtractEaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateContractAppsTermsExtractEaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsTermsExtractEaskResponseBodyResult self = new CreateContractAppsTermsExtractEaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsTermsExtractEaskResponseBodyResult setData(CreateContractAppsTermsExtractEaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateContractAppsTermsExtractEaskResponseBodyResultData getData() {
            return this.data;
        }

        public CreateContractAppsTermsExtractEaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
