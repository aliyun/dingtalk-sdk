// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdatePointActionAutoAssignRuleRequest extends TeaModel {
    /**
     * <p>行为规则列表</p>
     */
    @NameInMap("updatePointRuleRequestDTOList")
    public java.util.List<UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList> updatePointRuleRequestDTOList;

    /**
     * <p>操作人userId</p>
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
         * <p>奖励积分1～100</p>
         */
        @NameInMap("awardScore")
        public Long awardScore;

        /**
         * <p>行为名称 不支持修改 </p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>单日计次上限 1～10</p>
         */
        @NameInMap("dayLimitTimes")
        public Long dayLimitTimes;

        /**
         * <p>生效状态：0无效，1有效</p>
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
