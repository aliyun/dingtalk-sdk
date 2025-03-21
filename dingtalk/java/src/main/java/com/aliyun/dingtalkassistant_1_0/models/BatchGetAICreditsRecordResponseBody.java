// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class BatchGetAICreditsRecordResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<BatchGetAICreditsRecordResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static BatchGetAICreditsRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetAICreditsRecordResponseBody self = new BatchGetAICreditsRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetAICreditsRecordResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public BatchGetAICreditsRecordResponseBody setList(java.util.List<BatchGetAICreditsRecordResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<BatchGetAICreditsRecordResponseBodyList> getList() {
        return this.list;
    }

    public BatchGetAICreditsRecordResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public BatchGetAICreditsRecordResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class BatchGetAICreditsRecordResponseBodyList extends TeaModel {
        @NameInMap("actionNames")
        public String actionNames;

        @NameInMap("assistantId")
        public String assistantId;

        @NameInMap("assistantName")
        public String assistantName;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("requestId")
        public String requestId;

        @NameInMap("time")
        public String time;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("usedNum")
        public Double usedNum;

        @NameInMap("userName")
        public String userName;

        public static BatchGetAICreditsRecordResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            BatchGetAICreditsRecordResponseBodyList self = new BatchGetAICreditsRecordResponseBodyList();
            return TeaModel.build(map, self);
        }

        public BatchGetAICreditsRecordResponseBodyList setActionNames(String actionNames) {
            this.actionNames = actionNames;
            return this;
        }
        public String getActionNames() {
            return this.actionNames;
        }

        public BatchGetAICreditsRecordResponseBodyList setAssistantId(String assistantId) {
            this.assistantId = assistantId;
            return this;
        }
        public String getAssistantId() {
            return this.assistantId;
        }

        public BatchGetAICreditsRecordResponseBodyList setAssistantName(String assistantName) {
            this.assistantName = assistantName;
            return this;
        }
        public String getAssistantName() {
            return this.assistantName;
        }

        public BatchGetAICreditsRecordResponseBodyList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public BatchGetAICreditsRecordResponseBodyList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public BatchGetAICreditsRecordResponseBodyList setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public BatchGetAICreditsRecordResponseBodyList setTime(String time) {
            this.time = time;
            return this;
        }
        public String getTime() {
            return this.time;
        }

        public BatchGetAICreditsRecordResponseBodyList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public BatchGetAICreditsRecordResponseBodyList setUsedNum(Double usedNum) {
            this.usedNum = usedNum;
            return this;
        }
        public Double getUsedNum() {
            return this.usedNum;
        }

        public BatchGetAICreditsRecordResponseBodyList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
