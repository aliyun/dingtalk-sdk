// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class ListGroupBlackboardRequest extends TeaModel {
    @NameInMap("nextPageCursor")
    public String nextPageCursor;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("userId")
    public String userId;

    public static ListGroupBlackboardRequest build(java.util.Map<String, ?> map) throws Exception {
        ListGroupBlackboardRequest self = new ListGroupBlackboardRequest();
        return TeaModel.build(map, self);
    }

    public ListGroupBlackboardRequest setNextPageCursor(String nextPageCursor) {
        this.nextPageCursor = nextPageCursor;
        return this;
    }
    public String getNextPageCursor() {
        return this.nextPageCursor;
    }

    public ListGroupBlackboardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public ListGroupBlackboardRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListGroupBlackboardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
