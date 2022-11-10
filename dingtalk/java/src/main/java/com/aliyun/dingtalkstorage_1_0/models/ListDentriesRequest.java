// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListDentriesRequest extends TeaModel {
    // 分页大小
    // 默认值:
    // 	50
    // 最大值:
    // 	50
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标, 首次拉取不用传
    @NameInMap("nextToken")
    public String nextToken;

    // 排序规则, 升降或降序
    // 枚举值:
    // 	ASC: 升序
    // 	DESC: 降序
    // 默认值:
    // 	DESC
    @NameInMap("order")
    public String order;

    // 排序字段
    // 枚举值:
    // 	NAME: 名称
    // 	SIZE: 大小
    // 	MODIFIED_TIME: 最后修改时间
    // 	CREATE_TIME: 创建时间
    // 默认值:
    // 	MODIFIED_TIME
    @NameInMap("orderBy")
    public String orderBy;

    // 父目录id, 根目录id值为0
    @NameInMap("parentId")
    public String parentId;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static ListDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDentriesRequest self = new ListDentriesRequest();
        return TeaModel.build(map, self);
    }

    public ListDentriesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListDentriesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListDentriesRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

    public ListDentriesRequest setOrderBy(String orderBy) {
        this.orderBy = orderBy;
        return this;
    }
    public String getOrderBy() {
        return this.orderBy;
    }

    public ListDentriesRequest setParentId(String parentId) {
        this.parentId = parentId;
        return this;
    }
    public String getParentId() {
        return this.parentId;
    }

    public ListDentriesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
