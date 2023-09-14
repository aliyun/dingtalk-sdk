// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryConversationMessageForAIShrinkRequest extends TeaModel {
    @NameInMap("openMsgIds")
    public String openMsgIdsShrink;

    @NameInMap("recentDays")
    public Integer recentDays;

    @NameInMap("recentHours")
    public Integer recentHours;

    @NameInMap("recentN")
    public Integer recentN;

    public static QueryConversationMessageForAIShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryConversationMessageForAIShrinkRequest self = new QueryConversationMessageForAIShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryConversationMessageForAIShrinkRequest setOpenMsgIdsShrink(String openMsgIdsShrink) {
        this.openMsgIdsShrink = openMsgIdsShrink;
        return this;
    }
    public String getOpenMsgIdsShrink() {
        return this.openMsgIdsShrink;
    }

    public QueryConversationMessageForAIShrinkRequest setRecentDays(Integer recentDays) {
        this.recentDays = recentDays;
        return this;
    }
    public Integer getRecentDays() {
        return this.recentDays;
    }

    public QueryConversationMessageForAIShrinkRequest setRecentHours(Integer recentHours) {
        this.recentHours = recentHours;
        return this;
    }
    public Integer getRecentHours() {
        return this.recentHours;
    }

    public QueryConversationMessageForAIShrinkRequest setRecentN(Integer recentN) {
        this.recentN = recentN;
        return this;
    }
    public Integer getRecentN() {
        return this.recentN;
    }

}
