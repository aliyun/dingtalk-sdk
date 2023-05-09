// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetNodesRequest extends TeaModel {
    @NameInMap("nodeIds")
    public java.util.List<String> nodeIds;

    @NameInMap("option")
    public GetNodesRequestOption option;

    @NameInMap("operatorId")
    public String operatorId;

    public static GetNodesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetNodesRequest self = new GetNodesRequest();
        return TeaModel.build(map, self);
    }

    public GetNodesRequest setNodeIds(java.util.List<String> nodeIds) {
        this.nodeIds = nodeIds;
        return this;
    }
    public java.util.List<String> getNodeIds() {
        return this.nodeIds;
    }

    public GetNodesRequest setOption(GetNodesRequestOption option) {
        this.option = option;
        return this;
    }
    public GetNodesRequestOption getOption() {
        return this.option;
    }

    public GetNodesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class GetNodesRequestOption extends TeaModel {
        @NameInMap("withPermissionRole")
        public Boolean withPermissionRole;

        @NameInMap("withStatisticalInfo")
        public Boolean withStatisticalInfo;

        public static GetNodesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetNodesRequestOption self = new GetNodesRequestOption();
            return TeaModel.build(map, self);
        }

        public GetNodesRequestOption setWithPermissionRole(Boolean withPermissionRole) {
            this.withPermissionRole = withPermissionRole;
            return this;
        }
        public Boolean getWithPermissionRole() {
            return this.withPermissionRole;
        }

        public GetNodesRequestOption setWithStatisticalInfo(Boolean withStatisticalInfo) {
            this.withStatisticalInfo = withStatisticalInfo;
            return this;
        }
        public Boolean getWithStatisticalInfo() {
            return this.withStatisticalInfo;
        }

    }

}
