// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class ListMinutesAttachmentsRequest extends TeaModel {
    @NameInMap("contentType")
    public Integer contentType;

    @NameInMap("direction")
    public Integer direction;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("type")
    public Integer type;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListMinutesAttachmentsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMinutesAttachmentsRequest self = new ListMinutesAttachmentsRequest();
        return TeaModel.build(map, self);
    }

    public ListMinutesAttachmentsRequest setContentType(Integer contentType) {
        this.contentType = contentType;
        return this;
    }
    public Integer getContentType() {
        return this.contentType;
    }

    public ListMinutesAttachmentsRequest setDirection(Integer direction) {
        this.direction = direction;
        return this;
    }
    public Integer getDirection() {
        return this.direction;
    }

    public ListMinutesAttachmentsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListMinutesAttachmentsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListMinutesAttachmentsRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public ListMinutesAttachmentsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
