// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ListTemplateRequest extends TeaModel {
    /**
     * <p>查询模版数量</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>翻页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>操作用户unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>模版类型</p>
     */
    @NameInMap("templateType")
    public String templateType;

    /**
     * <p>知识库id。</p>
     */
    @NameInMap("workspaceId")
    public String workspaceId;

    public static ListTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        ListTemplateRequest self = new ListTemplateRequest();
        return TeaModel.build(map, self);
    }

    public ListTemplateRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListTemplateRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListTemplateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public ListTemplateRequest setTemplateType(String templateType) {
        this.templateType = templateType;
        return this;
    }
    public String getTemplateType() {
        return this.templateType;
    }

    public ListTemplateRequest setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

}
