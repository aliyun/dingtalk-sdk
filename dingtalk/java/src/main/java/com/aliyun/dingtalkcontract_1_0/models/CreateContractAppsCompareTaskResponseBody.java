// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsCompareTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractAppsCompareTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractAppsCompareTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsCompareTaskResponseBody self = new CreateContractAppsCompareTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsCompareTaskResponseBody setResult(CreateContractAppsCompareTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractAppsCompareTaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractAppsCompareTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractAppsCompareTaskResponseBodyResultData extends TeaModel {
        @NameInMap("compareTaskId")
        public String compareTaskId;

        public static CreateContractAppsCompareTaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsCompareTaskResponseBodyResultData self = new CreateContractAppsCompareTaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsCompareTaskResponseBodyResultData setCompareTaskId(String compareTaskId) {
            this.compareTaskId = compareTaskId;
            return this;
        }
        public String getCompareTaskId() {
            return this.compareTaskId;
        }

    }

    public static class CreateContractAppsCompareTaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateContractAppsCompareTaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateContractAppsCompareTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsCompareTaskResponseBodyResult self = new CreateContractAppsCompareTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsCompareTaskResponseBodyResult setData(CreateContractAppsCompareTaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateContractAppsCompareTaskResponseBodyResultData getData() {
            return this.data;
        }

        public CreateContractAppsCompareTaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
