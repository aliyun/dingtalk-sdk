// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ConsumeUserPointsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("amount")
    public Long amount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qwe123</p>
     */
    @NameInMap("outId")
    public String outId;

    /**
     * <strong>example:</strong>
     * <p>测试积分扣减</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <strong>example:</strong>
     * <p>OPEN_EMP_POINT_CONSUME_DEFAULT</p>
     */
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
