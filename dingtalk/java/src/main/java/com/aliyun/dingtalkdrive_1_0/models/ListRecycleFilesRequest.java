// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleFilesRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    // 回收站类型
    @NameInMap("recycleType")
    public String recycleType;

    // 分页加载更多锚点
    @NameInMap("nextToken")
    public String nextToken;

    // 分页长度
    @NameInMap("maxResults")
    public Integer maxResults;

    // 文件排序类型
    @NameInMap("orderType")
    public String orderType;

    public static ListRecycleFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleFilesRequest self = new ListRecycleFilesRequest();
        return TeaModel.build(map, self);
    }

    public ListRecycleFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public ListRecycleFilesRequest setRecycleType(String recycleType) {
        this.recycleType = recycleType;
        return this;
    }
    public String getRecycleType() {
        return this.recycleType;
    }

    public ListRecycleFilesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecycleFilesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListRecycleFilesRequest setOrderType(String orderType) {
        this.orderType = orderType;
        return this;
    }
    public String getOrderType() {
        return this.orderType;
    }

}
