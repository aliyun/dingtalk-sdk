// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryPointAutoIssueSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryPointAutoIssueSettingResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("pointAutoNum")
        public Long pointAutoNum;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("pointAutoState")
        public Boolean pointAutoState;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>15</p>
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
