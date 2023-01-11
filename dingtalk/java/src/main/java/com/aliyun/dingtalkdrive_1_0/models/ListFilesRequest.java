// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListFilesRequest extends TeaModel {
    /**
     * <p>分页长度</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页查询锚点</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>排序类型</p>
     */
    @NameInMap("orderType")
    public String orderType;

    /**
     * <p>父目录id</p>
     */
    @NameInMap("parentId")
    public String parentId;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>是否返回文件图标</p>
     */
    @NameInMap("withIcon")
    public Boolean withIcon;

    public static ListFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFilesRequest self = new ListFilesRequest();
        return TeaModel.build(map, self);
    }

    public ListFilesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListFilesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListFilesRequest setOrderType(String orderType) {
        this.orderType = orderType;
        return this;
    }
    public String getOrderType() {
        return this.orderType;
    }

    public ListFilesRequest setParentId(String parentId) {
        this.parentId = parentId;
        return this;
    }
    public String getParentId() {
        return this.parentId;
    }

    public ListFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public ListFilesRequest setWithIcon(Boolean withIcon) {
        this.withIcon = withIcon;
        return this;
    }
    public Boolean getWithIcon() {
        return this.withIcon;
    }

}
