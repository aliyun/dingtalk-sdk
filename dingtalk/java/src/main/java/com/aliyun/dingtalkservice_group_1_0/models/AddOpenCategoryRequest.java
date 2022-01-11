// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryRequest extends TeaModel {
    // 所属知识库ID
    @NameInMap("libraryId")
    public Long libraryId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 父类目ID(为0代表顶层id)
    @NameInMap("parentId")
    public Long parentId;

    // 类目标题
    @NameInMap("title")
    public String title;

    // 员工/用户ID
    @NameInMap("userId")
    public String userId;

    // 用户昵称或姓名
    @NameInMap("userName")
    public String userName;

    public static AddOpenCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOpenCategoryRequest self = new AddOpenCategoryRequest();
        return TeaModel.build(map, self);
    }

    public AddOpenCategoryRequest setLibraryId(Long libraryId) {
        this.libraryId = libraryId;
        return this;
    }
    public Long getLibraryId() {
        return this.libraryId;
    }

    public AddOpenCategoryRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddOpenCategoryRequest setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public AddOpenCategoryRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
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

}
