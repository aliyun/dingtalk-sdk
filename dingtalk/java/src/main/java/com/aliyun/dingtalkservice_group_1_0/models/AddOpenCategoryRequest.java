// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // 团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 用户ID
    @NameInMap("userId")
    public String userId;

    // 用户昵称或姓名
    @NameInMap("userName")
    public String userName;

    // 类目标题
    @NameInMap("title")
    public String title;

    // 父类目ID
    @NameInMap("parentId")
    public Long parentId;

    // 所属知识库ID
    @NameInMap("libraryId")
    public Long libraryId;

    public static AddOpenCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOpenCategoryRequest self = new AddOpenCategoryRequest();
        return TeaModel.build(map, self);
    }

    public AddOpenCategoryRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public AddOpenCategoryRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public AddOpenCategoryRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public AddOpenCategoryRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public AddOpenCategoryRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddOpenCategoryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public AddOpenCategoryRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public AddOpenCategoryRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddOpenCategoryRequest setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public AddOpenCategoryRequest setLibraryId(Long libraryId) {
        this.libraryId = libraryId;
        return this;
    }
    public Long getLibraryId() {
        return this.libraryId;
    }

}
