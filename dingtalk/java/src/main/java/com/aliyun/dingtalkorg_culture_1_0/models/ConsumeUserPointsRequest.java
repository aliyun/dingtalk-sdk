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

}
