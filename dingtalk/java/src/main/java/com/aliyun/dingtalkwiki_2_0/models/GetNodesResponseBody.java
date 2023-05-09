// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetNodesResponseBody extends TeaModel {
    @NameInMap("nodes")
    public java.util.List<GetNodesResponseBodyNodes> nodes;

    public static GetNodesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNodesResponseBody self = new GetNodesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNodesResponseBody setNodes(java.util.List<GetNodesResponseBodyNodes> nodes) {
        this.nodes = nodes;
        return this;
    }
    public java.util.List<GetNodesResponseBodyNodes> getNodes() {
        return this.nodes;
    }

    public static class GetNodesResponseBodyNodesStatisticalInfo extends TeaModel {
        @NameInMap("wordCount")
        public Long wordCount;

        public static GetNodesResponseBodyNodesStatisticalInfo build(java.util.Map<String, ?> map) throws Exception {
            GetNodesResponseBodyNodesStatisticalInfo self = new GetNodesResponseBodyNodesStatisticalInfo();
            return TeaModel.build(map, self);
        }

        public GetNodesResponseBodyNodesStatisticalInfo setWordCount(Long wordCount) {
            this.wordCount = wordCount;
            return this;
        }
        public Long getWordCount() {
            return this.wordCount;
        }

    }

    public static class GetNodesResponseBodyNodes extends TeaModel {
        @NameInMap("category")
        public String category;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("extension")
        public String extension;

        @NameInMap("hasChildren")
        public Boolean hasChildren;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

        @NameInMap("nodeId")
        public String nodeId;

        @NameInMap("permissionRole")
        public String permissionRole;

        @NameInMap("size")
        public Long size;

        @NameInMap("statisticalInfo")
        public GetNodesResponseBodyNodesStatisticalInfo statisticalInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        @NameInMap("workspaceId")
        public String workspaceId;

        public static GetNodesResponseBodyNodes build(java.util.Map<String, ?> map) throws Exception {
            GetNodesResponseBodyNodes self = new GetNodesResponseBodyNodes();
            return TeaModel.build(map, self);
        }

        public GetNodesResponseBodyNodes setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public GetNodesResponseBodyNodes setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetNodesResponseBodyNodes setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetNodesResponseBodyNodes setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public GetNodesResponseBodyNodes setHasChildren(Boolean hasChildren) {
            this.hasChildren = hasChildren;
            return this;
        }
        public Boolean getHasChildren() {
            return this.hasChildren;
        }

        public GetNodesResponseBodyNodes setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetNodesResponseBodyNodes setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetNodesResponseBodyNodes setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetNodesResponseBodyNodes setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetNodesResponseBodyNodes setPermissionRole(String permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public String getPermissionRole() {
            return this.permissionRole;
        }

        public GetNodesResponseBodyNodes setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public GetNodesResponseBodyNodes setStatisticalInfo(GetNodesResponseBodyNodesStatisticalInfo statisticalInfo) {
            this.statisticalInfo = statisticalInfo;
            return this;
        }
        public GetNodesResponseBodyNodesStatisticalInfo getStatisticalInfo() {
            return this.statisticalInfo;
        }

        public GetNodesResponseBodyNodes setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetNodesResponseBodyNodes setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetNodesResponseBodyNodes setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
