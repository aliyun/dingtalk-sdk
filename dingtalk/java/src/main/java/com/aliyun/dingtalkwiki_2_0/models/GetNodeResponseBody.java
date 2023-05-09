// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetNodeResponseBody extends TeaModel {
    @NameInMap("node")
    public GetNodeResponseBodyNode node;

    public static GetNodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNodeResponseBody self = new GetNodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNodeResponseBody setNode(GetNodeResponseBodyNode node) {
        this.node = node;
        return this;
    }
    public GetNodeResponseBodyNode getNode() {
        return this.node;
    }

    public static class GetNodeResponseBodyNodeStatisticalInfo extends TeaModel {
        @NameInMap("wordCount")
        public Long wordCount;

        public static GetNodeResponseBodyNodeStatisticalInfo build(java.util.Map<String, ?> map) throws Exception {
            GetNodeResponseBodyNodeStatisticalInfo self = new GetNodeResponseBodyNodeStatisticalInfo();
            return TeaModel.build(map, self);
        }

        public GetNodeResponseBodyNodeStatisticalInfo setWordCount(Long wordCount) {
            this.wordCount = wordCount;
            return this;
        }
        public Long getWordCount() {
            return this.wordCount;
        }

    }

    public static class GetNodeResponseBodyNode extends TeaModel {
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
        public GetNodeResponseBodyNodeStatisticalInfo statisticalInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        @NameInMap("workspaceId")
        public String workspaceId;

        public static GetNodeResponseBodyNode build(java.util.Map<String, ?> map) throws Exception {
            GetNodeResponseBodyNode self = new GetNodeResponseBodyNode();
            return TeaModel.build(map, self);
        }

        public GetNodeResponseBodyNode setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public GetNodeResponseBodyNode setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetNodeResponseBodyNode setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetNodeResponseBodyNode setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public GetNodeResponseBodyNode setHasChildren(Boolean hasChildren) {
            this.hasChildren = hasChildren;
            return this;
        }
        public Boolean getHasChildren() {
            return this.hasChildren;
        }

        public GetNodeResponseBodyNode setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetNodeResponseBodyNode setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetNodeResponseBodyNode setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetNodeResponseBodyNode setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetNodeResponseBodyNode setPermissionRole(String permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public String getPermissionRole() {
            return this.permissionRole;
        }

        public GetNodeResponseBodyNode setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public GetNodeResponseBodyNode setStatisticalInfo(GetNodeResponseBodyNodeStatisticalInfo statisticalInfo) {
            this.statisticalInfo = statisticalInfo;
            return this;
        }
        public GetNodeResponseBodyNodeStatisticalInfo getStatisticalInfo() {
            return this.statisticalInfo;
        }

        public GetNodeResponseBodyNode setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetNodeResponseBodyNode setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetNodeResponseBodyNode setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
