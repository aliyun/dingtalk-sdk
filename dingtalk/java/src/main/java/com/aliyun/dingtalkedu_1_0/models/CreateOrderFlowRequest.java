// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateOrderFlowRequest extends TeaModel {
    @NameInMap("actualAmount")
    public Long actualAmount;

    @NameInMap("alipayUid")
    public String alipayUid;

    @NameInMap("createTime")
    public Long createTime;

    @NameInMap("detailList")
    public java.util.List<CreateOrderFlowRequestDetailList> detailList;

    @NameInMap("faceId")
    public String faceId;

    @NameInMap("guardianUserId")
    public String guardianUserId;

    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("signature")
    public String signature;

    @NameInMap("sn")
    public String sn;

    @NameInMap("timestamp")
    public Long timestamp;

    @NameInMap("totalAmount")
    public Long totalAmount;

    @NameInMap("userId")
    public String userId;

    public static CreateOrderFlowRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateOrderFlowRequest self = new CreateOrderFlowRequest();
        return TeaModel.build(map, self);
    }

    public CreateOrderFlowRequest setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CreateOrderFlowRequest setAlipayUid(String alipayUid) {
        this.alipayUid = alipayUid;
        return this;
    }
    public String getAlipayUid() {
        return this.alipayUid;
    }

    public CreateOrderFlowRequest setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public CreateOrderFlowRequest setDetailList(java.util.List<CreateOrderFlowRequestDetailList> detailList) {
        this.detailList = detailList;
        return this;
    }
    public java.util.List<CreateOrderFlowRequestDetailList> getDetailList() {
        return this.detailList;
    }

    public CreateOrderFlowRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public CreateOrderFlowRequest setGuardianUserId(String guardianUserId) {
        this.guardianUserId = guardianUserId;
        return this;
    }
    public String getGuardianUserId() {
        return this.guardianUserId;
    }

    public CreateOrderFlowRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CreateOrderFlowRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CreateOrderFlowRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CreateOrderFlowRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CreateOrderFlowRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public CreateOrderFlowRequest setTotalAmount(Long totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public Long getTotalAmount() {
        return this.totalAmount;
    }

    public CreateOrderFlowRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CreateOrderFlowRequestDetailList extends TeaModel {
        @NameInMap("actualAmount")
        public Long actualAmount;

        @NameInMap("itemAmount")
        public Long itemAmount;

        @NameInMap("itemId")
        public Long itemId;

        @NameInMap("itemName")
        public String itemName;

        @NameInMap("scene")
        public Long scene;

        public static CreateOrderFlowRequestDetailList build(java.util.Map<String, ?> map) throws Exception {
            CreateOrderFlowRequestDetailList self = new CreateOrderFlowRequestDetailList();
            return TeaModel.build(map, self);
        }

        public CreateOrderFlowRequestDetailList setActualAmount(Long actualAmount) {
            this.actualAmount = actualAmount;
            return this;
        }
        public Long getActualAmount() {
            return this.actualAmount;
        }

        public CreateOrderFlowRequestDetailList setItemAmount(Long itemAmount) {
            this.itemAmount = itemAmount;
            return this;
        }
        public Long getItemAmount() {
            return this.itemAmount;
        }

        public CreateOrderFlowRequestDetailList setItemId(Long itemId) {
            this.itemId = itemId;
            return this;
        }
        public Long getItemId() {
            return this.itemId;
        }

        public CreateOrderFlowRequestDetailList setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

        public CreateOrderFlowRequestDetailList setScene(Long scene) {
            this.scene = scene;
            return this;
        }
        public Long getScene() {
            return this.scene;
        }

    }

}
