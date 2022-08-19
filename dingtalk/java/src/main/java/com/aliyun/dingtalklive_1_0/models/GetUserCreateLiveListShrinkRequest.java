// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserCreateLiveListShrinkRequest extends TeaModel {
    // post请求体, 开放平台建议以对象形式存储
    @NameInMap("body")
    public String bodyShrink;

    // 分页游标 第一次可不填， 后面填回包的值
    @NameInMap("nextToken")
    public String nextToken;

    // 单次拉去上限，默认40个
    @NameInMap("pageSize")
    public Integer pageSize;

    // 用户uid
    @NameInMap("unionId")
    public String unionId;

    public static GetUserCreateLiveListShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserCreateLiveListShrinkRequest self = new GetUserCreateLiveListShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetUserCreateLiveListShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

    public GetUserCreateLiveListShrinkRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetUserCreateLiveListShrinkRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetUserCreateLiveListShrinkRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
