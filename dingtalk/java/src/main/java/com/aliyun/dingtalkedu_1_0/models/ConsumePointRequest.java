// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ConsumePointRequest extends TeaModel {
    /**
     * <p>扣减积分</p>
     */
    @NameInMap("amount")
    public Long amount;

    /**
     * <p>业务id</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>扣减描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>产品编码</p>
     */
    @NameInMap("productCode")
    public String productCode;

    public static ConsumePointRequest build(java.util.Map<String, ?> map) throws Exception {
        ConsumePointRequest self = new ConsumePointRequest();
        return TeaModel.build(map, self);
    }

    public ConsumePointRequest setAmount(Long amount) {
        this.amount = amount;
        return this;
    }
    public Long getAmount() {
        return this.amount;
    }

    public ConsumePointRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ConsumePointRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public ConsumePointRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

}
