// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class PurchaseMixViewResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public PurchaseMixViewResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PurchaseMixViewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PurchaseMixViewResponseBody self = new PurchaseMixViewResponseBody();
        return TeaModel.build(map, self);
    }

    public PurchaseMixViewResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public PurchaseMixViewResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public PurchaseMixViewResponseBody setResult(PurchaseMixViewResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PurchaseMixViewResponseBodyResult getResult() {
        return this.result;
    }

    public PurchaseMixViewResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList extends TeaModel {
        @NameInMap("actualPayFee")
        public Double actualPayFee;

        @NameInMap("articleCode")
        public String articleCode;

        @NameInMap("articleItemCode")
        public String articleItemCode;

        @NameInMap("bizTagList")
        public java.util.List<String> bizTagList;

        @NameInMap("endDate")
        public Long endDate;

        @NameInMap("orderType")
        public String orderType;

        @NameInMap("payFee")
        public Double payFee;

        @NameInMap("startDate")
        public Long startDate;

        public static PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList self = new PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setActualPayFee(Double actualPayFee) {
            this.actualPayFee = actualPayFee;
            return this;
        }
        public Double getActualPayFee() {
            return this.actualPayFee;
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setArticleCode(String articleCode) {
            this.articleCode = articleCode;
            return this;
        }
        public String getArticleCode() {
            return this.articleCode;
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setArticleItemCode(String articleItemCode) {
            this.articleItemCode = articleItemCode;
            return this;
        }
        public String getArticleItemCode() {
            return this.articleItemCode;
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setBizTagList(java.util.List<String> bizTagList) {
            this.bizTagList = bizTagList;
            return this;
        }
        public java.util.List<String> getBizTagList() {
            return this.bizTagList;
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setEndDate(Long endDate) {
            this.endDate = endDate;
            return this;
        }
        public Long getEndDate() {
            return this.endDate;
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setOrderType(String orderType) {
            this.orderType = orderType;
            return this;
        }
        public String getOrderType() {
            return this.orderType;
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setPayFee(Double payFee) {
            this.payFee = payFee;
            return this;
        }
        public Double getPayFee() {
            return this.payFee;
        }

        public PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList setStartDate(Long startDate) {
            this.startDate = startDate;
            return this;
        }
        public Long getStartDate() {
            return this.startDate;
        }

    }

    public static class PurchaseMixViewResponseBodyResultMixPromotionVO extends TeaModel {
        @NameInMap("activityId")
        public Long activityId;

        @NameInMap("activityName")
        public String activityName;

        @NameInMap("activityUrl")
        public String activityUrl;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("extendParam")
        public java.util.Map<String, ?> extendParam;

        @NameInMap("forbiddenCoupon")
        public Boolean forbiddenCoupon;

        @NameInMap("isSelected")
        public Boolean isSelected;

        @NameInMap("marketActivityId")
        public Long marketActivityId;

        @NameInMap("promotionId")
        public Long promotionId;

        @NameInMap("promotionName")
        public String promotionName;

        @NameInMap("promotionType")
        public String promotionType;

        @NameInMap("source")
        public String source;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("type")
        public String type;

        public static PurchaseMixViewResponseBodyResultMixPromotionVO build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewResponseBodyResultMixPromotionVO self = new PurchaseMixViewResponseBodyResultMixPromotionVO();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setActivityId(Long activityId) {
            this.activityId = activityId;
            return this;
        }
        public Long getActivityId() {
            return this.activityId;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setActivityUrl(String activityUrl) {
            this.activityUrl = activityUrl;
            return this;
        }
        public String getActivityUrl() {
            return this.activityUrl;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setExtendParam(java.util.Map<String, ?> extendParam) {
            this.extendParam = extendParam;
            return this;
        }
        public java.util.Map<String, ?> getExtendParam() {
            return this.extendParam;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setForbiddenCoupon(Boolean forbiddenCoupon) {
            this.forbiddenCoupon = forbiddenCoupon;
            return this;
        }
        public Boolean getForbiddenCoupon() {
            return this.forbiddenCoupon;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setIsSelected(Boolean isSelected) {
            this.isSelected = isSelected;
            return this;
        }
        public Boolean getIsSelected() {
            return this.isSelected;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setMarketActivityId(Long marketActivityId) {
            this.marketActivityId = marketActivityId;
            return this;
        }
        public Long getMarketActivityId() {
            return this.marketActivityId;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setPromotionId(Long promotionId) {
            this.promotionId = promotionId;
            return this;
        }
        public Long getPromotionId() {
            return this.promotionId;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setPromotionName(String promotionName) {
            this.promotionName = promotionName;
            return this;
        }
        public String getPromotionName() {
            return this.promotionName;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setPromotionType(String promotionType) {
            this.promotionType = promotionType;
            return this;
        }
        public String getPromotionType() {
            return this.promotionType;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public PurchaseMixViewResponseBodyResultMixPromotionVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO extends TeaModel {
        @NameInMap("activityId")
        public Long activityId;

        @NameInMap("couponId")
        public Long couponId;

        public static PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO self = new PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO setActivityId(Long activityId) {
            this.activityId = activityId;
            return this;
        }
        public Long getActivityId() {
            return this.activityId;
        }

        public PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO setCouponId(Long couponId) {
            this.couponId = couponId;
            return this;
        }
        public Long getCouponId() {
            return this.couponId;
        }

    }

    public static class PurchaseMixViewResponseBodyResult extends TeaModel {
        @NameInMap("aliyunArticleItemViewUnitList")
        public java.util.List<PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList> aliyunArticleItemViewUnitList;

        @NameInMap("mixPromotionVO")
        public PurchaseMixViewResponseBodyResultMixPromotionVO mixPromotionVO;

        @NameInMap("recommendedMarketingCollocationDTO")
        public PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO recommendedMarketingCollocationDTO;

        public static PurchaseMixViewResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewResponseBodyResult self = new PurchaseMixViewResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewResponseBodyResult setAliyunArticleItemViewUnitList(java.util.List<PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList> aliyunArticleItemViewUnitList) {
            this.aliyunArticleItemViewUnitList = aliyunArticleItemViewUnitList;
            return this;
        }
        public java.util.List<PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList> getAliyunArticleItemViewUnitList() {
            return this.aliyunArticleItemViewUnitList;
        }

        public PurchaseMixViewResponseBodyResult setMixPromotionVO(PurchaseMixViewResponseBodyResultMixPromotionVO mixPromotionVO) {
            this.mixPromotionVO = mixPromotionVO;
            return this;
        }
        public PurchaseMixViewResponseBodyResultMixPromotionVO getMixPromotionVO() {
            return this.mixPromotionVO;
        }

        public PurchaseMixViewResponseBodyResult setRecommendedMarketingCollocationDTO(PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO recommendedMarketingCollocationDTO) {
            this.recommendedMarketingCollocationDTO = recommendedMarketingCollocationDTO;
            return this;
        }
        public PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO getRecommendedMarketingCollocationDTO() {
            return this.recommendedMarketingCollocationDTO;
        }

    }

}
