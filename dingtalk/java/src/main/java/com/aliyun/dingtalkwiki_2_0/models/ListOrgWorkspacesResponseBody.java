// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class ListOrgWorkspacesResponseBody extends TeaModel {
    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("workspaces")
    public java.util.List<ListOrgWorkspacesResponseBodyWorkspaces> workspaces;

    public static ListOrgWorkspacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOrgWorkspacesResponseBody self = new ListOrgWorkspacesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOrgWorkspacesResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListOrgWorkspacesResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListOrgWorkspacesResponseBody setWorkspaces(java.util.List<ListOrgWorkspacesResponseBodyWorkspaces> workspaces) {
        this.workspaces = workspaces;
        return this;
    }
    public java.util.List<ListOrgWorkspacesResponseBodyWorkspaces> getWorkspaces() {
        return this.workspaces;
    }

    public static class ListOrgWorkspacesResponseBodyWorkspaces extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>workspace_id</p>
         */
        @NameInMap("rootDentryUuid")
        public String rootDentryUuid;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <strong>example:</strong>
         * <p>url</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>workspace_id</p>
         */
        @NameInMap("workspaceId")
        public String workspaceId;

        /**
         * <strong>example:</strong>
         * <p>workspace_name</p>
         */
        @NameInMap("workspaceName")
        public String workspaceName;

        public static ListOrgWorkspacesResponseBodyWorkspaces build(java.util.Map<String, ?> map) throws Exception {
            ListOrgWorkspacesResponseBodyWorkspaces self = new ListOrgWorkspacesResponseBodyWorkspaces();
            return TeaModel.build(map, self);
        }

        public ListOrgWorkspacesResponseBodyWorkspaces setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListOrgWorkspacesResponseBodyWorkspaces setRootDentryUuid(String rootDentryUuid) {
            this.rootDentryUuid = rootDentryUuid;
            return this;
        }
        public String getRootDentryUuid() {
            return this.rootDentryUuid;
        }

        public ListOrgWorkspacesResponseBodyWorkspaces setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public ListOrgWorkspacesResponseBodyWorkspaces setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public ListOrgWorkspacesResponseBodyWorkspaces setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public ListOrgWorkspacesResponseBodyWorkspaces setWorkspaceName(String workspaceName) {
            this.workspaceName = workspaceName;
            return this;
        }
        public String getWorkspaceName() {
            return this.workspaceName;
        }

    }

}
