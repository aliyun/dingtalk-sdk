// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryRequest extends TeaModel {
    @NameInMap("libraryId")
    public Long libraryId;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("parentId")
    public Long parentId;

    @NameInMap("title")
    public String title;

    @NameInMap("userId")
    public String userId;

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
