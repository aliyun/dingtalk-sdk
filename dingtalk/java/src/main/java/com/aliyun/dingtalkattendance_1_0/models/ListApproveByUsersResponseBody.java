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
         * <strong>example:</strong>
         * <p>4850378c0ee83</p>
         */
        @NameInMap("approveId")
        public String approveId;

        /**
         * <strong>example:</strong>
         * <p>2023-03-15 AM</p>
         */
        @NameInMap("beginTime")
        public String beginTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("bizType")
        public Integer bizType;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("calculateModel")
        public Integer calculateModel;

        /**
         * <strong>example:</strong>
         * <p>hour</p>
         */
        @NameInMap("durationUnit")
        public String durationUnit;

        /**
         * <strong>example:</strong>
         * <p>2023-03-15 AM</p>
         */
        @NameInMap("endTime")
        public String endTime;

        /**
         * <strong>example:</strong>
         * <p>年假</p>
         */
        @NameInMap("subType")
        public String subType;

        /**
         * <strong>example:</strong>
         * <p>请假</p>
         */
        @NameInMap("tagName")
        public String tagName;

        /**
         * <strong>example:</strong>
         * <p>user1</p>
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
