// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewBenefitResponseBody extends TeaModel {
    @NameInMap("result")
    public GetContractReviewBenefitResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetContractReviewBenefitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewBenefitResponseBody self = new GetContractReviewBenefitResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContractReviewBenefitResponseBody setResult(GetContractReviewBenefitResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetContractReviewBenefitResponseBodyResult getResult() {
        return this.result;
    }

    public GetContractReviewBenefitResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetContractReviewBenefitResponseBodyResultBenefitResponses extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("restBenefit")
        public Long restBenefit;

        @NameInMap("usedBenefit")
        public Long usedBenefit;

        public static GetContractReviewBenefitResponseBodyResultBenefitResponses build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewBenefitResponseBodyResultBenefitResponses self = new GetContractReviewBenefitResponseBodyResultBenefitResponses();
            return TeaModel.build(map, self);
        }

        public GetContractReviewBenefitResponseBodyResultBenefitResponses setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetContractReviewBenefitResponseBodyResultBenefitResponses setRestBenefit(Long restBenefit) {
            this.restBenefit = restBenefit;
            return this;
        }
        public Long getRestBenefit() {
            return this.restBenefit;
        }

        public GetContractReviewBenefitResponseBodyResultBenefitResponses setUsedBenefit(Long usedBenefit) {
            this.usedBenefit = usedBenefit;
            return this;
        }
        public Long getUsedBenefit() {
            return this.usedBenefit;
        }

    }

    public static class GetContractReviewBenefitResponseBodyResult extends TeaModel {
        @NameInMap("benefitResponses")
        public java.util.List<GetContractReviewBenefitResponseBodyResultBenefitResponses> benefitResponses;

        public static GetContractReviewBenefitResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewBenefitResponseBodyResult self = new GetContractReviewBenefitResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetContractReviewBenefitResponseBodyResult setBenefitResponses(java.util.List<GetContractReviewBenefitResponseBodyResultBenefitResponses> benefitResponses) {
            this.benefitResponses = benefitResponses;
            return this;
        }
        public java.util.List<GetContractReviewBenefitResponseBodyResultBenefitResponses> getBenefitResponses() {
            return this.benefitResponses;
        }

    }

}
