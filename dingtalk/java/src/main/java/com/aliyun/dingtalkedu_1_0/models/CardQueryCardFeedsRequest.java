// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardQueryCardFeedsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public Integer bizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardBizCode")
    public String cardBizCode;

    @NameInMap("cardBizId")
    public String cardBizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardId")
    public Long cardId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("count")
    public Integer count;

    @NameInMap("cursor")
    public Long cursor;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("feedType")
    public Integer feedType;

    @NameInMap("needFinishProcess")
    public Boolean needFinishProcess;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceType")
    public String sourceType;

    @NameInMap("studentId")
    public String studentId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subBizId")
    public String subBizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CardQueryCardFeedsRequest build(java.util.Map<String, ?> map) throws Exception {
        CardQueryCardFeedsRequest self = new CardQueryCardFeedsRequest();
        return TeaModel.build(map, self);
    }

    public CardQueryCardFeedsRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public CardQueryCardFeedsRequest setCardBizCode(String cardBizCode) {
        this.cardBizCode = cardBizCode;
        return this;
    }
    public String getCardBizCode() {
        return this.cardBizCode;
    }

    public CardQueryCardFeedsRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public CardQueryCardFeedsRequest setCardId(Long cardId) {
        this.cardId = cardId;
        return this;
    }
    public Long getCardId() {
        return this.cardId;
    }

    public CardQueryCardFeedsRequest setCount(Integer count) {
        this.count = count;
        return this;
    }
    public Integer getCount() {
        return this.count;
    }

    public CardQueryCardFeedsRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public CardQueryCardFeedsRequest setFeedType(Integer feedType) {
        this.feedType = feedType;
        return this;
    }
    public Integer getFeedType() {
        return this.feedType;
    }

    public CardQueryCardFeedsRequest setNeedFinishProcess(Boolean needFinishProcess) {
        this.needFinishProcess = needFinishProcess;
        return this;
    }
    public Boolean getNeedFinishProcess() {
        return this.needFinishProcess;
    }

    public CardQueryCardFeedsRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

    public CardQueryCardFeedsRequest setStudentId(String studentId) {
        this.studentId = studentId;
        return this;
    }
    public String getStudentId() {
        return this.studentId;
    }

    public CardQueryCardFeedsRequest setSubBizId(String subBizId) {
        this.subBizId = subBizId;
        return this;
    }
    public String getSubBizId() {
        return this.subBizId;
    }

    public CardQueryCardFeedsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
