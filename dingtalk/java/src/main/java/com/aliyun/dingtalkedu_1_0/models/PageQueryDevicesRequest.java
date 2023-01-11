// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryDevicesRequest extends TeaModel {
    /**
     * <p>分页参数-当页最大返回记录数</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>分页参数-页码 起始值:1</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>设备类型</p>
     */
    @NameInMap("type")
    public String type;

    public static PageQueryDevicesRequest build(java.util.Map<String, ?> map) throws Exception {
        PageQueryDevicesRequest self = new PageQueryDevicesRequest();
        return TeaModel.build(map, self);
    }

    public PageQueryDevicesRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public PageQueryDevicesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PageQueryDevicesRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
