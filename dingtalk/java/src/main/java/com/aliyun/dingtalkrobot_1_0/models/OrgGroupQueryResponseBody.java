// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupQueryResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("readUserIds")
    public java.util.List<String> readUserIds;

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
