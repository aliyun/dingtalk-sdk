// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryScreenResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryScreenResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryScreenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryScreenResponseBody self = new QueryScreenResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryScreenResponseBody setResult(java.util.List<QueryScreenResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryScreenResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryScreenResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryScreenResponseBodyResult extends TeaModel {
        @NameInMap("operatePermission")
        public String operatePermission;

        @NameInMap("screenId")
        public Long screenId;

        @NameInMap("screenName")
        public String screenName;

        @NameInMap("state")
        public String state;

        @NameInMap("thumbUrl")
        public String thumbUrl;

        public static QueryScreenResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryScreenResponseBodyResult self = new QueryScreenResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryScreenResponseBodyResult setOperatePermission(String operatePermission) {
            this.operatePermission = operatePermission;
            return this;
        }
        public String getOperatePermission() {
            return this.operatePermission;
        }

        public QueryScreenResponseBodyResult setScreenId(Long screenId) {
            this.screenId = screenId;
            return this;
        }
        public Long getScreenId() {
            return this.screenId;
        }

        public QueryScreenResponseBodyResult setScreenName(String screenName) {
            this.screenName = screenName;
            return this;
        }
        public String getScreenName() {
            return this.screenName;
        }

        public QueryScreenResponseBodyResult setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public QueryScreenResponseBodyResult setThumbUrl(String thumbUrl) {
            this.thumbUrl = thumbUrl;
            return this;
        }
        public String getThumbUrl() {
            return this.thumbUrl;
        }

    }

}
