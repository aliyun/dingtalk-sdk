// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddWorkspaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>workspace_name</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("option")
    public AddWorkspaceRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static AddWorkspaceRequest build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspaceRequest self = new AddWorkspaceRequest();
        return TeaModel.build(map, self);
    }

    public AddWorkspaceRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddWorkspaceRequest setOption(AddWorkspaceRequestOption option) {
        this.option = option;
        return this;
    }
    public AddWorkspaceRequestOption getOption() {
        return this.option;
    }

    public AddWorkspaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class AddWorkspaceRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>workspace_description</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>team_id</p>
         */
        @NameInMap("teamId")
        public String teamId;

        public static AddWorkspaceRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddWorkspaceRequestOption self = new AddWorkspaceRequestOption();
            return TeaModel.build(map, self);
        }

        public AddWorkspaceRequestOption setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AddWorkspaceRequestOption setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

    }

}
