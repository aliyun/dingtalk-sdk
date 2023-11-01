// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ContractBenefitConsumeResponseBody extends TeaModel {
    @NameInMap("result")
    public ContractBenefitConsumeResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ContractBenefitConsumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ContractBenefitConsumeResponseBody self = new ContractBenefitConsumeResponseBody();
        return TeaModel.build(map, self);
    }

    public ContractBenefitConsumeResponseBody setResult(ContractBenefitConsumeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ContractBenefitConsumeResponseBodyResult getResult() {
        return this.result;
    }

    public ContractBenefitConsumeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ContractBenefitConsumeResponseBodyResult extends TeaModel {
        @NameInMap("consumeResult")
        public Boolean consumeResult;

        public static ContractBenefitConsumeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ContractBenefitConsumeResponseBodyResult self = new ContractBenefitConsumeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ContractBenefitConsumeResponseBodyResult setConsumeResult(Boolean consumeResult) {
            this.consumeResult = consumeResult;
            return this;
        }
        public Boolean getConsumeResult() {
            return this.consumeResult;
        }

    }

}
