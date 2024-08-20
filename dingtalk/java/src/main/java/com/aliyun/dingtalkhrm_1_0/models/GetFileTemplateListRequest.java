// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetFileTemplateListRequest extends TeaModel {
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CONTRACT</p>
     */
    @NameInMap("signSource")
    public String signSource;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("templateStatus")
    public Integer templateStatus;

    @NameInMap("templateTypeList")
    public java.util.List<String> templateTypeList;

    public static GetFileTemplateListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileTemplateListRequest self = new GetFileTemplateListRequest();
        return TeaModel.build(map, self);
    }

    public GetFileTemplateListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetFileTemplateListRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetFileTemplateListRequest setSignSource(String signSource) {
        this.signSource = signSource;
        return this;
    }
    public String getSignSource() {
        return this.signSource;
    }

    public GetFileTemplateListRequest setTemplateStatus(Integer templateStatus) {
        this.templateStatus = templateStatus;
        return this;
    }
    public Integer getTemplateStatus() {
        return this.templateStatus;
    }

    public GetFileTemplateListRequest setTemplateTypeList(java.util.List<String> templateTypeList) {
        this.templateTypeList = templateTypeList;
        return this;
    }
    public java.util.List<String> getTemplateTypeList() {
        return this.templateTypeList;
    }

}
