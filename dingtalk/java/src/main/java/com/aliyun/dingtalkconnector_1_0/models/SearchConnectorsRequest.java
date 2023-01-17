// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchConnectorsRequest extends TeaModel {
    /**
     * <p>最大返回记录数，最多50</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>查询指定位置的记录，为空则从头开始</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>查询连接器的类型</p>
     */
    @NameInMap("type")
    public String type;

    public static SearchConnectorsRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchConnectorsRequest self = new SearchConnectorsRequest();
        return TeaModel.build(map, self);
    }

    public SearchConnectorsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchConnectorsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchConnectorsRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
