// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConferenceInfoRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static QueryScheduleConferenceInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConferenceInfoRequest self = new QueryScheduleConferenceInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConferenceInfoRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryScheduleConferenceInfoRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
