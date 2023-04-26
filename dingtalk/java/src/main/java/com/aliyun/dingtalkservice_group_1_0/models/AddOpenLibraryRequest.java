// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenLibraryRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("source")
    public String source;

    @NameInMap("title")
    public String title;

    @NameInMap("type")
    public String type;

    @NameInMap("userId")
    public String userId;

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
