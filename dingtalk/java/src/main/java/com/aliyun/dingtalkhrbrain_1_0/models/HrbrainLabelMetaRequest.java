// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaRequest extends TeaModel {
    @NameInMap("categoryCodes")
    public java.util.List<String> categoryCodes;

    @NameInMap("gmtModifiedEnd")
    public String gmtModifiedEnd;

    @NameInMap("gmtModifiedStart")
    public String gmtModifiedStart;

    @NameInMap("labelCode")
    public String labelCode;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static HrbrainLabelMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaRequest self = new HrbrainLabelMetaRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaRequest setCategoryCodes(java.util.List<String> categoryCodes) {
        this.categoryCodes = categoryCodes;
        return this;
    }
    public java.util.List<String> getCategoryCodes() {
        return this.categoryCodes;
    }

    public HrbrainLabelMetaRequest setGmtModifiedEnd(String gmtModifiedEnd) {
        this.gmtModifiedEnd = gmtModifiedEnd;
        return this;
    }
    public String getGmtModifiedEnd() {
        return this.gmtModifiedEnd;
    }

    public HrbrainLabelMetaRequest setGmtModifiedStart(String gmtModifiedStart) {
        this.gmtModifiedStart = gmtModifiedStart;
        return this;
    }
    public String getGmtModifiedStart() {
        return this.gmtModifiedStart;
    }

    public HrbrainLabelMetaRequest setLabelCode(String labelCode) {
        this.labelCode = labelCode;
        return this;
    }
    public String getLabelCode() {
        return this.labelCode;
    }

    public HrbrainLabelMetaRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public HrbrainLabelMetaRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
