// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupActiveInfoResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetGroupActiveInfoResponseBodyData> data;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetGroupActiveInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGroupActiveInfoResponseBody self = new GetGroupActiveInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGroupActiveInfoResponseBody setData(java.util.List<GetGroupActiveInfoResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetGroupActiveInfoResponseBodyData> getData() {
        return this.data;
    }

    public GetGroupActiveInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetGroupActiveInfoResponseBodyData extends TeaModel {
        /**
         * <p>群组id</p>
         */
        @NameInMap("dingGroupId")
        public String dingGroupId;

        /**
         * <p>群组创建时间</p>
         */
        @NameInMap("groupCreateTime")
        public String groupCreateTime;

        /**
         * <p>群组创建用户id</p>
         */
        @NameInMap("groupCreateUserId")
        public String groupCreateUserId;

        /**
         * <p>群组创建用户姓名</p>
         */
        @NameInMap("groupCreateUserName")
        public String groupCreateUserName;

        /**
         * <p>群名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <p>群类型：1-全员群，2-部门群，3-（其他）内部群，4-场景群</p>
         */
        @NameInMap("groupType")
        public Long groupType;

        /**
         * <p>最近1天群人数</p>
         */
        @NameInMap("groupUserCnt1d")
        public Integer groupUserCnt1d;

        /**
         * <p>最近1天打开群人数</p>
         */
        @NameInMap("openConvUv1d")
        public Integer openConvUv1d;

        /**
         * <p>最近1天发消息次数</p>
         */
        @NameInMap("sendMessageCnt1d")
        public Long sendMessageCnt1d;

        /**
         * <p>最近1天发消息人数</p>
         */
        @NameInMap("sendMessageUserCnt1d")
        public Long sendMessageUserCnt1d;

        /**
         * <p>统计时间</p>
         */
        @NameInMap("statDate")
        public String statDate;

        public static GetGroupActiveInfoResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetGroupActiveInfoResponseBodyData self = new GetGroupActiveInfoResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetGroupActiveInfoResponseBodyData setDingGroupId(String dingGroupId) {
            this.dingGroupId = dingGroupId;
            return this;
        }
        public String getDingGroupId() {
            return this.dingGroupId;
        }

        public GetGroupActiveInfoResponseBodyData setGroupCreateTime(String groupCreateTime) {
            this.groupCreateTime = groupCreateTime;
            return this;
        }
        public String getGroupCreateTime() {
            return this.groupCreateTime;
        }

        public GetGroupActiveInfoResponseBodyData setGroupCreateUserId(String groupCreateUserId) {
            this.groupCreateUserId = groupCreateUserId;
            return this;
        }
        public String getGroupCreateUserId() {
            return this.groupCreateUserId;
        }

        public GetGroupActiveInfoResponseBodyData setGroupCreateUserName(String groupCreateUserName) {
            this.groupCreateUserName = groupCreateUserName;
            return this;
        }
        public String getGroupCreateUserName() {
            return this.groupCreateUserName;
        }

        public GetGroupActiveInfoResponseBodyData setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GetGroupActiveInfoResponseBodyData setGroupType(Long groupType) {
            this.groupType = groupType;
            return this;
        }
        public Long getGroupType() {
            return this.groupType;
        }

        public GetGroupActiveInfoResponseBodyData setGroupUserCnt1d(Integer groupUserCnt1d) {
            this.groupUserCnt1d = groupUserCnt1d;
            return this;
        }
        public Integer getGroupUserCnt1d() {
            return this.groupUserCnt1d;
        }

        public GetGroupActiveInfoResponseBodyData setOpenConvUv1d(Integer openConvUv1d) {
            this.openConvUv1d = openConvUv1d;
            return this;
        }
        public Integer getOpenConvUv1d() {
            return this.openConvUv1d;
        }

        public GetGroupActiveInfoResponseBodyData setSendMessageCnt1d(Long sendMessageCnt1d) {
            this.sendMessageCnt1d = sendMessageCnt1d;
            return this;
        }
        public Long getSendMessageCnt1d() {
            return this.sendMessageCnt1d;
        }

        public GetGroupActiveInfoResponseBodyData setSendMessageUserCnt1d(Long sendMessageUserCnt1d) {
            this.sendMessageUserCnt1d = sendMessageUserCnt1d;
            return this;
        }
        public Long getSendMessageUserCnt1d() {
            return this.sendMessageUserCnt1d;
        }

        public GetGroupActiveInfoResponseBodyData setStatDate(String statDate) {
            this.statDate = statDate;
            return this;
        }
        public String getStatDate() {
            return this.statDate;
        }

    }

}
