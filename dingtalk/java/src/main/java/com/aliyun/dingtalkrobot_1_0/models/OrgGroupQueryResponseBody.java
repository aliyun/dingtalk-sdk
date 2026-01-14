// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupQueryResponseBody extends TeaModel {
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

    @NameInMap("readUsers")
    public java.util.List<OrgGroupQueryResponseBodyReadUsers> readUsers;

    /**
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
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

    public OrgGroupQueryResponseBody setReadUsers(java.util.List<OrgGroupQueryResponseBodyReadUsers> readUsers) {
        this.readUsers = readUsers;
        return this;
    }
    public java.util.List<OrgGroupQueryResponseBodyReadUsers> getReadUsers() {
        return this.readUsers;
    }

    public OrgGroupQueryResponseBody setSendStatus(String sendStatus) {
        this.sendStatus = sendStatus;
        return this;
    }
    public String getSendStatus() {
        return this.sendStatus;
    }

    public static class OrgGroupQueryResponseBodyReadUsers extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static OrgGroupQueryResponseBodyReadUsers build(java.util.Map<String, ?> map) throws Exception {
            OrgGroupQueryResponseBodyReadUsers self = new OrgGroupQueryResponseBodyReadUsers();
            return TeaModel.build(map, self);
        }

        public OrgGroupQueryResponseBodyReadUsers setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public OrgGroupQueryResponseBodyReadUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
