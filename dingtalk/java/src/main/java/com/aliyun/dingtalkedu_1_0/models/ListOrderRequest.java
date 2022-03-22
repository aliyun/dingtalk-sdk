// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListOrderRequest extends TeaModel {
    // 开单结束时间
    @NameInMap("createTimeEnd")
    public Long createTimeEnd;

    // 开单开始时间，utc
    @NameInMap("createTimeStart")
    public Long createTimeStart;

    // 商户id
    @NameInMap("merchantId")
    public String merchantId;

    // 订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 分页下标
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 场景
    @NameInMap("scene")
    public Long scene;

    // 状态
    @NameInMap("status")
    public Long status;

    // 交易单号
    @NameInMap("tradeNo")
    public String tradeNo;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static ListOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        ListOrderRequest self = new ListOrderRequest();
        return TeaModel.build(map, self);
    }

    public ListOrderRequest setCreateTimeEnd(Long createTimeEnd) {
        this.createTimeEnd = createTimeEnd;
        return this;
    }
    public Long getCreateTimeEnd() {
        return this.createTimeEnd;
    }

    public ListOrderRequest setCreateTimeStart(Long createTimeStart) {
        this.createTimeStart = createTimeStart;
        return this;
    }
    public Long getCreateTimeStart() {
        return this.createTimeStart;
    }

    public ListOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public ListOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public ListOrderRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ListOrderRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public ListOrderRequest setScene(Long scene) {
        this.scene = scene;
        return this;
    }
    public Long getScene() {
        return this.scene;
    }

    public ListOrderRequest setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public ListOrderRequest setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

    public ListOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
