// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomListRequest extends TeaModel {
    // 请求分页大小
    @NameInMap("maxResults")
    public Integer maxResults;

    // 请求分页token
    @NameInMap("nextToken")
    public Long nextToken;

    // 操作人unionId
    @NameInMap("unionId")
    public String unionId;

    public static QueryMeetingRoomListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomListRequest self = new QueryMeetingRoomListRequest();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryMeetingRoomListRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryMeetingRoomListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
