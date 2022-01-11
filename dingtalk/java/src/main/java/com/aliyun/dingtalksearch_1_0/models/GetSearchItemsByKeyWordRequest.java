// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemsByKeyWordRequest extends TeaModel {
    // 搜索关键词
    @NameInMap("keyWord")
    public String keyWord;

    // 一次性请求的item数量
    @NameInMap("maxResults")
    public Integer maxResults;

    // 加密偏移量，第一次请求取“0”值，后续请求根据接口返回的nextToken值进行填写
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
