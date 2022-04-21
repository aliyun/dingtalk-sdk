// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class TopicStatisticsRequest extends TeaModel {
    // 截止日期
    @NameInMap("maxDt")
    public String maxDt;

    // 起始日期
    @NameInMap("minDt")
    public String minDt;

    // 开放群ID列表（多个用逗号拼接）
    @NameInMap("openConversationIds")
    public String openConversationIds;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 搜索内容
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
