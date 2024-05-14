// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ConsumeUserPointsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("amount")
    public Long amount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outId")
    public String outId;

    @NameInMap("remark")
    public String remark;

    @NameInMap("usage")
    public String usage;

    public static ConsumeUserPointsRequest build(java.util.Map<String, ?> map) throws Exception {
        ConsumeUserPointsRequest self = new ConsumeUserPointsRequest();
        return TeaModel.build(map, self);
    }

    public ConsumeUserPointsRequest setAmount(Long amount) {
        this.amount = amount;
        return this;
    }
    public Long getAmount() {
        return this.amount;
    }

    public ConsumeUserPointsRequest setOutId(String outId) {
        this.outId = outId;
        return this;
    }
    public String getOutId() {
        return this.outId;
    }

    public ConsumeUserPointsRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public ConsumeUserPointsRequest setUsage(String usage) {
        this.usage = usage;
        return this;
    }
    public String getUsage() {
        return this.usage;
    }

}
