// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class GetBotListInGroupResponseBody extends TeaModel {
    @NameInMap("chatbotInstanceVOList")
    public java.util.List<GetBotListInGroupResponseBodyChatbotInstanceVOList> chatbotInstanceVOList;

    public static GetBotListInGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBotListInGroupResponseBody self = new GetBotListInGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBotListInGroupResponseBody setChatbotInstanceVOList(java.util.List<GetBotListInGroupResponseBodyChatbotInstanceVOList> chatbotInstanceVOList) {
        this.chatbotInstanceVOList = chatbotInstanceVOList;
        return this;
    }
    public java.util.List<GetBotListInGroupResponseBodyChatbotInstanceVOList> getChatbotInstanceVOList() {
        return this.chatbotInstanceVOList;
    }

    public static class GetBotListInGroupResponseBodyChatbotInstanceVOList extends TeaModel {
        @NameInMap("downloadIconURL")
        public String downloadIconURL;

        @NameInMap("name")
        public String name;

        @NameInMap("openRobotType")
        public Integer openRobotType;

        @NameInMap("robotCode")
        public String robotCode;

        public static GetBotListInGroupResponseBodyChatbotInstanceVOList build(java.util.Map<String, ?> map) throws Exception {
            GetBotListInGroupResponseBodyChatbotInstanceVOList self = new GetBotListInGroupResponseBodyChatbotInstanceVOList();
            return TeaModel.build(map, self);
        }

        public GetBotListInGroupResponseBodyChatbotInstanceVOList setDownloadIconURL(String downloadIconURL) {
            this.downloadIconURL = downloadIconURL;
            return this;
        }
        public String getDownloadIconURL() {
            return this.downloadIconURL;
        }

        public GetBotListInGroupResponseBodyChatbotInstanceVOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetBotListInGroupResponseBodyChatbotInstanceVOList setOpenRobotType(Integer openRobotType) {
            this.openRobotType = openRobotType;
            return this;
        }
        public Integer getOpenRobotType() {
            return this.openRobotType;
        }

        public GetBotListInGroupResponseBodyChatbotInstanceVOList setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

    }

}
