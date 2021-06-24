// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListSpacesRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    // 空间类型
    @NameInMap("spaceType")
    public String spaceType;

    // 分页加载锚点
    @NameInMap("nextToken")
    public String nextToken;

    // 分页大小
    @NameInMap("maxResults")
    public Integer maxResults;

    public static ListSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSpacesRequest self = new ListSpacesRequest();
        return TeaModel.build(map, self);
    }

    public ListSpacesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public ListSpacesRequest setSpaceType(String spaceType) {
        this.spaceType = spaceType;
        return this;
    }
    public String getSpaceType() {
        return this.spaceType;
    }

    public ListSpacesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListSpacesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
