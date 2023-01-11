// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryGroupMemberRequest extends TeaModel {
    /**
     * <p>酷应用编码</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>本次读取的最大数据记录数量（该入参传入值小于钉钉阈值时返回全部）</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>标记当前开始读取的位置，置空表示从头开始</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开放群ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static BatchQueryGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryGroupMemberRequest self = new BatchQueryGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryGroupMemberRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public BatchQueryGroupMemberRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public BatchQueryGroupMemberRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public BatchQueryGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
