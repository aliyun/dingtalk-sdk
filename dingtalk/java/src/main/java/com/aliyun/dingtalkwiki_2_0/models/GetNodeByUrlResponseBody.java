// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetNodeByUrlResponseBody extends TeaModel {
    @NameInMap("node")
    public GetNodeByUrlResponseBodyNode node;

    public static GetNodeByUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNodeByUrlResponseBody self = new GetNodeByUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNodeByUrlResponseBody setNode(GetNodeByUrlResponseBodyNode node) {
        this.node = node;
        return this;
    }
    public GetNodeByUrlResponseBodyNode getNode() {
        return this.node;
    }

    public static class GetNodeByUrlResponseBodyNodeStatisticalInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("wordCount")
        public Long wordCount;

        public static GetNodeByUrlResponseBodyNodeStatisticalInfo build(java.util.Map<String, ?> map) throws Exception {
            GetNodeByUrlResponseBodyNodeStatisticalInfo self = new GetNodeByUrlResponseBodyNodeStatisticalInfo();
            return TeaModel.build(map, self);
        }

        public GetNodeByUrlResponseBodyNodeStatisticalInfo setWordCount(Long wordCount) {
            this.wordCount = wordCount;
            return this;
        }
        public Long getWordCount() {
            return this.wordCount;
        }

    }

    public static class GetNodeByUrlResponseBodyNode extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ALIDOC</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <strong>example:</strong>
         * <p>node_create_time</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>node_creator_id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>adoc</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("hasChildren")
        public Boolean hasChildren;

        /**
         * <strong>example:</strong>
         * <p>node_modified_time</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <strong>example:</strong>
         * <p>node_modifier_id</p>
         */
        @NameInMap("modifierId")
        public String modifierId;

        /**
         * <strong>example:</strong>
         * <p>node_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>node_id</p>
         */
        @NameInMap("nodeId")
        public String nodeId;

        /**
         * <strong>example:</strong>
         * <p>READER</p>
         */
        @NameInMap("permissionRole")
        public String permissionRole;

        /**
         * <strong>example:</strong>
         * <p>512</p>
         */
        @NameInMap("size")
        public Long size;

        @NameInMap("statisticalInfo")
        public GetNodeByUrlResponseBodyNodeStatisticalInfo statisticalInfo;

        /**
         * <strong>example:</strong>
         * <p>FILE</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>node_url</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>workspace_id</p>
         */
        @NameInMap("workspaceId")
        public String workspaceId;

        public static GetNodeByUrlResponseBodyNode build(java.util.Map<String, ?> map) throws Exception {
            GetNodeByUrlResponseBodyNode self = new GetNodeByUrlResponseBodyNode();
            return TeaModel.build(map, self);
        }

        public GetNodeByUrlResponseBodyNode setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public GetNodeByUrlResponseBodyNode setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetNodeByUrlResponseBodyNode setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetNodeByUrlResponseBodyNode setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public GetNodeByUrlResponseBodyNode setHasChildren(Boolean hasChildren) {
            this.hasChildren = hasChildren;
            return this;
        }
        public Boolean getHasChildren() {
            return this.hasChildren;
        }

        public GetNodeByUrlResponseBodyNode setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetNodeByUrlResponseBodyNode setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetNodeByUrlResponseBodyNode setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetNodeByUrlResponseBodyNode setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetNodeByUrlResponseBodyNode setPermissionRole(String permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public String getPermissionRole() {
            return this.permissionRole;
        }

        public GetNodeByUrlResponseBodyNode setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public GetNodeByUrlResponseBodyNode setStatisticalInfo(GetNodeByUrlResponseBodyNodeStatisticalInfo statisticalInfo) {
            this.statisticalInfo = statisticalInfo;
            return this;
        }
        public GetNodeByUrlResponseBodyNodeStatisticalInfo getStatisticalInfo() {
            return this.statisticalInfo;
        }

        public GetNodeByUrlResponseBodyNode setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetNodeByUrlResponseBodyNode setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetNodeByUrlResponseBodyNode setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
