// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListSpacesRequest extends TeaModel {
    /**
     * <p>分页大小</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页加载锚点</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>空间类型</p>
     */
    @NameInMap("spaceType")
    public String spaceType;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSpacesRequest self = new ListSpacesRequest();
        return TeaModel.build(map, self);
    }

    public ListSpacesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListSpacesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListSpacesRequest setSpaceType(String spaceType) {
        this.spaceType = spaceType;
        return this;
    }
    public String getSpaceType() {
        return this.spaceType;
    }

    public ListSpacesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
