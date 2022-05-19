// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ConsumeUserPointsRequest extends TeaModel {
    // 扣减积分数量，1～1000000
    @NameInMap("amount")
    public Long amount;

    // 幂等外部ID，最大长度32个字符
    @NameInMap("outId")
    public String outId;

    // 备注，最长32个字符
    @NameInMap("remark")
    public String remark;

    // 用途，可用值：OPEN_EMP_POINT_CONSUME_DEFAULT-默认扣减，OPEN_EMP_POINT_PUNISH_CONSUME-惩罚扣减；默认为: OPEN_EMP_POINT_CONSUME_DEFAULT
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
