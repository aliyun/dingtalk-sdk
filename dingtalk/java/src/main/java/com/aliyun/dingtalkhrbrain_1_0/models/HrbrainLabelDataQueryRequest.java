// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelDataQueryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("labelCode")
    public String labelCode;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static HrbrainLabelDataQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelDataQueryRequest self = new HrbrainLabelDataQueryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelDataQueryRequest setLabelCode(String labelCode) {
        this.labelCode = labelCode;
        return this;
    }
    public String getLabelCode() {
        return this.labelCode;
    }

    public HrbrainLabelDataQueryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public HrbrainLabelDataQueryRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
