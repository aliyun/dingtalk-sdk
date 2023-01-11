// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListDentriesRequest extends TeaModel {
    /**
     * <p>分页大小</p>
     * <p>默认值:</p>
     * <p>	50</p>
     * <p>最大值:</p>
     * <p>	50</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页游标, 首次拉取不用传</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>排序规则, 升降或降序</p>
     * <p>枚举值:</p>
     * <p>	ASC: 升序</p>
     * <p>	DESC: 降序</p>
     * <p>默认值:</p>
     * <p>	DESC</p>
     */
    @NameInMap("order")
    public String order;

    /**
     * <p>排序字段</p>
     * <p>枚举值:</p>
     * <p>	NAME: 名称</p>
     * <p>	SIZE: 大小</p>
     * <p>	MODIFIED_TIME: 最后修改时间</p>
     * <p>	CREATE_TIME: 创建时间</p>
     * <p>默认值:</p>
     * <p>	MODIFIED_TIME</p>
     */
    @NameInMap("orderBy")
    public String orderBy;

    /**
     * <p>父目录id, 根目录id值为0</p>
     */
    @NameInMap("parentId")
    public String parentId;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>是否获取文件缩略图临时链接</p>
     * <p>注: 按需获取, 会影响接口耗时</p>
     * <p>默认值:</p>
     * <p>	false</p>
     */
    @NameInMap("withThumbnail")
    public Boolean withThumbnail;

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

    public ListDentriesRequest setWithThumbnail(Boolean withThumbnail) {
        this.withThumbnail = withThumbnail;
        return this;
    }
    public Boolean getWithThumbnail() {
        return this.withThumbnail;
    }

}
