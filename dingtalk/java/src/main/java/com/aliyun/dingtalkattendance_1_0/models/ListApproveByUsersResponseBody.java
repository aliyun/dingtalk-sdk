// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ListApproveByUsersResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListApproveByUsersResponseBodyResult> result;

    public static ListApproveByUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListApproveByUsersResponseBody self = new ListApproveByUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListApproveByUsersResponseBody setResult(java.util.List<ListApproveByUsersResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListApproveByUsersResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListApproveByUsersResponseBodyResult extends TeaModel {
        /**
         * <p>审批单自定义id</p>
         */
        @NameInMap("approveId")
        public String approveId;

        /**
         * <p>审批单开始时间原始格式</p>
         */
        @NameInMap("beginTime")
        public String beginTime;

        /**
         * <p>审批单类型：</p>
         * <p>● 1：加班</p>
         * <p>● 2：出差、外出</p>
         * <p>● 3：请假</p>
         * <p>● 4:  补卡</p>
         * <p>● 5：外勤审批</p>
         */
        @NameInMap("bizType")
        public Integer bizType;

        /**
         * <p>计算方法：</p>
         * <p>● 0：按自然日计算</p>
         * <p>● 1：按工作日计算</p>
         */
        @NameInMap("calculateModel")
        public Integer calculateModel;

        /**
         * <p>时长单位，支持格式如下：</p>
         * <p>● day</p>
         * <p>● halfDay</p>
         * <p>● hour</p>
         * <p>时间格式必须与时长单位对应：</p>
         * <p>● 2019-08-15对应day</p>
         * <p>● 2019-08-15 AM对应halfDay</p>
         * <p>● 2019-08-15 12:43对应hour</p>
         */
        @NameInMap("durationUnit")
        public String durationUnit;

        /**
         * <p>审批单结束时间原始格式</p>
         */
        @NameInMap("endTime")
        public String endTime;

        /**
         * <p>子类型名称，最大长度20个字符</p>
         */
        @NameInMap("subType")
        public String subType;

        /**
         * <p>审批单类型名称，最大长度20个字符</p>
         */
        @NameInMap("tagName")
        public String tagName;

        /**
         * <p>用户userid</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ListApproveByUsersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListApproveByUsersResponseBodyResult self = new ListApproveByUsersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListApproveByUsersResponseBodyResult setApproveId(String approveId) {
            this.approveId = approveId;
            return this;
        }
        public String getApproveId() {
            return this.approveId;
        }

        public ListApproveByUsersResponseBodyResult setBeginTime(String beginTime) {
            this.beginTime = beginTime;
            return this;
        }
        public String getBeginTime() {
            return this.beginTime;
        }

        public ListApproveByUsersResponseBodyResult setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public ListApproveByUsersResponseBodyResult setCalculateModel(Integer calculateModel) {
            this.calculateModel = calculateModel;
            return this;
        }
        public Integer getCalculateModel() {
            return this.calculateModel;
        }

        public ListApproveByUsersResponseBodyResult setDurationUnit(String durationUnit) {
            this.durationUnit = durationUnit;
            return this;
        }
        public String getDurationUnit() {
            return this.durationUnit;
        }

        public ListApproveByUsersResponseBodyResult setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public ListApproveByUsersResponseBodyResult setSubType(String subType) {
            this.subType = subType;
            return this;
        }
        public String getSubType() {
            return this.subType;
        }

        public ListApproveByUsersResponseBodyResult setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

        public ListApproveByUsersResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
