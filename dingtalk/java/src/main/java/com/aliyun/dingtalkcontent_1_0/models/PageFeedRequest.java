// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class PageFeedRequest extends TeaModel {
    /**
     * <p>内容Id，如果传入该参数，表示仅筛选内容Id出现在本列表中的内容</p>
     */
    @NameInMap("body")
    public java.util.List<String> body;

    /**
     * <p>分页参数：页面展示数量</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>入驻账号Id(请联系钉钉接口同学获取)</p>
     */
    @NameInMap("mcnId")
    public String mcnId;

    /**
     * <p>分页参数：起始位置，初始值应为0，后续传入返回值中的nextCursor字段中的值</p>
     */
    @NameInMap("nextToken")
    public Integer nextToken;

    public static PageFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        PageFeedRequest self = new PageFeedRequest();
        return TeaModel.build(map, self);
    }

    public PageFeedRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

    public PageFeedRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public PageFeedRequest setMcnId(String mcnId) {
        this.mcnId = mcnId;
        return this;
    }
    public String getMcnId() {
        return this.mcnId;
    }

    public PageFeedRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

}
