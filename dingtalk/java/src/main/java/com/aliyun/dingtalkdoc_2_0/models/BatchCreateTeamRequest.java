// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class BatchCreateTeamRequest extends TeaModel {
    @NameInMap("param")
    public BatchCreateTeamRequestParam param;

    @NameInMap("operatorId")
    public String operatorId;

    public static BatchCreateTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateTeamRequest self = new BatchCreateTeamRequest();
        return TeaModel.build(map, self);
    }

    public BatchCreateTeamRequest setParam(BatchCreateTeamRequestParam param) {
        this.param = param;
        return this;
    }
    public BatchCreateTeamRequestParam getParam() {
        return this.param;
    }

    public BatchCreateTeamRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class BatchCreateTeamRequestParamCreateTeamParamList extends TeaModel {
        @NameInMap("adminUnionIdList")
        public java.util.List<String> adminUnionIdList;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("deptId")
        public String deptId;

        @NameInMap("teamName")
        public String teamName;

        public static BatchCreateTeamRequestParamCreateTeamParamList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateTeamRequestParamCreateTeamParamList self = new BatchCreateTeamRequestParamCreateTeamParamList();
            return TeaModel.build(map, self);
        }

        public BatchCreateTeamRequestParamCreateTeamParamList setAdminUnionIdList(java.util.List<String> adminUnionIdList) {
            this.adminUnionIdList = adminUnionIdList;
            return this;
        }
        public java.util.List<String> getAdminUnionIdList() {
            return this.adminUnionIdList;
        }

        public BatchCreateTeamRequestParamCreateTeamParamList setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public BatchCreateTeamRequestParamCreateTeamParamList setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public BatchCreateTeamRequestParamCreateTeamParamList setTeamName(String teamName) {
            this.teamName = teamName;
            return this;
        }
        public String getTeamName() {
            return this.teamName;
        }

    }

    public static class BatchCreateTeamRequestParam extends TeaModel {
        @NameInMap("createTeamParamList")
        public java.util.List<BatchCreateTeamRequestParamCreateTeamParamList> createTeamParamList;

        public static BatchCreateTeamRequestParam build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateTeamRequestParam self = new BatchCreateTeamRequestParam();
            return TeaModel.build(map, self);
        }

        public BatchCreateTeamRequestParam setCreateTeamParamList(java.util.List<BatchCreateTeamRequestParamCreateTeamParamList> createTeamParamList) {
            this.createTeamParamList = createTeamParamList;
            return this;
        }
        public java.util.List<BatchCreateTeamRequestParamCreateTeamParamList> getCreateTeamParamList() {
            return this.createTeamParamList;
        }

    }

}
