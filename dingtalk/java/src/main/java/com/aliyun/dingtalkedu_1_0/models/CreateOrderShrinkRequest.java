// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateOrderShrinkRequest extends TeaModel {
    // 实付金额（优惠计算后）
    @NameInMap("actualAmount")
    public Long actualAmount;

    // 订单明细信息，来源于商户系统或APP的商品信息。
    @NameInMap("detailList")
    public String detailListShrink;

    // 录脸token
    @NameInMap("ftoken")
    public String ftoken;

    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // 交易加签
    @NameInMap("terminalParams")
    public String terminalParams;

    // 应付价格
    @NameInMap("totalAmount")
    public Long totalAmount;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static CreateOrderShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateOrderShrinkRequest self = new CreateOrderShrinkRequest();
        return TeaModel.build(map, self);
    }

    public CreateOrderShrinkRequest setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CreateOrderShrinkRequest setDetailListShrink(String detailListShrink) {
        this.detailListShrink = detailListShrink;
        return this;
    }
    public String getDetailListShrink() {
        return this.detailListShrink;
    }

    public CreateOrderShrinkRequest setFtoken(String ftoken) {
        this.ftoken = ftoken;
        return this;
    }
    public String getFtoken() {
        return this.ftoken;
    }

    public CreateOrderShrinkRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CreateOrderShrinkRequest setTerminalParams(String terminalParams) {
        this.terminalParams = terminalParams;
        return this;
    }
    public String getTerminalParams() {
        return this.terminalParams;
    }

    public CreateOrderShrinkRequest setTotalAmount(Long totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public Long getTotalAmount() {
        return this.totalAmount;
    }

    public CreateOrderShrinkRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
