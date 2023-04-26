// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemsByKeyWordRequest extends TeaModel {
    @NameInMap("keyWord")
    public String keyWord;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static GetSearchItemsByKeyWordRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSearchItemsByKeyWordRequest self = new GetSearchItemsByKeyWordRequest();
        return TeaModel.build(map, self);
    }

    public GetSearchItemsByKeyWordRequest setKeyWord(String keyWord) {
        this.keyWord = keyWord;
        return this;
    }
    public String getKeyWord() {
        return this.keyWord;
    }

    public GetSearchItemsByKeyWordRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetSearchItemsByKeyWordRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
