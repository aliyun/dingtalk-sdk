// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewResultResponseBody extends TeaModel {
    @NameInMap("result")
    public GetContractReviewResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetContractReviewResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewResultResponseBody self = new GetContractReviewResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContractReviewResultResponseBody setResult(GetContractReviewResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetContractReviewResultResponseBodyResult getResult() {
        return this.result;
    }

    public GetContractReviewResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetContractReviewResultResponseBodyResultAnnotationsCommentTexts extends TeaModel {
        @NameInMap("remark")
        public String remark;

        @NameInMap("riskLevel")
        public String riskLevel;

        @NameInMap("text")
        public String text;

        public static GetContractReviewResultResponseBodyResultAnnotationsCommentTexts build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultResponseBodyResultAnnotationsCommentTexts self = new GetContractReviewResultResponseBodyResultAnnotationsCommentTexts();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultResponseBodyResultAnnotationsCommentTexts setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetContractReviewResultResponseBodyResultAnnotationsCommentTexts setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public GetContractReviewResultResponseBodyResultAnnotationsCommentTexts setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class GetContractReviewResultResponseBodyResultAnnotations extends TeaModel {
        @NameInMap("commentTexts")
        public java.util.List<GetContractReviewResultResponseBodyResultAnnotationsCommentTexts> commentTexts;

        @NameInMap("id")
        public Long id;

        @NameInMap("originalText")
        public String originalText;

        @NameInMap("paragraph")
        public String paragraph;

        @NameInMap("riskLevel")
        public String riskLevel;

        @NameInMap("status")
        public Boolean status;

        public static GetContractReviewResultResponseBodyResultAnnotations build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultResponseBodyResultAnnotations self = new GetContractReviewResultResponseBodyResultAnnotations();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultResponseBodyResultAnnotations setCommentTexts(java.util.List<GetContractReviewResultResponseBodyResultAnnotationsCommentTexts> commentTexts) {
            this.commentTexts = commentTexts;
            return this;
        }
        public java.util.List<GetContractReviewResultResponseBodyResultAnnotationsCommentTexts> getCommentTexts() {
            return this.commentTexts;
        }

        public GetContractReviewResultResponseBodyResultAnnotations setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetContractReviewResultResponseBodyResultAnnotations setOriginalText(String originalText) {
            this.originalText = originalText;
            return this;
        }
        public String getOriginalText() {
            return this.originalText;
        }

        public GetContractReviewResultResponseBodyResultAnnotations setParagraph(String paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public String getParagraph() {
            return this.paragraph;
        }

        public GetContractReviewResultResponseBodyResultAnnotations setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public GetContractReviewResultResponseBodyResultAnnotations setStatus(Boolean status) {
            this.status = status;
            return this;
        }
        public Boolean getStatus() {
            return this.status;
        }

    }

    public static class GetContractReviewResultResponseBodyResultSummary extends TeaModel {
        @NameInMap("riskLevel")
        public String riskLevel;

        @NameInMap("summary")
        public String summary;

        public static GetContractReviewResultResponseBodyResultSummary build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultResponseBodyResultSummary self = new GetContractReviewResultResponseBodyResultSummary();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultResponseBodyResultSummary setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public GetContractReviewResultResponseBodyResultSummary setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

    }

    public static class GetContractReviewResultResponseBodyResult extends TeaModel {
        @NameInMap("annotations")
        public java.util.List<GetContractReviewResultResponseBodyResultAnnotations> annotations;

        @NameInMap("clearWordPath")
        public String clearWordPath;

        @NameInMap("reviewType")
        public String reviewType;

        @NameInMap("status")
        public String status;

        @NameInMap("summary")
        public GetContractReviewResultResponseBodyResultSummary summary;

        @NameInMap("wordPath")
        public String wordPath;

        public static GetContractReviewResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultResponseBodyResult self = new GetContractReviewResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultResponseBodyResult setAnnotations(java.util.List<GetContractReviewResultResponseBodyResultAnnotations> annotations) {
            this.annotations = annotations;
            return this;
        }
        public java.util.List<GetContractReviewResultResponseBodyResultAnnotations> getAnnotations() {
            return this.annotations;
        }

        public GetContractReviewResultResponseBodyResult setClearWordPath(String clearWordPath) {
            this.clearWordPath = clearWordPath;
            return this;
        }
        public String getClearWordPath() {
            return this.clearWordPath;
        }

        public GetContractReviewResultResponseBodyResult setReviewType(String reviewType) {
            this.reviewType = reviewType;
            return this;
        }
        public String getReviewType() {
            return this.reviewType;
        }

        public GetContractReviewResultResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetContractReviewResultResponseBodyResult setSummary(GetContractReviewResultResponseBodyResultSummary summary) {
            this.summary = summary;
            return this;
        }
        public GetContractReviewResultResponseBodyResultSummary getSummary() {
            return this.summary;
        }

        public GetContractReviewResultResponseBodyResult setWordPath(String wordPath) {
            this.wordPath = wordPath;
            return this;
        }
        public String getWordPath() {
            return this.wordPath;
        }

    }

}
