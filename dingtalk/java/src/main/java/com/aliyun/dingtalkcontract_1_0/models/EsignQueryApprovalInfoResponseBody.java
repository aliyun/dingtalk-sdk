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
        /**
         * <strong>example:</strong>
         * <p>202311081619000455501</p>
         */
        @NameInMap("bpmsProcessBusinessId")
        public String bpmsProcessBusinessId;

        /**
         * <strong>example:</strong>
         * <p>O6wNhB4wTMajvNW8Dc_Rjg09301699431585</p>
         */
        @NameInMap("bpmsProcessInstanceId")
        public String bpmsProcessInstanceId;

        /**
         * <strong>example:</strong>
         * <p><a href="https://aflow.dingtalk.com/dingtalk/pc/query/pchomepage.htm?corpid=ding6c3948a9e37c439c35c2f4657eb6378f&swfrom=https://n.dingtalk.com/dingding/h5-contract/contractPC/index.html#/approval?procInstId=O6wNhB4wTMajvNW8Dc_Rjg09301699431585">https://aflow.dingtalk.com/dingtalk/pc/query/pchomepage.htm?corpid=ding6c3948a9e37c439c35c2f4657eb6378f&amp;swfrom=https://n.dingtalk.com/dingding/h5-contract/contractPC/index.html#/approval?procInstId=O6wNhB4wTMajvNW8Dc_Rjg09301699431585</a></p>
         */
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
