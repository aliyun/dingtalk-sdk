// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMsgReadStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("cursor")
    public Long cursor;

    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openTaskId")
    public String openTaskId;

    /**
     * <strong>example:</strong>
     * <p>200</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryMsgReadStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMsgReadStatusRequest self = new QueryMsgReadStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryMsgReadStatusRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public QueryMsgReadStatusRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryMsgReadStatusRequest setOpenTaskId(String openTaskId) {
        this.openTaskId = openTaskId;
        return this;
    }
    public String getOpenTaskId() {
        return this.openTaskId;
    }

    public QueryMsgReadStatusRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
