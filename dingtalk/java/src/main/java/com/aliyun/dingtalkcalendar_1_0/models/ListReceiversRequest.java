// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListReceiversRequest extends TeaModel {
    // 上次查询返回的翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 签到类型
    @NameInMap("type")
    public String type;

    // 返回个数(最大2000)
    @NameInMap("maxResults")
    public Long maxResults;

    public static ListReceiversRequest build(java.util.Map<String, ?> map) throws Exception {
        ListReceiversRequest self = new ListReceiversRequest();
        return TeaModel.build(map, self);
    }

    public ListReceiversRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListReceiversRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public ListReceiversRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

}
