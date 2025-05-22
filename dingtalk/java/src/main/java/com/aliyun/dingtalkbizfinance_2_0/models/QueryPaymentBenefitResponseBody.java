// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentBenefitResponseBody extends TeaModel {
    @NameInMap("benefitMap")
    public java.util.Map<String, BenefitMapValue> benefitMap;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("status")
    public String status;

    public static QueryPaymentBenefitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentBenefitResponseBody self = new QueryPaymentBenefitResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPaymentBenefitResponseBody setBenefitMap(java.util.Map<String, BenefitMapValue> benefitMap) {
        this.benefitMap = benefitMap;
        return this;
    }
    public java.util.Map<String, BenefitMapValue> getBenefitMap() {
        return this.benefitMap;
    }

    public QueryPaymentBenefitResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryPaymentBenefitResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryPaymentBenefitResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
