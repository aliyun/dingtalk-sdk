// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomControlPanelListRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("roomId")
    public String roomId;

    @NameInMap("unionId")
    public String unionId;

    public static QueryMeetingRoomControlPanelListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomControlPanelListRequest self = new QueryMeetingRoomControlPanelListRequest();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomControlPanelListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryMeetingRoomControlPanelListRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryMeetingRoomControlPanelListRequest setRoomId(String roomId) {
        this.roomId = roomId;
        return this;
    }
    public String getRoomId() {
        return this.roomId;
    }

    public QueryMeetingRoomControlPanelListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
