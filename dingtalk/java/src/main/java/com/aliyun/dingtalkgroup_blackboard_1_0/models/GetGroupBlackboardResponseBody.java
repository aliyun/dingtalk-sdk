// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class GetGroupBlackboardResponseBody extends TeaModel {
    @NameInMap("result")
    public GetGroupBlackboardResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetGroupBlackboardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGroupBlackboardResponseBody self = new GetGroupBlackboardResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGroupBlackboardResponseBody setResult(GetGroupBlackboardResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetGroupBlackboardResponseBodyResult getResult() {
        return this.result;
    }

    public GetGroupBlackboardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetGroupBlackboardResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("dataId")
        public String dataId;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("readCount")
        public Integer readCount;

        @NameInMap("sticky")
        public Boolean sticky;

        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static GetGroupBlackboardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetGroupBlackboardResponseBodyResult self = new GetGroupBlackboardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetGroupBlackboardResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetGroupBlackboardResponseBodyResult setDataId(String dataId) {
            this.dataId = dataId;
            return this;
        }
        public String getDataId() {
            return this.dataId;
        }

        public GetGroupBlackboardResponseBodyResult setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public GetGroupBlackboardResponseBodyResult setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public GetGroupBlackboardResponseBodyResult setReadCount(Integer readCount) {
            this.readCount = readCount;
            return this;
        }
        public Integer getReadCount() {
            return this.readCount;
        }

        public GetGroupBlackboardResponseBodyResult setSticky(Boolean sticky) {
            this.sticky = sticky;
            return this;
        }
        public Boolean getSticky() {
            return this.sticky;
        }

        public GetGroupBlackboardResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetGroupBlackboardResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetGroupBlackboardResponseBodyResult setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
