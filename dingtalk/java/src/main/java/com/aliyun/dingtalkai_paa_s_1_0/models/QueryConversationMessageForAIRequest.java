// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryConversationMessageForAIRequest extends TeaModel {
    @NameInMap("openMsgIds")
    public java.util.List<String> openMsgIds;

    @NameInMap("recentDays")
    public Integer recentDays;

    @NameInMap("recentHours")
    public Integer recentHours;

    @NameInMap("recentN")
    public Integer recentN;

    public static QueryConversationMessageForAIRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryConversationMessageForAIRequest self = new QueryConversationMessageForAIRequest();
        return TeaModel.build(map, self);
    }

    public QueryConversationMessageForAIRequest setOpenMsgIds(java.util.List<String> openMsgIds) {
        this.openMsgIds = openMsgIds;
        return this;
    }
    public java.util.List<String> getOpenMsgIds() {
        return this.openMsgIds;
    }

    public QueryConversationMessageForAIRequest setRecentDays(Integer recentDays) {
        this.recentDays = recentDays;
        return this;
    }
    public Integer getRecentDays() {
        return this.recentDays;
    }

    public QueryConversationMessageForAIRequest setRecentHours(Integer recentHours) {
        this.recentHours = recentHours;
        return this;
    }
    public Integer getRecentHours() {
        return this.recentHours;
    }

    public QueryConversationMessageForAIRequest setRecentN(Integer recentN) {
        this.recentN = recentN;
        return this;
    }
    public Integer getRecentN() {
        return this.recentN;
    }

}
