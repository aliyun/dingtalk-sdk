// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryApprovalInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public EsignQueryApprovalInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static EsignQueryApprovalInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryApprovalInfoResponseBody self = new EsignQueryApprovalInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public EsignQueryApprovalInfoResponseBody setResult(EsignQueryApprovalInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EsignQueryApprovalInfoResponseBodyResult getResult() {
        return this.result;
    }

    public EsignQueryApprovalInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class EsignQueryApprovalInfoResponseBodyResult extends TeaModel {
        @NameInMap("bpmsProcessBusinessId")
        public String bpmsProcessBusinessId;

        @NameInMap("bpmsProcessInstanceId")
        public String bpmsProcessInstanceId;

        @NameInMap("bpmsProcessInstanceUrl")
        public String bpmsProcessInstanceUrl;

        public static EsignQueryApprovalInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EsignQueryApprovalInfoResponseBodyResult self = new EsignQueryApprovalInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EsignQueryApprovalInfoResponseBodyResult setBpmsProcessBusinessId(String bpmsProcessBusinessId) {
            this.bpmsProcessBusinessId = bpmsProcessBusinessId;
            return this;
        }
        public String getBpmsProcessBusinessId() {
            return this.bpmsProcessBusinessId;
        }

        public EsignQueryApprovalInfoResponseBodyResult setBpmsProcessInstanceId(String bpmsProcessInstanceId) {
            this.bpmsProcessInstanceId = bpmsProcessInstanceId;
            return this;
        }
        public String getBpmsProcessInstanceId() {
            return this.bpmsProcessInstanceId;
        }

        public EsignQueryApprovalInfoResponseBodyResult setBpmsProcessInstanceUrl(String bpmsProcessInstanceUrl) {
            this.bpmsProcessInstanceUrl = bpmsProcessInstanceUrl;
            return this;
        }
        public String getBpmsProcessInstanceUrl() {
            return this.bpmsProcessInstanceUrl;
        }

    }

}
