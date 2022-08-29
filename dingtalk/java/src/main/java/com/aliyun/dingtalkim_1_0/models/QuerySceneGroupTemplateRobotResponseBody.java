// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QuerySceneGroupTemplateRobotResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySceneGroupTemplateRobotResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QuerySceneGroupTemplateRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySceneGroupTemplateRobotResponseBody self = new QuerySceneGroupTemplateRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySceneGroupTemplateRobotResponseBody setResult(QuerySceneGroupTemplateRobotResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySceneGroupTemplateRobotResponseBodyResult getResult() {
        return this.result;
    }

    public QuerySceneGroupTemplateRobotResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QuerySceneGroupTemplateRobotResponseBodyResult extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static QuerySceneGroupTemplateRobotResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySceneGroupTemplateRobotResponseBodyResult self = new QuerySceneGroupTemplateRobotResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySceneGroupTemplateRobotResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QuerySceneGroupTemplateRobotResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
