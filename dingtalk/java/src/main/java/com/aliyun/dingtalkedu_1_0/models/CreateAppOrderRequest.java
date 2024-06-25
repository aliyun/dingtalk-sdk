// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAppOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("bizCode")
    public Integer bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detailList")
    public java.util.List<CreateAppOrderRequestDetailList> detailList;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("labelAmount")
    public Long labelAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>M00001</p>
     */
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("outerUserId")
    public String outerUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>WWrhziOLF/XuRd3IyKwLkLeSFgKnUfeg2yLEVD9Bw+8</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>数字图书</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100000</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    public static CreateAppOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAppOrderRequest self = new CreateAppOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreateAppOrderRequest setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CreateAppOrderRequest setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public CreateAppOrderRequest setBizCode(Integer bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public Integer getBizCode() {
        return this.bizCode;
    }

    public CreateAppOrderRequest setDetailList(java.util.List<CreateAppOrderRequestDetailList> detailList) {
        this.detailList = detailList;
        return this;
    }
    public java.util.List<CreateAppOrderRequestDetailList> getDetailList() {
        return this.detailList;
    }

    public CreateAppOrderRequest setLabelAmount(Long labelAmount) {
        this.labelAmount = labelAmount;
        return this;
    }
    public Long getLabelAmount() {
        return this.labelAmount;
    }

    public CreateAppOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CreateAppOrderRequest setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public CreateAppOrderRequest setOuterUserId(String outerUserId) {
        this.outerUserId = outerUserId;
        return this;
    }
    public String getOuterUserId() {
        return this.outerUserId;
    }

    public CreateAppOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CreateAppOrderRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public CreateAppOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public static class CreateAppOrderRequestDetailList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234000</p>
         */
        @NameInMap("goodsId")
        public String goodsId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>绘画图书</p>
         */
        @NameInMap("goodsName")
        public String goodsName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("goodsPrice")
        public Long goodsPrice;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("goodsQuantity")
        public Integer goodsQuantity;

        public static CreateAppOrderRequestDetailList build(java.util.Map<String, ?> map) throws Exception {
            CreateAppOrderRequestDetailList self = new CreateAppOrderRequestDetailList();
            return TeaModel.build(map, self);
        }

        public CreateAppOrderRequestDetailList setGoodsId(String goodsId) {
            this.goodsId = goodsId;
            return this;
        }
        public String getGoodsId() {
            return this.goodsId;
        }

        public CreateAppOrderRequestDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public CreateAppOrderRequestDetailList setGoodsPrice(Long goodsPrice) {
            this.goodsPrice = goodsPrice;
            return this;
        }
        public Long getGoodsPrice() {
            return this.goodsPrice;
        }

        public CreateAppOrderRequestDetailList setGoodsQuantity(Integer goodsQuantity) {
            this.goodsQuantity = goodsQuantity;
            return this;
        }
        public Integer getGoodsQuantity() {
            return this.goodsQuantity;
        }

    }

}
