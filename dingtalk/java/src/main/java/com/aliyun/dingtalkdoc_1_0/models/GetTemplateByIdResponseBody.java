// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateByIdResponseBody extends TeaModel {
    /**
     * <p>模版预览url</p>
     */
    @NameInMap("coverUrl")
    public String coverUrl;

    /**
     * <p>模版创建时间</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>模版对应文档类型</p>
     */
    @NameInMap("docType")
    public String docType;

    /**
     * <p>模版id</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>模版类型</p>
     */
    @NameInMap("templateType")
    public String templateType;

    /**
     * <p>模版标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>模版修改时间</p>
     */
    @NameInMap("updateTime")
    public Long updateTime;

    /**
     * <p>模版归属知识库id。</p>
     */
    @NameInMap("workspaceId")
    public String workspaceId;

    public static GetTemplateByIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTemplateByIdResponseBody self = new GetTemplateByIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTemplateByIdResponseBody setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
    }

    public GetTemplateByIdResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetTemplateByIdResponseBody setDocType(String docType) {
        this.docType = docType;
        return this;
    }
    public String getDocType() {
        return this.docType;
    }

    public GetTemplateByIdResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTemplateByIdResponseBody setTemplateType(String templateType) {
        this.templateType = templateType;
        return this;
    }
    public String getTemplateType() {
        return this.templateType;
    }

    public GetTemplateByIdResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetTemplateByIdResponseBody setUpdateTime(Long updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public Long getUpdateTime() {
        return this.updateTime;
    }

    public GetTemplateByIdResponseBody setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

}
