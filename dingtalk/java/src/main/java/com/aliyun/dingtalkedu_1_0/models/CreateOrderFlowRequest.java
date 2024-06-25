// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateOrderFlowRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <strong>example:</strong>
     * <p>2088112532248965</p>
     */
    @NameInMap("alipayUid")
    public String alipayUid;

    /**
     * <strong>example:</strong>
     * <p>1644413947909</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detailList")
    public java.util.List<CreateOrderFlowRequestDetailList> detailList;

    /**
     * <strong>example:</strong>
     * <p>123123</p>
     */
    @NameInMap("faceId")
    public String faceId;

    /**
     * <strong>example:</strong>
     * <p>123455</p>
     */
    @NameInMap("guardianUserId")
    public String guardianUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2088821434894708</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2022012717252021400100822002</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <strong>example:</strong>
     * <p>KSwZiSL1O7DiUNwjV168j3cP9ktp4bJTi5OQxAXre26KyBXza7+gCl/g1d0K3n3+9JhMqc2fUjBiENcAELw3Jb5xO/zslOeV4qFoMQfzW51+sdL/SSZCYvXEMhu9P6FAPhGZQ3vu6gr3oxUAXPIpWNb+sIfzR9epumoOXYeofH8=</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <strong>example:</strong>
     * <p>QA62021121908E</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <strong>example:</strong>
     * <p>1644413947909</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalAmount")
    public Long totalAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1643334234626</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("actualAmount")
        public Long actualAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("itemAmount")
        public Long itemAmount;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("itemId")
        public Long itemId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>测试商品</p>
         */
        @NameInMap("itemName")
        public String itemName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
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
