// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumQueryTodoTasksByManagerResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumQueryTodoTasksByManagerResponseBodyResult result;

    public static PremiumQueryTodoTasksByManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumQueryTodoTasksByManagerResponseBody self = new PremiumQueryTodoTasksByManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumQueryTodoTasksByManagerResponseBody setResult(PremiumQueryTodoTasksByManagerResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumQueryTodoTasksByManagerResponseBodyResult getResult() {
        return this.result;
    }

    public static class PremiumQueryTodoTasksByManagerResponseBodyResultList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>RUNNING</p>
         */
        @NameInMap("businessId")
        public String businessId;

        @NameInMap("canRedirect")
        public Boolean canRedirect;

        @NameInMap("createTime")
        public Long createTime;

        /**
         * <strong>example:</strong>
         * <p>act_0001</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <strong>example:</strong>
         * <p>Siw2WNVZS4KiUt3tTmaNKg04*****809950</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>manager001</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>2022-10-17T15:12Z</p>
         */
        @NameInMap("userId")
        public String userId;

        public static PremiumQueryTodoTasksByManagerResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            PremiumQueryTodoTasksByManagerResponseBodyResultList self = new PremiumQueryTodoTasksByManagerResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setCanRedirect(Boolean canRedirect) {
            this.canRedirect = canRedirect;
            return this;
        }
        public Boolean getCanRedirect() {
            return this.canRedirect;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResultList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class PremiumQueryTodoTasksByManagerResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<PremiumQueryTodoTasksByManagerResponseBodyResultList> list;

        public static PremiumQueryTodoTasksByManagerResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumQueryTodoTasksByManagerResponseBodyResult self = new PremiumQueryTodoTasksByManagerResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public PremiumQueryTodoTasksByManagerResponseBodyResult setList(java.util.List<PremiumQueryTodoTasksByManagerResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<PremiumQueryTodoTasksByManagerResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
