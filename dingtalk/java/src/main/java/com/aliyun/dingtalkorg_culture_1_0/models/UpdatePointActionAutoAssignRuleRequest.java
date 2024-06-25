// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdatePointActionAutoAssignRuleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("updatePointRuleRequestDTOList")
    public java.util.List<UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList> updatePointRuleRequestDTOList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11185568-1380470824</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdatePointActionAutoAssignRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePointActionAutoAssignRuleRequest self = new UpdatePointActionAutoAssignRuleRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePointActionAutoAssignRuleRequest setUpdatePointRuleRequestDTOList(java.util.List<UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList> updatePointRuleRequestDTOList) {
        this.updatePointRuleRequestDTOList = updatePointRuleRequestDTOList;
        return this;
    }
    public java.util.List<UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList> getUpdatePointRuleRequestDTOList() {
        return this.updatePointRuleRequestDTOList;
    }

    public UpdatePointActionAutoAssignRuleRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("awardScore")
        public Long awardScore;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>POST_IS_COMMENT</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("dayLimitTimes")
        public Long dayLimitTimes;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Long status;

        public static UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList build(java.util.Map<String, ?> map) throws Exception {
            UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList self = new UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList();
            return TeaModel.build(map, self);
        }

        public UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList setAwardScore(Long awardScore) {
            this.awardScore = awardScore;
            return this;
        }
        public Long getAwardScore() {
            return this.awardScore;
        }

        public UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList setDayLimitTimes(Long dayLimitTimes) {
            this.dayLimitTimes = dayLimitTimes;
            return this;
        }
        public Long getDayLimitTimes() {
            return this.dayLimitTimes;
        }

        public UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

    }

}
