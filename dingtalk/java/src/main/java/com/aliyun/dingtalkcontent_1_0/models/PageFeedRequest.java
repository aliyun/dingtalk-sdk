// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class PageFeedRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>50730********40554</p>
     */
    @NameInMap("mcnId")
    public String mcnId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
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
