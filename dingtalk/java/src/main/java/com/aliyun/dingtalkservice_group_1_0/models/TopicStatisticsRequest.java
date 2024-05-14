// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class TopicStatisticsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxDt")
    public String maxDt;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("minDt")
    public String minDt;

    @NameInMap("openConversationIds")
    public String openConversationIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("searchContent")
    public String searchContent;

    public static TopicStatisticsRequest build(java.util.Map<String, ?> map) throws Exception {
        TopicStatisticsRequest self = new TopicStatisticsRequest();
        return TeaModel.build(map, self);
    }

    public TopicStatisticsRequest setMaxDt(String maxDt) {
        this.maxDt = maxDt;
        return this;
    }
    public String getMaxDt() {
        return this.maxDt;
    }

    public TopicStatisticsRequest setMinDt(String minDt) {
        this.minDt = minDt;
        return this;
    }
    public String getMinDt() {
        return this.minDt;
    }

    public TopicStatisticsRequest setOpenConversationIds(String openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public String getOpenConversationIds() {
        return this.openConversationIds;
    }

    public TopicStatisticsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public TopicStatisticsRequest setSearchContent(String searchContent) {
        this.searchContent = searchContent;
        return this;
    }
    public String getSearchContent() {
        return this.searchContent;
    }

}
