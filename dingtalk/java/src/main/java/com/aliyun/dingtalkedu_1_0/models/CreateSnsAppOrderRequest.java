// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSnsAppOrderRequest extends TeaModel {
    /**
     * <p>实际金额，单位分。</p>
     */
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <p>支付宝应用id。</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <p>业务编码。</p>
     */
    @NameInMap("bizCode")
    public Integer bizCode;

    /**
     * <p>订单明细列表。</p>
     */
    @NameInMap("detailList")
    public java.util.List<CreateSnsAppOrderRequestDetailList> detailList;

    /**
     * <p>标签金额，单位分。</p>
     */
    @NameInMap("labelAmount")
    public Long labelAmount;

    /**
     * <p>商户id。</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>商户订单号。</p>
     */
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    /**
     * <p>签名。</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>订单标题。</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <p>时间戳。</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    public static CreateSnsAppOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSnsAppOrderRequest self = new CreateSnsAppOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreateSnsAppOrderRequest setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CreateSnsAppOrderRequest setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public CreateSnsAppOrderRequest setBizCode(Integer bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public Integer getBizCode() {
        return this.bizCode;
    }

    public CreateSnsAppOrderRequest setDetailList(java.util.List<CreateSnsAppOrderRequestDetailList> detailList) {
        this.detailList = detailList;
        return this;
    }
    public java.util.List<CreateSnsAppOrderRequestDetailList> getDetailList() {
        return this.detailList;
    }

    public CreateSnsAppOrderRequest setLabelAmount(Long labelAmount) {
        this.labelAmount = labelAmount;
        return this;
    }
    public Long getLabelAmount() {
        return this.labelAmount;
    }

    public CreateSnsAppOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CreateSnsAppOrderRequest setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public CreateSnsAppOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CreateSnsAppOrderRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public CreateSnsAppOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public static class CreateSnsAppOrderRequestDetailList extends TeaModel {
        /**
         * <p>商品id。</p>
         */
        @NameInMap("goodsId")
        public String goodsId;

        /**
         * <p>商品名称。</p>
         */
        @NameInMap("goodsName")
        public String goodsName;

        /**
         * <p>商品价格，单位分。</p>
         */
        @NameInMap("goodsPrice")
        public Long goodsPrice;

        /**
         * <p>商品数量。</p>
         */
        @NameInMap("goodsQuantity")
        public Integer goodsQuantity;

        public static CreateSnsAppOrderRequestDetailList build(java.util.Map<String, ?> map) throws Exception {
            CreateSnsAppOrderRequestDetailList self = new CreateSnsAppOrderRequestDetailList();
            return TeaModel.build(map, self);
        }

        public CreateSnsAppOrderRequestDetailList setGoodsId(String goodsId) {
            this.goodsId = goodsId;
            return this;
        }
        public String getGoodsId() {
            return this.goodsId;
        }

        public CreateSnsAppOrderRequestDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public CreateSnsAppOrderRequestDetailList setGoodsPrice(Long goodsPrice) {
            this.goodsPrice = goodsPrice;
            return this;
        }
        public Long getGoodsPrice() {
            return this.goodsPrice;
        }

        public CreateSnsAppOrderRequestDetailList setGoodsQuantity(Integer goodsQuantity) {
            this.goodsQuantity = goodsQuantity;
            return this;
        }
        public Integer getGoodsQuantity() {
            return this.goodsQuantity;
        }

    }

}
