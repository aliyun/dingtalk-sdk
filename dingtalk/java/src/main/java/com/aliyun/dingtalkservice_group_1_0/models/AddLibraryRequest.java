// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddLibraryRequest extends TeaModel {
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // 团队id列表
    @NameInMap("openTeamIds")
    public java.util.List<String> openTeamIds;

    // 知识库名称
    @NameInMap("title")
    public String title;

    // 知识库描述
    @NameInMap("description")
    public String description;

    // 知识库类型 INTERNAL:内部知识库 EXTERNAL:外部知识库
    @NameInMap("type")
    public String type;

    // 知识来源
    @NameInMap("source")
    public String source;

    // 知识库的唯一性标识
    @NameInMap("sourcePrimaryKey")
    public String sourcePrimaryKey;

    // 员工ID
    @NameInMap("userId")
    public String userId;

    public static AddLibraryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddLibraryRequest self = new AddLibraryRequest();
        return TeaModel.build(map, self);
    }

    public AddLibraryRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public AddLibraryRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public AddLibraryRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public AddLibraryRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public AddLibraryRequest setOpenTeamIds(java.util.List<String> openTeamIds) {
        this.openTeamIds = openTeamIds;
        return this;
    }
    public java.util.List<String> getOpenTeamIds() {
        return this.openTeamIds;
    }

    public AddLibraryRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddLibraryRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AddLibraryRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public AddLibraryRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public AddLibraryRequest setSourcePrimaryKey(String sourcePrimaryKey) {
        this.sourcePrimaryKey = sourcePrimaryKey;
        return this;
    }
    public String getSourcePrimaryKey() {
        return this.sourcePrimaryKey;
    }

    public AddLibraryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
