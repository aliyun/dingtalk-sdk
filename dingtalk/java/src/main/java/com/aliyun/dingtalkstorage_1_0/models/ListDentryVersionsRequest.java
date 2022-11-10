// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListDentryVersionsRequest extends TeaModel {
    // 历史版本分页大小，默认100
    // 默认值:
    // 	100
    // 最大值:
    // 	100
    @NameInMap("maxResults")
    public Integer maxResults;

    // 下一页的游标位置
    @NameInMap("nextToken")
    public String nextToken;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static ListDentryVersionsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDentryVersionsRequest self = new ListDentryVersionsRequest();
        return TeaModel.build(map, self);
    }

    public ListDentryVersionsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListDentryVersionsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListDentryVersionsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
