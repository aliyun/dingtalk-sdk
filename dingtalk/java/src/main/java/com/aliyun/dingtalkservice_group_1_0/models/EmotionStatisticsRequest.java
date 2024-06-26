// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class EmotionStatisticsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220101</p>
     */
    @NameInMap("maxDt")
    public String maxDt;

    /**
     * <strong>example:</strong>
     * <p>0.8</p>
     */
    @NameInMap("maxEmotion")
    public Double maxEmotion;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220101</p>
     */
    @NameInMap("minDt")
    public String minDt;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("minEmotion")
    public Double minEmotion;

    /**
     * <strong>example:</strong>
     * <p>cidXX,cidYY</p>
     */
    @NameInMap("openConversationIds")
    public String openConversationIds;

    /**
     * <strong>example:</strong>
     * <p>ksdfosd</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>KxisoOk</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static EmotionStatisticsRequest build(java.util.Map<String, ?> map) throws Exception {
        EmotionStatisticsRequest self = new EmotionStatisticsRequest();
        return TeaModel.build(map, self);
    }

    public EmotionStatisticsRequest setMaxDt(String maxDt) {
        this.maxDt = maxDt;
        return this;
    }
    public String getMaxDt() {
        return this.maxDt;
    }

    public EmotionStatisticsRequest setMaxEmotion(Double maxEmotion) {
        this.maxEmotion = maxEmotion;
        return this;
    }
    public Double getMaxEmotion() {
        return this.maxEmotion;
    }

    public EmotionStatisticsRequest setMinDt(String minDt) {
        this.minDt = minDt;
        return this;
    }
    public String getMinDt() {
        return this.minDt;
    }

    public EmotionStatisticsRequest setMinEmotion(Double minEmotion) {
        this.minEmotion = minEmotion;
        return this;
    }
    public Double getMinEmotion() {
        return this.minEmotion;
    }

    public EmotionStatisticsRequest setOpenConversationIds(String openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public String getOpenConversationIds() {
        return this.openConversationIds;
    }

    public EmotionStatisticsRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public EmotionStatisticsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
