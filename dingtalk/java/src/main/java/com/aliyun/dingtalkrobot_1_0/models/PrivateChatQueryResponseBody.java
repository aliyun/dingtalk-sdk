// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatQueryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("readUserIds")
    public java.util.List<String> readUserIds;

    /**
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("sendStatus")
    public String sendStatus;

    public static PrivateChatQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PrivateChatQueryResponseBody self = new PrivateChatQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public PrivateChatQueryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public PrivateChatQueryResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PrivateChatQueryResponseBody setReadUserIds(java.util.List<String> readUserIds) {
        this.readUserIds = readUserIds;
        return this;
    }
    public java.util.List<String> getReadUserIds() {
        return this.readUserIds;
    }

    public PrivateChatQueryResponseBody setSendStatus(String sendStatus) {
        this.sendStatus = sendStatus;
        return this;
    }
    public String getSendStatus() {
        return this.sendStatus;
    }

}
