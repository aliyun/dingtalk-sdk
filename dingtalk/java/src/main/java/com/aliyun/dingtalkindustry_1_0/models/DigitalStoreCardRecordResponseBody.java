// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreCardRecordResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<DigitalStoreCardRecordResponseBodyContent> content;

    public static DigitalStoreCardRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreCardRecordResponseBody self = new DigitalStoreCardRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreCardRecordResponseBody setContent(java.util.List<DigitalStoreCardRecordResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<DigitalStoreCardRecordResponseBodyContent> getContent() {
        return this.content;
    }

    public static class DigitalStoreCardRecordResponseBodyContentDetailList extends TeaModel {
        @NameInMap("deptName")
        public String deptName;

        @NameInMap("readStatusStr")
        public String readStatusStr;

        @NameInMap("readTime")
        public Long readTime;

        @NameInMap("roleName")
        public String roleName;

        @NameInMap("userName")
        public String userName;

        public static DigitalStoreCardRecordResponseBodyContentDetailList build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreCardRecordResponseBodyContentDetailList self = new DigitalStoreCardRecordResponseBodyContentDetailList();
            return TeaModel.build(map, self);
        }

        public DigitalStoreCardRecordResponseBodyContentDetailList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public DigitalStoreCardRecordResponseBodyContentDetailList setReadStatusStr(String readStatusStr) {
            this.readStatusStr = readStatusStr;
            return this;
        }
        public String getReadStatusStr() {
            return this.readStatusStr;
        }

        public DigitalStoreCardRecordResponseBodyContentDetailList setReadTime(Long readTime) {
            this.readTime = readTime;
            return this;
        }
        public Long getReadTime() {
            return this.readTime;
        }

        public DigitalStoreCardRecordResponseBodyContentDetailList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public DigitalStoreCardRecordResponseBodyContentDetailList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

    public static class DigitalStoreCardRecordResponseBodyContent extends TeaModel {
        @NameInMap("conversationTitle")
        public String conversationTitle;

        @NameInMap("detailList")
        public java.util.List<DigitalStoreCardRecordResponseBodyContentDetailList> detailList;

        @NameInMap("id")
        public Long id;

        @NameInMap("memberNum")
        public Integer memberNum;

        @NameInMap("readNum")
        public Integer readNum;

        @NameInMap("readPercent")
        public String readPercent;

        @NameInMap("receiveNum")
        public Integer receiveNum;

        @NameInMap("sceneCardName")
        public String sceneCardName;

        @NameInMap("sendStatus")
        public String sendStatus;

        @NameInMap("sendTime")
        public Long sendTime;

        public static DigitalStoreCardRecordResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreCardRecordResponseBodyContent self = new DigitalStoreCardRecordResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStoreCardRecordResponseBodyContent setConversationTitle(String conversationTitle) {
            this.conversationTitle = conversationTitle;
            return this;
        }
        public String getConversationTitle() {
            return this.conversationTitle;
        }

        public DigitalStoreCardRecordResponseBodyContent setDetailList(java.util.List<DigitalStoreCardRecordResponseBodyContentDetailList> detailList) {
            this.detailList = detailList;
            return this;
        }
        public java.util.List<DigitalStoreCardRecordResponseBodyContentDetailList> getDetailList() {
            return this.detailList;
        }

        public DigitalStoreCardRecordResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public DigitalStoreCardRecordResponseBodyContent setMemberNum(Integer memberNum) {
            this.memberNum = memberNum;
            return this;
        }
        public Integer getMemberNum() {
            return this.memberNum;
        }

        public DigitalStoreCardRecordResponseBodyContent setReadNum(Integer readNum) {
            this.readNum = readNum;
            return this;
        }
        public Integer getReadNum() {
            return this.readNum;
        }

        public DigitalStoreCardRecordResponseBodyContent setReadPercent(String readPercent) {
            this.readPercent = readPercent;
            return this;
        }
        public String getReadPercent() {
            return this.readPercent;
        }

        public DigitalStoreCardRecordResponseBodyContent setReceiveNum(Integer receiveNum) {
            this.receiveNum = receiveNum;
            return this;
        }
        public Integer getReceiveNum() {
            return this.receiveNum;
        }

        public DigitalStoreCardRecordResponseBodyContent setSceneCardName(String sceneCardName) {
            this.sceneCardName = sceneCardName;
            return this;
        }
        public String getSceneCardName() {
            return this.sceneCardName;
        }

        public DigitalStoreCardRecordResponseBodyContent setSendStatus(String sendStatus) {
            this.sendStatus = sendStatus;
            return this;
        }
        public String getSendStatus() {
            return this.sendStatus;
        }

        public DigitalStoreCardRecordResponseBodyContent setSendTime(Long sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public Long getSendTime() {
            return this.sendTime;
        }

    }

}
