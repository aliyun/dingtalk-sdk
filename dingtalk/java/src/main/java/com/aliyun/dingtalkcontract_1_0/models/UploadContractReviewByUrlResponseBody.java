// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UploadContractReviewByUrlResponseBody extends TeaModel {
    @NameInMap("data")
    public UploadContractReviewByUrlResponseBodyData data;

    public static UploadContractReviewByUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadContractReviewByUrlResponseBody self = new UploadContractReviewByUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadContractReviewByUrlResponseBody setData(UploadContractReviewByUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public UploadContractReviewByUrlResponseBodyData getData() {
        return this.data;
    }

    public static class UploadContractReviewByUrlResponseBodyDataRecommended extends TeaModel {
        @NameInMap("contract_type")
        public String contractType;

        @NameInMap("scale")
        public String scale;

        @NameInMap("standpoint")
        public String standpoint;

        public static UploadContractReviewByUrlResponseBodyDataRecommended build(java.util.Map<String, ?> map) throws Exception {
            UploadContractReviewByUrlResponseBodyDataRecommended self = new UploadContractReviewByUrlResponseBodyDataRecommended();
            return TeaModel.build(map, self);
        }

        public UploadContractReviewByUrlResponseBodyDataRecommended setContractType(String contractType) {
            this.contractType = contractType;
            return this;
        }
        public String getContractType() {
            return this.contractType;
        }

        public UploadContractReviewByUrlResponseBodyDataRecommended setScale(String scale) {
            this.scale = scale;
            return this;
        }
        public String getScale() {
            return this.scale;
        }

        public UploadContractReviewByUrlResponseBodyDataRecommended setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class UploadContractReviewByUrlResponseBodyDataWeboffice extends TeaModel {
        @NameInMap("url")
        public String url;

        public static UploadContractReviewByUrlResponseBodyDataWeboffice build(java.util.Map<String, ?> map) throws Exception {
            UploadContractReviewByUrlResponseBodyDataWeboffice self = new UploadContractReviewByUrlResponseBodyDataWeboffice();
            return TeaModel.build(map, self);
        }

        public UploadContractReviewByUrlResponseBodyDataWeboffice setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class UploadContractReviewByUrlResponseBodyData extends TeaModel {
        @NameInMap("overview_summary")
        public String overviewSummary;

        @NameInMap("recommendation_fallback")
        public Boolean recommendationFallback;

        @NameInMap("recommended")
        public UploadContractReviewByUrlResponseBodyDataRecommended recommended;

        @NameInMap("review_id")
        public String reviewId;

        @NameInMap("weboffice")
        public UploadContractReviewByUrlResponseBodyDataWeboffice weboffice;

        public static UploadContractReviewByUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            UploadContractReviewByUrlResponseBodyData self = new UploadContractReviewByUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public UploadContractReviewByUrlResponseBodyData setOverviewSummary(String overviewSummary) {
            this.overviewSummary = overviewSummary;
            return this;
        }
        public String getOverviewSummary() {
            return this.overviewSummary;
        }

        public UploadContractReviewByUrlResponseBodyData setRecommendationFallback(Boolean recommendationFallback) {
            this.recommendationFallback = recommendationFallback;
            return this;
        }
        public Boolean getRecommendationFallback() {
            return this.recommendationFallback;
        }

        public UploadContractReviewByUrlResponseBodyData setRecommended(UploadContractReviewByUrlResponseBodyDataRecommended recommended) {
            this.recommended = recommended;
            return this;
        }
        public UploadContractReviewByUrlResponseBodyDataRecommended getRecommended() {
            return this.recommended;
        }

        public UploadContractReviewByUrlResponseBodyData setReviewId(String reviewId) {
            this.reviewId = reviewId;
            return this;
        }
        public String getReviewId() {
            return this.reviewId;
        }

        public UploadContractReviewByUrlResponseBodyData setWeboffice(UploadContractReviewByUrlResponseBodyDataWeboffice weboffice) {
            this.weboffice = weboffice;
            return this;
        }
        public UploadContractReviewByUrlResponseBodyDataWeboffice getWeboffice() {
            return this.weboffice;
        }

    }

}
