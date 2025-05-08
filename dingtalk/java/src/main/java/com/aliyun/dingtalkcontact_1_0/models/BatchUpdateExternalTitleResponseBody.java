// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateExternalTitleResponseBody extends TeaModel {
    @NameInMap("result")
    public BatchUpdateExternalTitleResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static BatchUpdateExternalTitleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateExternalTitleResponseBody self = new BatchUpdateExternalTitleResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateExternalTitleResponseBody setResult(BatchUpdateExternalTitleResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchUpdateExternalTitleResponseBodyResult getResult() {
        return this.result;
    }

    public BatchUpdateExternalTitleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchUpdateExternalTitleResponseBodyResultFailedList extends TeaModel {
        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        public static BatchUpdateExternalTitleResponseBodyResultFailedList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateExternalTitleResponseBodyResultFailedList self = new BatchUpdateExternalTitleResponseBodyResultFailedList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateExternalTitleResponseBodyResultFailedList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchUpdateExternalTitleResponseBodyResultFailedList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class BatchUpdateExternalTitleResponseBodyResultModifyList extends TeaModel {
        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        public static BatchUpdateExternalTitleResponseBodyResultModifyList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateExternalTitleResponseBodyResultModifyList self = new BatchUpdateExternalTitleResponseBodyResultModifyList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateExternalTitleResponseBodyResultModifyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchUpdateExternalTitleResponseBodyResultModifyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class BatchUpdateExternalTitleResponseBodyResult extends TeaModel {
        @NameInMap("failedList")
        public java.util.List<BatchUpdateExternalTitleResponseBodyResultFailedList> failedList;

        @NameInMap("modifyList")
        public java.util.List<BatchUpdateExternalTitleResponseBodyResultModifyList> modifyList;

        @NameInMap("modifyUser")
        public String modifyUser;

        public static BatchUpdateExternalTitleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateExternalTitleResponseBodyResult self = new BatchUpdateExternalTitleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchUpdateExternalTitleResponseBodyResult setFailedList(java.util.List<BatchUpdateExternalTitleResponseBodyResultFailedList> failedList) {
            this.failedList = failedList;
            return this;
        }
        public java.util.List<BatchUpdateExternalTitleResponseBodyResultFailedList> getFailedList() {
            return this.failedList;
        }

        public BatchUpdateExternalTitleResponseBodyResult setModifyList(java.util.List<BatchUpdateExternalTitleResponseBodyResultModifyList> modifyList) {
            this.modifyList = modifyList;
            return this;
        }
        public java.util.List<BatchUpdateExternalTitleResponseBodyResultModifyList> getModifyList() {
            return this.modifyList;
        }

        public BatchUpdateExternalTitleResponseBodyResult setModifyUser(String modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public String getModifyUser() {
            return this.modifyUser;
        }

    }

}
