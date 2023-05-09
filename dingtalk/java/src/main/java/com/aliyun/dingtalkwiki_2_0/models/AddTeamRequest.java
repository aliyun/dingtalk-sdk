// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddTeamRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("option")
    public AddTeamRequestOption option;

    @NameInMap("operatorId")
    public String operatorId;

    public static AddTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        AddTeamRequest self = new AddTeamRequest();
        return TeaModel.build(map, self);
    }

    public AddTeamRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddTeamRequest setOption(AddTeamRequestOption option) {
        this.option = option;
        return this;
    }
    public AddTeamRequestOption getOption() {
        return this.option;
    }

    public AddTeamRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class AddTeamRequestOptionIcon extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static AddTeamRequestOptionIcon build(java.util.Map<String, ?> map) throws Exception {
            AddTeamRequestOptionIcon self = new AddTeamRequestOptionIcon();
            return TeaModel.build(map, self);
        }

        public AddTeamRequestOptionIcon setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public AddTeamRequestOptionIcon setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AddTeamRequestOption extends TeaModel {
        @NameInMap("cover")
        public String cover;

        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public AddTeamRequestOptionIcon icon;

        public static AddTeamRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddTeamRequestOption self = new AddTeamRequestOption();
            return TeaModel.build(map, self);
        }

        public AddTeamRequestOption setCover(String cover) {
            this.cover = cover;
            return this;
        }
        public String getCover() {
            return this.cover;
        }

        public AddTeamRequestOption setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AddTeamRequestOption setIcon(AddTeamRequestOptionIcon icon) {
            this.icon = icon;
            return this;
        }
        public AddTeamRequestOptionIcon getIcon() {
            return this.icon;
        }

    }

}
