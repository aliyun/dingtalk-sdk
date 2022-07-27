// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateByIdResponseBody extends TeaModel {
    // 模版预览url
    @NameInMap("coverUrl")
    public String coverUrl;

    // 模版创建时间
    @NameInMap("createTime")
    public Long createTime;

    // 模版对应文档类型
    @NameInMap("docType")
    public String docType;

    // 模版id
    @NameInMap("id")
    public String id;

    // 模版类型
    @NameInMap("templateType")
    public String templateType;

    // 模版标题
    @NameInMap("title")
    public String title;

    // 模版修改时间
    @NameInMap("updateTime")
    public Long updateTime;

    // 模版归属空间Id
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
