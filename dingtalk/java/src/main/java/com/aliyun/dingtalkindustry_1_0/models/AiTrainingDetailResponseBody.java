// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiTrainingDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public AiTrainingDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AiTrainingDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AiTrainingDetailResponseBody self = new AiTrainingDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public AiTrainingDetailResponseBody setResult(AiTrainingDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AiTrainingDetailResponseBodyResult getResult() {
        return this.result;
    }

    public AiTrainingDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AiTrainingDetailResponseBodyResultProductInfoList extends TeaModel {
        @NameInMap("attribute")
        public String attribute;

        @NameInMap("brand")
        public String brand;

        @NameInMap("category")
        public String category;

        @NameInMap("currency")
        public String currency;

        @NameInMap("imageUrls")
        public java.util.List<String> imageUrls;

        @NameInMap("price")
        public Long price;

        @NameInMap("productCode")
        public String productCode;

        @NameInMap("productFab")
        public String productFab;

        @NameInMap("productId")
        public Long productId;

        @NameInMap("productInfo")
        public String productInfo;

        @NameInMap("productName")
        public String productName;

        @NameInMap("relatedType")
        public String relatedType;

        public static AiTrainingDetailResponseBodyResultProductInfoList build(java.util.Map<String, ?> map) throws Exception {
            AiTrainingDetailResponseBodyResultProductInfoList self = new AiTrainingDetailResponseBodyResultProductInfoList();
            return TeaModel.build(map, self);
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setAttribute(String attribute) {
            this.attribute = attribute;
            return this;
        }
        public String getAttribute() {
            return this.attribute;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setCurrency(String currency) {
            this.currency = currency;
            return this;
        }
        public String getCurrency() {
            return this.currency;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setImageUrls(java.util.List<String> imageUrls) {
            this.imageUrls = imageUrls;
            return this;
        }
        public java.util.List<String> getImageUrls() {
            return this.imageUrls;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setProductCode(String productCode) {
            this.productCode = productCode;
            return this;
        }
        public String getProductCode() {
            return this.productCode;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setProductFab(String productFab) {
            this.productFab = productFab;
            return this;
        }
        public String getProductFab() {
            return this.productFab;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setProductId(Long productId) {
            this.productId = productId;
            return this;
        }
        public Long getProductId() {
            return this.productId;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setProductInfo(String productInfo) {
            this.productInfo = productInfo;
            return this;
        }
        public String getProductInfo() {
            return this.productInfo;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

        public AiTrainingDetailResponseBodyResultProductInfoList setRelatedType(String relatedType) {
            this.relatedType = relatedType;
            return this;
        }
        public String getRelatedType() {
            return this.relatedType;
        }

    }

    public static class AiTrainingDetailResponseBodyResultTaskInfo extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("taskId")
        public Long taskId;

        @NameInMap("taskName")
        public String taskName;

        public static AiTrainingDetailResponseBodyResultTaskInfo build(java.util.Map<String, ?> map) throws Exception {
            AiTrainingDetailResponseBodyResultTaskInfo self = new AiTrainingDetailResponseBodyResultTaskInfo();
            return TeaModel.build(map, self);
        }

        public AiTrainingDetailResponseBodyResultTaskInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AiTrainingDetailResponseBodyResultTaskInfo setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public AiTrainingDetailResponseBodyResultTaskInfo setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

    }

    public static class AiTrainingDetailResponseBodyResult extends TeaModel {
        @NameInMap("adminReview")
        public String adminReview;

        @NameInMap("aiJobStatus")
        public String aiJobStatus;

        @NameInMap("creator")
        public String creator;

        @NameInMap("duration")
        public Long duration;

        @NameInMap("feedback")
        public Long feedback;

        @NameInMap("feedbackContent")
        public String feedbackContent;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("id")
        public Long id;

        @NameInMap("isExcellent")
        public Long isExcellent;

        @NameInMap("productInfoList")
        public java.util.List<AiTrainingDetailResponseBodyResultProductInfoList> productInfoList;

        @NameInMap("productName")
        public String productName;

        @NameInMap("taskInfo")
        public AiTrainingDetailResponseBodyResultTaskInfo taskInfo;

        @NameInMap("trainingRanking")
        public Long trainingRanking;

        @NameInMap("trainingRankingPercent")
        public Long trainingRankingPercent;

        @NameInMap("trainingScore")
        public Long trainingScore;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        @NameInMap("videoDownloadUrl")
        public String videoDownloadUrl;

        public static AiTrainingDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AiTrainingDetailResponseBodyResult self = new AiTrainingDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AiTrainingDetailResponseBodyResult setAdminReview(String adminReview) {
            this.adminReview = adminReview;
            return this;
        }
        public String getAdminReview() {
            return this.adminReview;
        }

        public AiTrainingDetailResponseBodyResult setAiJobStatus(String aiJobStatus) {
            this.aiJobStatus = aiJobStatus;
            return this;
        }
        public String getAiJobStatus() {
            return this.aiJobStatus;
        }

        public AiTrainingDetailResponseBodyResult setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public AiTrainingDetailResponseBodyResult setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public AiTrainingDetailResponseBodyResult setFeedback(Long feedback) {
            this.feedback = feedback;
            return this;
        }
        public Long getFeedback() {
            return this.feedback;
        }

        public AiTrainingDetailResponseBodyResult setFeedbackContent(String feedbackContent) {
            this.feedbackContent = feedbackContent;
            return this;
        }
        public String getFeedbackContent() {
            return this.feedbackContent;
        }

        public AiTrainingDetailResponseBodyResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public AiTrainingDetailResponseBodyResult setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public AiTrainingDetailResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public AiTrainingDetailResponseBodyResult setIsExcellent(Long isExcellent) {
            this.isExcellent = isExcellent;
            return this;
        }
        public Long getIsExcellent() {
            return this.isExcellent;
        }

        public AiTrainingDetailResponseBodyResult setProductInfoList(java.util.List<AiTrainingDetailResponseBodyResultProductInfoList> productInfoList) {
            this.productInfoList = productInfoList;
            return this;
        }
        public java.util.List<AiTrainingDetailResponseBodyResultProductInfoList> getProductInfoList() {
            return this.productInfoList;
        }

        public AiTrainingDetailResponseBodyResult setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

        public AiTrainingDetailResponseBodyResult setTaskInfo(AiTrainingDetailResponseBodyResultTaskInfo taskInfo) {
            this.taskInfo = taskInfo;
            return this;
        }
        public AiTrainingDetailResponseBodyResultTaskInfo getTaskInfo() {
            return this.taskInfo;
        }

        public AiTrainingDetailResponseBodyResult setTrainingRanking(Long trainingRanking) {
            this.trainingRanking = trainingRanking;
            return this;
        }
        public Long getTrainingRanking() {
            return this.trainingRanking;
        }

        public AiTrainingDetailResponseBodyResult setTrainingRankingPercent(Long trainingRankingPercent) {
            this.trainingRankingPercent = trainingRankingPercent;
            return this;
        }
        public Long getTrainingRankingPercent() {
            return this.trainingRankingPercent;
        }

        public AiTrainingDetailResponseBodyResult setTrainingScore(Long trainingScore) {
            this.trainingScore = trainingScore;
            return this;
        }
        public Long getTrainingScore() {
            return this.trainingScore;
        }

        public AiTrainingDetailResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public AiTrainingDetailResponseBodyResult setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public AiTrainingDetailResponseBodyResult setVideoDownloadUrl(String videoDownloadUrl) {
            this.videoDownloadUrl = videoDownloadUrl;
            return this;
        }
        public String getVideoDownloadUrl() {
            return this.videoDownloadUrl;
        }

    }

}
