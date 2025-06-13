// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ContractAiReviewResultNotifyRequest extends TeaModel {
    @NameInMap("annotations")
    public java.util.List<ContractAiReviewResultNotifyRequestAnnotations> annotations;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contractAiReviewCorpId")
    public String contractAiReviewCorpId;

    @NameInMap("contractAiReviewId")
    public Long contractAiReviewId;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("extension")
    public String extension;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static ContractAiReviewResultNotifyRequest build(java.util.Map<String, ?> map) throws Exception {
        ContractAiReviewResultNotifyRequest self = new ContractAiReviewResultNotifyRequest();
        return TeaModel.build(map, self);
    }

    public ContractAiReviewResultNotifyRequest setAnnotations(java.util.List<ContractAiReviewResultNotifyRequestAnnotations> annotations) {
        this.annotations = annotations;
        return this;
    }
    public java.util.List<ContractAiReviewResultNotifyRequestAnnotations> getAnnotations() {
        return this.annotations;
    }

    public ContractAiReviewResultNotifyRequest setContractAiReviewCorpId(String contractAiReviewCorpId) {
        this.contractAiReviewCorpId = contractAiReviewCorpId;
        return this;
    }
    public String getContractAiReviewCorpId() {
        return this.contractAiReviewCorpId;
    }

    public ContractAiReviewResultNotifyRequest setContractAiReviewId(Long contractAiReviewId) {
        this.contractAiReviewId = contractAiReviewId;
        return this;
    }
    public Long getContractAiReviewId() {
        return this.contractAiReviewId;
    }

    public ContractAiReviewResultNotifyRequest setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public ContractAiReviewResultNotifyRequest setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public ContractAiReviewResultNotifyRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public ContractAiReviewResultNotifyRequest setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ContractAiReviewResultNotifyRequestAnnotationsCommentTexts extends TeaModel {
        @NameInMap("remark")
        public String remark;

        @NameInMap("riskLevel")
        public String riskLevel;

        @NameInMap("text")
        public String text;

        public static ContractAiReviewResultNotifyRequestAnnotationsCommentTexts build(java.util.Map<String, ?> map) throws Exception {
            ContractAiReviewResultNotifyRequestAnnotationsCommentTexts self = new ContractAiReviewResultNotifyRequestAnnotationsCommentTexts();
            return TeaModel.build(map, self);
        }

        public ContractAiReviewResultNotifyRequestAnnotationsCommentTexts setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public ContractAiReviewResultNotifyRequestAnnotationsCommentTexts setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public ContractAiReviewResultNotifyRequestAnnotationsCommentTexts setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class ContractAiReviewResultNotifyRequestAnnotations extends TeaModel {
        @NameInMap("commentTexts")
        public java.util.List<ContractAiReviewResultNotifyRequestAnnotationsCommentTexts> commentTexts;

        @NameInMap("id")
        public Integer id;

        @NameInMap("originalText")
        public String originalText;

        @NameInMap("paragraph")
        public String paragraph;

        @NameInMap("riskLevel")
        public String riskLevel;

        public static ContractAiReviewResultNotifyRequestAnnotations build(java.util.Map<String, ?> map) throws Exception {
            ContractAiReviewResultNotifyRequestAnnotations self = new ContractAiReviewResultNotifyRequestAnnotations();
            return TeaModel.build(map, self);
        }

        public ContractAiReviewResultNotifyRequestAnnotations setCommentTexts(java.util.List<ContractAiReviewResultNotifyRequestAnnotationsCommentTexts> commentTexts) {
            this.commentTexts = commentTexts;
            return this;
        }
        public java.util.List<ContractAiReviewResultNotifyRequestAnnotationsCommentTexts> getCommentTexts() {
            return this.commentTexts;
        }

        public ContractAiReviewResultNotifyRequestAnnotations setId(Integer id) {
            this.id = id;
            return this;
        }
        public Integer getId() {
            return this.id;
        }

        public ContractAiReviewResultNotifyRequestAnnotations setOriginalText(String originalText) {
            this.originalText = originalText;
            return this;
        }
        public String getOriginalText() {
            return this.originalText;
        }

        public ContractAiReviewResultNotifyRequestAnnotations setParagraph(String paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public String getParagraph() {
            return this.paragraph;
        }

        public ContractAiReviewResultNotifyRequestAnnotations setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

    }

}
