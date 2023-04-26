// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddLibraryRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("openTeamIds")
    public java.util.List<String> openTeamIds;

    @NameInMap("source")
    public String source;

    @NameInMap("sourcePrimaryKey")
    public String sourcePrimaryKey;

    @NameInMap("title")
    public String title;

    @NameInMap("type")
    public String type;

    @NameInMap("userId")
    public String userId;

    public static AddLibraryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddLibraryRequest self = new AddLibraryRequest();
        return TeaModel.build(map, self);
    }

    public AddLibraryRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AddLibraryRequest setOpenTeamIds(java.util.List<String> openTeamIds) {
        this.openTeamIds = openTeamIds;
        return this;
    }
    public java.util.List<String> getOpenTeamIds() {
        return this.openTeamIds;
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

    public AddLibraryRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddLibraryRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public AddLibraryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
