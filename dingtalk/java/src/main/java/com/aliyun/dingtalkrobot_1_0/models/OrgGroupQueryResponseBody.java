// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupQueryResponseBody extends TeaModel {
    // 分页查询是否还有人员可查询消息已读状态
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下次分页查询的加密凭证
    @NameInMap("nextToken")
    public String nextToken;

    // 消息已读人的userId列表
    @NameInMap("readUserIds")
    public java.util.List<String> readUserIds;

    // 消息发送状态
    @NameInMap("sendStatus")
    public String sendStatus;

    public static OrgGroupQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupQueryResponseBody self = new OrgGroupQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public OrgGroupQueryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public OrgGroupQueryResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public OrgGroupQueryResponseBody setReadUserIds(java.util.List<String> readUserIds) {
        this.readUserIds = readUserIds;
        return this;
    }
    public java.util.List<String> getReadUserIds() {
        return this.readUserIds;
    }

    public OrgGroupQueryResponseBody setSendStatus(String sendStatus) {
        this.sendStatus = sendStatus;
        return this;
    }
    public String getSendStatus() {
        return this.sendStatus;
    }

}
