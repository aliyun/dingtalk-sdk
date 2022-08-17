// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAppOrderRequest extends TeaModel {
    // 实际金额，单位分。
    @NameInMap("actualAmount")
    public Long actualAmount;

    // 应用id。
    @NameInMap("appId")
    public String appId;

    // 业务编码。
    @NameInMap("bizCode")
    public Integer bizCode;

    // 订单明细列表。
    @NameInMap("detailList")
    public java.util.List<CreateAppOrderRequestDetailList> detailList;

    // 标签金额，单位分。
    @NameInMap("labelAmount")
    public Long labelAmount;

    // 商户id。
    @NameInMap("merchantId")
    public String merchantId;

    // 商户订单号。
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    // 签名。
    @NameInMap("signature")
    public String signature;

    // 订单标题。
    @NameInMap("subject")
    public String subject;

    // 时间戳。
    @NameInMap("timestamp")
    public Long timestamp;

    // 用户唯一id。
    @NameInMap("userId")
    public String userId;

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

    public CreateAppOrderRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
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

    public CreateAppOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CreateAppOrderRequestDetailList extends TeaModel {
        // 扩展字段。
        @NameInMap("feature")
        public String feature;

        // 商品id。
        @NameInMap("goodsId")
        public String goodsId;

        // 商品名称。
        @NameInMap("goodsName")
        public String goodsName;

        // 商品价格，单位分。
        @NameInMap("goodsPrice")
        public Long goodsPrice;

        // 商品数量。
        @NameInMap("goodsQuantity")
        public Integer goodsQuantity;

        public static CreateAppOrderRequestDetailList build(java.util.Map<String, ?> map) throws Exception {
            CreateAppOrderRequestDetailList self = new CreateAppOrderRequestDetailList();
            return TeaModel.build(map, self);
        }

        public CreateAppOrderRequestDetailList setFeature(String feature) {
            this.feature = feature;
            return this;
        }
        public String getFeature() {
            return this.feature;
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
