// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryPointAutoIssueSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryPointAutoIssueSettingResponseBodyResult result;

    /**
     * <p>调用是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static QueryPointAutoIssueSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPointAutoIssueSettingResponseBody self = new QueryPointAutoIssueSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPointAutoIssueSettingResponseBody setResult(QueryPointAutoIssueSettingResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryPointAutoIssueSettingResponseBodyResult getResult() {
        return this.result;
    }

    public QueryPointAutoIssueSettingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryPointAutoIssueSettingResponseBodyResult extends TeaModel {
        /**
         * <p>企业每月额度自动发放给每个人的数量</p>
         */
        @NameInMap("pointAutoNum")
        public Long pointAutoNum;

        /**
         * <p>企业积分自动发放状态</p>
         */
        @NameInMap("pointAutoState")
        public Boolean pointAutoState;

        /**
         * <p>企业积分自动发放时间 指定的是每月1号或15号</p>
         */
        @NameInMap("pointAutoTime")
        public Long pointAutoTime;

        public static QueryPointAutoIssueSettingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryPointAutoIssueSettingResponseBodyResult self = new QueryPointAutoIssueSettingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryPointAutoIssueSettingResponseBodyResult setPointAutoNum(Long pointAutoNum) {
            this.pointAutoNum = pointAutoNum;
            return this;
        }
        public Long getPointAutoNum() {
            return this.pointAutoNum;
        }

        public QueryPointAutoIssueSettingResponseBodyResult setPointAutoState(Boolean pointAutoState) {
            this.pointAutoState = pointAutoState;
            return this;
        }
        public Boolean getPointAutoState() {
            return this.pointAutoState;
        }

        public QueryPointAutoIssueSettingResponseBodyResult setPointAutoTime(Long pointAutoTime) {
            this.pointAutoTime = pointAutoTime;
            return this;
        }
        public Long getPointAutoTime() {
            return this.pointAutoTime;
        }

    }

}
