// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoByRoomCodeRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static QueryConferenceInfoByRoomCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceInfoByRoomCodeRequest self = new QueryConferenceInfoByRoomCodeRequest();
        return TeaModel.build(map, self);
    }

    public QueryConferenceInfoByRoomCodeRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryConferenceInfoByRoomCodeRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
