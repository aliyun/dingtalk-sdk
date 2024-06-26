// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ContractBenefitConsumeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>esign</p>
     */
    @NameInMap("benefitPoint")
    public String benefitPoint;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sjdaujii129w9qej2nqas</p>
     */
    @NameInMap("bizRequestId")
    public String bizRequestId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("consumeQuota")
    public Long consumeQuota;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding1231ndu29923312</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extParams")
    public java.util.Map<String, String> extParams;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding12939912nduaejjwe</p>
     */
    @NameInMap("isvCorpId")
    public String isvCorpId;

    /**
     * <strong>example:</strong>
     * <p>djauihjauiwnkndjknkjanaae</p>
     */
    @NameInMap("optUnionId")
    public String optUnionId;

    public static ContractBenefitConsumeRequest build(java.util.Map<String, ?> map) throws Exception {
        ContractBenefitConsumeRequest self = new ContractBenefitConsumeRequest();
        return TeaModel.build(map, self);
    }

    public ContractBenefitConsumeRequest setBenefitPoint(String benefitPoint) {
        this.benefitPoint = benefitPoint;
        return this;
    }
    public String getBenefitPoint() {
        return this.benefitPoint;
    }

    public ContractBenefitConsumeRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public ContractBenefitConsumeRequest setConsumeQuota(Long consumeQuota) {
        this.consumeQuota = consumeQuota;
        return this;
    }
    public Long getConsumeQuota() {
        return this.consumeQuota;
    }

    public ContractBenefitConsumeRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public ContractBenefitConsumeRequest setExtParams(java.util.Map<String, String> extParams) {
        this.extParams = extParams;
        return this;
    }
    public java.util.Map<String, String> getExtParams() {
        return this.extParams;
    }

    public ContractBenefitConsumeRequest setIsvCorpId(String isvCorpId) {
        this.isvCorpId = isvCorpId;
        return this;
    }
    public String getIsvCorpId() {
        return this.isvCorpId;
    }

    public ContractBenefitConsumeRequest setOptUnionId(String optUnionId) {
        this.optUnionId = optUnionId;
        return this;
    }
    public String getOptUnionId() {
        return this.optUnionId;
    }

}
