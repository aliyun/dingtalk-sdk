// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaRequest extends TeaModel {
    @NameInMap("categoryCodes")
    public java.util.List<String> categoryCodes;

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
