// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewStatusResponseBody extends TeaModel {
    @NameInMap("data")
    public GetContractReviewStatusResponseBodyData data;

    public static GetContractReviewStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewStatusResponseBody self = new GetContractReviewStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContractReviewStatusResponseBody setData(GetContractReviewStatusResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetContractReviewStatusResponseBodyData getData() {
        return this.data;
    }

    public static class GetContractReviewStatusResponseBodyDataRiskCounts extends TeaModel {
        @NameInMap("high")
        public Long high;

        @NameInMap("low")
        public Long low;

        @NameInMap("medium")
        public Long medium;

        public static GetContractReviewStatusResponseBodyDataRiskCounts build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewStatusResponseBodyDataRiskCounts self = new GetContractReviewStatusResponseBodyDataRiskCounts();
            return TeaModel.build(map, self);
        }

        public GetContractReviewStatusResponseBodyDataRiskCounts setHigh(Long high) {
            this.high = high;
            return this;
        }
        public Long getHigh() {
            return this.high;
        }

        public GetContractReviewStatusResponseBodyDataRiskCounts setLow(Long low) {
            this.low = low;
            return this;
        }
        public Long getLow() {
            return this.low;
        }

        public GetContractReviewStatusResponseBodyDataRiskCounts setMedium(Long medium) {
            this.medium = medium;
            return this;
        }
        public Long getMedium() {
            return this.medium;
        }

    }

    public static class GetContractReviewStatusResponseBodyDataTopRisks extends TeaModel {
        @NameInMap("level")
        public String level;

        @NameInMap("suggestion")
        public String suggestion;

        @NameInMap("title")
        public String title;

        public static GetContractReviewStatusResponseBodyDataTopRisks build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewStatusResponseBodyDataTopRisks self = new GetContractReviewStatusResponseBodyDataTopRisks();
            return TeaModel.build(map, self);
        }

        public GetContractReviewStatusResponseBodyDataTopRisks setLevel(String level) {
            this.level = level;
            return this;
        }
        public String getLevel() {
            return this.level;
        }

        public GetContractReviewStatusResponseBodyDataTopRisks setSuggestion(String suggestion) {
            this.suggestion = suggestion;
            return this;
        }
        public String getSuggestion() {
            return this.suggestion;
        }

        public GetContractReviewStatusResponseBodyDataTopRisks setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetContractReviewStatusResponseBodyData extends TeaModel {
        @NameInMap("message")
        public String message;

        @NameInMap("progress_pct")
        public Long progressPct;

        @NameInMap("review_id")
        public String reviewId;

        @NameInMap("risk_counts")
        public GetContractReviewStatusResponseBodyDataRiskCounts riskCounts;

        @NameInMap("status")
        public String status;

        @NameInMap("top_risks")
        public java.util.List<GetContractReviewStatusResponseBodyDataTopRisks> topRisks;

        @NameInMap("weboffice_url")
        public String webofficeUrl;

        public static GetContractReviewStatusResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewStatusResponseBodyData self = new GetContractReviewStatusResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetContractReviewStatusResponseBodyData setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public GetContractReviewStatusResponseBodyData setProgressPct(Long progressPct) {
            this.progressPct = progressPct;
            return this;
        }
        public Long getProgressPct() {
            return this.progressPct;
        }

        public GetContractReviewStatusResponseBodyData setReviewId(String reviewId) {
            this.reviewId = reviewId;
            return this;
        }
        public String getReviewId() {
            return this.reviewId;
        }

        public GetContractReviewStatusResponseBodyData setRiskCounts(GetContractReviewStatusResponseBodyDataRiskCounts riskCounts) {
            this.riskCounts = riskCounts;
            return this;
        }
        public GetContractReviewStatusResponseBodyDataRiskCounts getRiskCounts() {
            return this.riskCounts;
        }

        public GetContractReviewStatusResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetContractReviewStatusResponseBodyData setTopRisks(java.util.List<GetContractReviewStatusResponseBodyDataTopRisks> topRisks) {
            this.topRisks = topRisks;
            return this;
        }
        public java.util.List<GetContractReviewStatusResponseBodyDataTopRisks> getTopRisks() {
            return this.topRisks;
        }

        public GetContractReviewStatusResponseBodyData setWebofficeUrl(String webofficeUrl) {
            this.webofficeUrl = webofficeUrl;
            return this;
        }
        public String getWebofficeUrl() {
            return this.webofficeUrl;
        }

    }

}
