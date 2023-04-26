// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListOrderResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListOrderResponseBodyList> list;

    @NameInMap("total")
    public Long total;

    public static ListOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOrderResponseBody self = new ListOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOrderResponseBody setList(java.util.List<ListOrderResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListOrderResponseBodyList> getList() {
        return this.list;
    }

    public ListOrderResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class ListOrderResponseBodyList extends TeaModel {
        @NameInMap("actualAmount")
        public Long actualAmount;

        @NameInMap("buyerId")
        public String buyerId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("orderNo")
        public String orderNo;

        @NameInMap("payTime")
        public Long payTime;

        @NameInMap("refundNo")
        public String refundNo;

        @NameInMap("scene")
        public Long scene;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Long status;

        @NameInMap("tradeNo")
        public String tradeNo;

        @NameInMap("userId")
        public String userId;

        public static ListOrderResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListOrderResponseBodyList self = new ListOrderResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListOrderResponseBodyList setActualAmount(Long actualAmount) {
            this.actualAmount = actualAmount;
            return this;
        }
        public Long getActualAmount() {
            return this.actualAmount;
        }

        public ListOrderResponseBodyList setBuyerId(String buyerId) {
            this.buyerId = buyerId;
            return this;
        }
        public String getBuyerId() {
            return this.buyerId;
        }

        public ListOrderResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListOrderResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public ListOrderResponseBodyList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public ListOrderResponseBodyList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public ListOrderResponseBodyList setPayTime(Long payTime) {
            this.payTime = payTime;
            return this;
        }
        public Long getPayTime() {
            return this.payTime;
        }

        public ListOrderResponseBodyList setRefundNo(String refundNo) {
            this.refundNo = refundNo;
            return this;
        }
        public String getRefundNo() {
            return this.refundNo;
        }

        public ListOrderResponseBodyList setScene(Long scene) {
            this.scene = scene;
            return this;
        }
        public Long getScene() {
            return this.scene;
        }

        public ListOrderResponseBodyList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public ListOrderResponseBodyList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public ListOrderResponseBodyList setTradeNo(String tradeNo) {
            this.tradeNo = tradeNo;
            return this;
        }
        public String getTradeNo() {
            return this.tradeNo;
        }

        public ListOrderResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
