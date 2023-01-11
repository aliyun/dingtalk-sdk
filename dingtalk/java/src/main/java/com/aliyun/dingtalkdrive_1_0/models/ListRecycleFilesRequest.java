// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleFilesRequest extends TeaModel {
    /**
     * <p>分页长度</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页加载更多锚点</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>文件排序类型</p>
     */
    @NameInMap("orderType")
    public String orderType;

    /**
     * <p>回收站类型</p>
     */
    @NameInMap("recycleType")
    public String recycleType;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListRecycleFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleFilesRequest self = new ListRecycleFilesRequest();
        return TeaModel.build(map, self);
    }

    public ListRecycleFilesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListRecycleFilesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecycleFilesRequest setOrderType(String orderType) {
        this.orderType = orderType;
        return this;
    }
    public String getOrderType() {
        return this.orderType;
    }

    public ListRecycleFilesRequest setRecycleType(String recycleType) {
        this.recycleType = recycleType;
        return this;
    }
    public String getRecycleType() {
        return this.recycleType;
    }

    public ListRecycleFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
