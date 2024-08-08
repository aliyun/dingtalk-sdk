// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabDataRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>PROC-62829702-A377-42A9-9CB3-E1C691A0CEDB</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <strong>example:</strong>
     * <p>OpenDataField_OV2K4SOW2ZGG</p>
     */
    @NameInMap("relatedField")
    public String relatedField;

    /**
     * <strong>example:</strong>
     * <p>u_dxcugzT0aPQvcK2PIkzQ00841721291058</p>
     */
    @NameInMap("relatedInstId")
    public String relatedInstId;

    /**
     * <strong>example:</strong>
     * <p>manager6034</p>
     */
    @NameInMap("viewUserId")
    public String viewUserId;

    public static GetRelatedViewTabDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabDataRequest self = new GetRelatedViewTabDataRequest();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabDataRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public GetRelatedViewTabDataRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetRelatedViewTabDataRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetRelatedViewTabDataRequest setRelatedField(String relatedField) {
        this.relatedField = relatedField;
        return this;
    }
    public String getRelatedField() {
        return this.relatedField;
    }

    public GetRelatedViewTabDataRequest setRelatedInstId(String relatedInstId) {
        this.relatedInstId = relatedInstId;
        return this;
    }
    public String getRelatedInstId() {
        return this.relatedInstId;
    }

    public GetRelatedViewTabDataRequest setViewUserId(String viewUserId) {
        this.viewUserId = viewUserId;
        return this;
    }
    public String getViewUserId() {
        return this.viewUserId;
    }

}
