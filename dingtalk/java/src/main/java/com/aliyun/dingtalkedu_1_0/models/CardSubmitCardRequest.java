// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardSubmitCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>industry_center</p>
     */
    @NameInMap("cardBizCode")
    public String cardBizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardBizId")
    public String cardBizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardId")
    public String cardId;

    @NameInMap("cardTaskCode")
    public String cardTaskCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardTaskId")
    public String cardTaskId;

    @NameInMap("content")
    public String content;

    @NameInMap("detailUrl")
    public String detailUrl;

    @NameInMap("editUrl")
    public String editUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("medias")
    public String medias;

    @NameInMap("meteringNumber")
    public Double meteringNumber;

    @NameInMap("reissueCard")
    public Boolean reissueCard;

    @NameInMap("resultEvaluation")
    public String resultEvaluation;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceType")
    public String sourceType;

    @NameInMap("specifiedStudentId")
    public String specifiedStudentId;

    @NameInMap("unitOfMeasurement")
    public String unitOfMeasurement;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CardSubmitCardRequest build(java.util.Map<String, ?> map) throws Exception {
        CardSubmitCardRequest self = new CardSubmitCardRequest();
        return TeaModel.build(map, self);
    }

    public CardSubmitCardRequest setCardBizCode(String cardBizCode) {
        this.cardBizCode = cardBizCode;
        return this;
    }
    public String getCardBizCode() {
        return this.cardBizCode;
    }

    public CardSubmitCardRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public CardSubmitCardRequest setCardId(String cardId) {
        this.cardId = cardId;
        return this;
    }
    public String getCardId() {
        return this.cardId;
    }

    public CardSubmitCardRequest setCardTaskCode(String cardTaskCode) {
        this.cardTaskCode = cardTaskCode;
        return this;
    }
    public String getCardTaskCode() {
        return this.cardTaskCode;
    }

    public CardSubmitCardRequest setCardTaskId(String cardTaskId) {
        this.cardTaskId = cardTaskId;
        return this;
    }
    public String getCardTaskId() {
        return this.cardTaskId;
    }

    public CardSubmitCardRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CardSubmitCardRequest setDetailUrl(String detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public String getDetailUrl() {
        return this.detailUrl;
    }

    public CardSubmitCardRequest setEditUrl(String editUrl) {
        this.editUrl = editUrl;
        return this;
    }
    public String getEditUrl() {
        return this.editUrl;
    }

    public CardSubmitCardRequest setMedias(String medias) {
        this.medias = medias;
        return this;
    }
    public String getMedias() {
        return this.medias;
    }

    public CardSubmitCardRequest setMeteringNumber(Double meteringNumber) {
        this.meteringNumber = meteringNumber;
        return this;
    }
    public Double getMeteringNumber() {
        return this.meteringNumber;
    }

    public CardSubmitCardRequest setReissueCard(Boolean reissueCard) {
        this.reissueCard = reissueCard;
        return this;
    }
    public Boolean getReissueCard() {
        return this.reissueCard;
    }

    public CardSubmitCardRequest setResultEvaluation(String resultEvaluation) {
        this.resultEvaluation = resultEvaluation;
        return this;
    }
    public String getResultEvaluation() {
        return this.resultEvaluation;
    }

    public CardSubmitCardRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

    public CardSubmitCardRequest setSpecifiedStudentId(String specifiedStudentId) {
        this.specifiedStudentId = specifiedStudentId;
        return this;
    }
    public String getSpecifiedStudentId() {
        return this.specifiedStudentId;
    }

    public CardSubmitCardRequest setUnitOfMeasurement(String unitOfMeasurement) {
        this.unitOfMeasurement = unitOfMeasurement;
        return this;
    }
    public String getUnitOfMeasurement() {
        return this.unitOfMeasurement;
    }

    public CardSubmitCardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
