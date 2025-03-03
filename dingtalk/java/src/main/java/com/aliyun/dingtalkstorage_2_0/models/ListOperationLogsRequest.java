// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ListOperationLogsRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("option")
    public ListOperationLogsRequestOption option;

    @NameInMap("startTime")
    public Long startTime;

    public static ListOperationLogsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListOperationLogsRequest self = new ListOperationLogsRequest();
        return TeaModel.build(map, self);
    }

    public ListOperationLogsRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ListOperationLogsRequest setOption(ListOperationLogsRequestOption option) {
        this.option = option;
        return this;
    }
    public ListOperationLogsRequestOption getOption() {
        return this.option;
    }

    public ListOperationLogsRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public static class ListOperationLogsRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>下载:download_file</p>
         */
        @NameInMap("actions")
        public java.util.List<String> actions;

        /**
         * <strong>example:</strong>
         * <p>30</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <strong>example:</strong>
         * <p>next_token</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <strong>example:</strong>
         * <p>union_id</p>
         */
        @NameInMap("operatorId")
        public String operatorId;

        /**
         * <strong>example:</strong>
         * <p>知识库:org_biz_meta</p>
         */
        @NameInMap("scenes")
        public java.util.List<String> scenes;

        /**
         * <strong>example:</strong>
         * <p>YndMj49yWj95B3qAfGz5pY9d83pmz5aA</p>
         */
        @NameInMap("subjectId")
        public String subjectId;

        public static ListOperationLogsRequestOption build(java.util.Map<String, ?> map) throws Exception {
            ListOperationLogsRequestOption self = new ListOperationLogsRequestOption();
            return TeaModel.build(map, self);
        }

        public ListOperationLogsRequestOption setActions(java.util.List<String> actions) {
            this.actions = actions;
            return this;
        }
        public java.util.List<String> getActions() {
            return this.actions;
        }

        public ListOperationLogsRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public ListOperationLogsRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public ListOperationLogsRequestOption setOperatorId(String operatorId) {
            this.operatorId = operatorId;
            return this;
        }
        public String getOperatorId() {
            return this.operatorId;
        }

        public ListOperationLogsRequestOption setScenes(java.util.List<String> scenes) {
            this.scenes = scenes;
            return this;
        }
        public java.util.List<String> getScenes() {
            return this.scenes;
        }

        public ListOperationLogsRequestOption setSubjectId(String subjectId) {
            this.subjectId = subjectId;
            return this;
        }
        public String getSubjectId() {
            return this.subjectId;
        }

    }

}
