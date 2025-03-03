// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ListOperationLogsResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<ListOperationLogsResponseBodyItems> items;

    /**
     * <strong>example:</strong>
     * <p>next_token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("totalCount")
    public Long totalCount;

    public static ListOperationLogsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOperationLogsResponseBody self = new ListOperationLogsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOperationLogsResponseBody setItems(java.util.List<ListOperationLogsResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<ListOperationLogsResponseBodyItems> getItems() {
        return this.items;
    }

    public ListOperationLogsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListOperationLogsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListOperationLogsResponseBodyItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>add_permission</p>
         */
        @NameInMap("action")
        public String action;

        /**
         * <strong>example:</strong>
         * <p>「我的文档/无标题文档」，给用户“你好”添加了「可编辑」权限</p>
         */
        @NameInMap("details")
        public String details;

        /**
         * <strong>example:</strong>
         * <p>ovEQ1aYDoUrM8NldI7EPaDEuDfNce#AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3&amp;USER:1557011407</p>
         */
        @NameInMap("id")
        public String id;

        @NameInMap("operateTime")
        public Long operateTime;

        /**
         * <strong>example:</strong>
         * <p>union_id</p>
         */
        @NameInMap("operatorId")
        public String operatorId;

        /**
         * <strong>example:</strong>
         * <p>org_biz_meta_my_doc</p>
         */
        @NameInMap("scene")
        public String scene;

        /**
         * <strong>example:</strong>
         * <p>AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3</p>
         */
        @NameInMap("subjectId")
        public String subjectId;

        /**
         * <strong>example:</strong>
         * <p>无标题文档</p>
         */
        @NameInMap("subjectName")
        public String subjectName;

        /**
         * <strong>example:</strong>
         * <p>DENTRY</p>
         */
        @NameInMap("subjectType")
        public String subjectType;

        /**
         * <strong>example:</strong>
         * <p><a href="https://alidocs.dingtalk.com/i/nodes/AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3">https://alidocs.dingtalk.com/i/nodes/AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3</a></p>
         */
        @NameInMap("subjectUrl")
        public String subjectUrl;

        public static ListOperationLogsResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            ListOperationLogsResponseBodyItems self = new ListOperationLogsResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public ListOperationLogsResponseBodyItems setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public ListOperationLogsResponseBodyItems setDetails(String details) {
            this.details = details;
            return this;
        }
        public String getDetails() {
            return this.details;
        }

        public ListOperationLogsResponseBodyItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListOperationLogsResponseBodyItems setOperateTime(Long operateTime) {
            this.operateTime = operateTime;
            return this;
        }
        public Long getOperateTime() {
            return this.operateTime;
        }

        public ListOperationLogsResponseBodyItems setOperatorId(String operatorId) {
            this.operatorId = operatorId;
            return this;
        }
        public String getOperatorId() {
            return this.operatorId;
        }

        public ListOperationLogsResponseBodyItems setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public ListOperationLogsResponseBodyItems setSubjectId(String subjectId) {
            this.subjectId = subjectId;
            return this;
        }
        public String getSubjectId() {
            return this.subjectId;
        }

        public ListOperationLogsResponseBodyItems setSubjectName(String subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public String getSubjectName() {
            return this.subjectName;
        }

        public ListOperationLogsResponseBodyItems setSubjectType(String subjectType) {
            this.subjectType = subjectType;
            return this;
        }
        public String getSubjectType() {
            return this.subjectType;
        }

        public ListOperationLogsResponseBodyItems setSubjectUrl(String subjectUrl) {
            this.subjectUrl = subjectUrl;
            return this;
        }
        public String getSubjectUrl() {
            return this.subjectUrl;
        }

    }

}
