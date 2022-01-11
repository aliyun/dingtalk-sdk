// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenLibraryRequest extends TeaModel {
    // 知识库描述
    @NameInMap("description")
    public String description;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 知识库来源
    @NameInMap("source")
    public String source;

    // 知识库名称
    @NameInMap("title")
    public String title;

    // 知识库类型
    @NameInMap("type")
    public String type;

    // 用户/员工ID
    @NameInMap("userId")
    public String userId;

    // 用户昵称或姓名
    @NameInMap("userName")
    public String userName;

    public static AddOpenLibraryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOpenLibraryRequest self = new AddOpenLibraryRequest();
        return TeaModel.build(map, self);
    }

    public AddOpenLibraryRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AddOpenLibraryRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddOpenLibraryRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public AddOpenLibraryRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddOpenLibraryRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public AddOpenLibraryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public AddOpenLibraryRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

}
