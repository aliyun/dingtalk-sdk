// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupActiveInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public java.util.List<GetGroupActiveInfoResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     */
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
        @NameInMap("dingGroupId")
        public String dingGroupId;

        @NameInMap("groupCreateTime")
        public String groupCreateTime;

        @NameInMap("groupCreateUserId")
        public String groupCreateUserId;

        @NameInMap("groupCreateUserName")
        public String groupCreateUserName;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupType")
        public Long groupType;

        @NameInMap("groupUserCnt1d")
        public Integer groupUserCnt1d;

        @NameInMap("openConvUv1d")
        public Integer openConvUv1d;

        @NameInMap("sendMessageCnt1d")
        public Long sendMessageCnt1d;

        @NameInMap("sendMessageUserCnt1d")
        public Long sendMessageUserCnt1d;

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
