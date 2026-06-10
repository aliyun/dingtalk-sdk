// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ListWorkflowsResponseBody extends TeaModel {
    @NameInMap("total")
    public Integer total;

    @NameInMap("workflows")
    public java.util.List<ListWorkflowsResponseBodyWorkflows> workflows;

    public static ListWorkflowsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListWorkflowsResponseBody self = new ListWorkflowsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListWorkflowsResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public ListWorkflowsResponseBody setWorkflows(java.util.List<ListWorkflowsResponseBodyWorkflows> workflows) {
        this.workflows = workflows;
        return this;
    }
    public java.util.List<ListWorkflowsResponseBodyWorkflows> getWorkflows() {
        return this.workflows;
    }

    public static class ListWorkflowsResponseBodyWorkflows extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("flowId")
        public String flowId;

        @NameInMap("name")
        public String name;

        @NameInMap("status")
        public String status;

        @NameInMap("versionId")
        public String versionId;

        public static ListWorkflowsResponseBodyWorkflows build(java.util.Map<String, ?> map) throws Exception {
            ListWorkflowsResponseBodyWorkflows self = new ListWorkflowsResponseBodyWorkflows();
            return TeaModel.build(map, self);
        }

        public ListWorkflowsResponseBodyWorkflows setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListWorkflowsResponseBodyWorkflows setFlowId(String flowId) {
            this.flowId = flowId;
            return this;
        }
        public String getFlowId() {
            return this.flowId;
        }

        public ListWorkflowsResponseBodyWorkflows setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListWorkflowsResponseBodyWorkflows setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListWorkflowsResponseBodyWorkflows setVersionId(String versionId) {
            this.versionId = versionId;
            return this;
        }
        public String getVersionId() {
            return this.versionId;
        }

    }

}
