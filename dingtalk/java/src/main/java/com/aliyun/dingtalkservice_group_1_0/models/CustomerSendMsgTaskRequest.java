// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CustomerSendMsgTaskRequest extends TeaModel {
    @NameInMap("messageContent")
    public CustomerSendMsgTaskRequestMessageContent messageContent;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("queryCustomer")
    public CustomerSendMsgTaskRequestQueryCustomer queryCustomer;

    @NameInMap("sendConfig")
    public CustomerSendMsgTaskRequestSendConfig sendConfig;

    @NameInMap("taskName")
    public String taskName;

    public static CustomerSendMsgTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomerSendMsgTaskRequest self = new CustomerSendMsgTaskRequest();
        return TeaModel.build(map, self);
    }

    public CustomerSendMsgTaskRequest setMessageContent(CustomerSendMsgTaskRequestMessageContent messageContent) {
        this.messageContent = messageContent;
        return this;
    }
    public CustomerSendMsgTaskRequestMessageContent getMessageContent() {
        return this.messageContent;
    }

    public CustomerSendMsgTaskRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CustomerSendMsgTaskRequest setQueryCustomer(CustomerSendMsgTaskRequestQueryCustomer queryCustomer) {
        this.queryCustomer = queryCustomer;
        return this;
    }
    public CustomerSendMsgTaskRequestQueryCustomer getQueryCustomer() {
        return this.queryCustomer;
    }

    public CustomerSendMsgTaskRequest setSendConfig(CustomerSendMsgTaskRequestSendConfig sendConfig) {
        this.sendConfig = sendConfig;
        return this;
    }
    public CustomerSendMsgTaskRequestSendConfig getSendConfig() {
        return this.sendConfig;
    }

    public CustomerSendMsgTaskRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

    public static class CustomerSendMsgTaskRequestMessageContentBtns extends TeaModel {
        @NameInMap("actionURL")
        public String actionURL;

        @NameInMap("title")
        public String title;

        public static CustomerSendMsgTaskRequestMessageContentBtns build(java.util.Map<String, ?> map) throws Exception {
            CustomerSendMsgTaskRequestMessageContentBtns self = new CustomerSendMsgTaskRequestMessageContentBtns();
            return TeaModel.build(map, self);
        }

        public CustomerSendMsgTaskRequestMessageContentBtns setActionURL(String actionURL) {
            this.actionURL = actionURL;
            return this;
        }
        public String getActionURL() {
            return this.actionURL;
        }

        public CustomerSendMsgTaskRequestMessageContentBtns setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CustomerSendMsgTaskRequestMessageContent extends TeaModel {
        @NameInMap("btns")
        public java.util.List<CustomerSendMsgTaskRequestMessageContentBtns> btns;

        @NameInMap("content")
        public String content;

        @NameInMap("messageType")
        public String messageType;

        @NameInMap("title")
        public String title;

        public static CustomerSendMsgTaskRequestMessageContent build(java.util.Map<String, ?> map) throws Exception {
            CustomerSendMsgTaskRequestMessageContent self = new CustomerSendMsgTaskRequestMessageContent();
            return TeaModel.build(map, self);
        }

        public CustomerSendMsgTaskRequestMessageContent setBtns(java.util.List<CustomerSendMsgTaskRequestMessageContentBtns> btns) {
            this.btns = btns;
            return this;
        }
        public java.util.List<CustomerSendMsgTaskRequestMessageContentBtns> getBtns() {
            return this.btns;
        }

        public CustomerSendMsgTaskRequestMessageContent setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CustomerSendMsgTaskRequestMessageContent setMessageType(String messageType) {
            this.messageType = messageType;
            return this;
        }
        public String getMessageType() {
            return this.messageType;
        }

        public CustomerSendMsgTaskRequestMessageContent setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CustomerSendMsgTaskRequestQueryCustomer extends TeaModel {
        @NameInMap("openContactIds")
        public java.util.List<String> openContactIds;

        @NameInMap("queryType")
        public String queryType;

        @NameInMap("searchContactConditions")
        public String searchContactConditions;

        @NameInMap("searchCustomerConditions")
        public String searchCustomerConditions;

        public static CustomerSendMsgTaskRequestQueryCustomer build(java.util.Map<String, ?> map) throws Exception {
            CustomerSendMsgTaskRequestQueryCustomer self = new CustomerSendMsgTaskRequestQueryCustomer();
            return TeaModel.build(map, self);
        }

        public CustomerSendMsgTaskRequestQueryCustomer setOpenContactIds(java.util.List<String> openContactIds) {
            this.openContactIds = openContactIds;
            return this;
        }
        public java.util.List<String> getOpenContactIds() {
            return this.openContactIds;
        }

        public CustomerSendMsgTaskRequestQueryCustomer setQueryType(String queryType) {
            this.queryType = queryType;
            return this;
        }
        public String getQueryType() {
            return this.queryType;
        }

        public CustomerSendMsgTaskRequestQueryCustomer setSearchContactConditions(String searchContactConditions) {
            this.searchContactConditions = searchContactConditions;
            return this;
        }
        public String getSearchContactConditions() {
            return this.searchContactConditions;
        }

        public CustomerSendMsgTaskRequestQueryCustomer setSearchCustomerConditions(String searchCustomerConditions) {
            this.searchCustomerConditions = searchCustomerConditions;
            return this;
        }
        public String getSearchCustomerConditions() {
            return this.searchCustomerConditions;
        }

    }

    public static class CustomerSendMsgTaskRequestSendConfigUrlTrackConfig extends TeaModel {
        @NameInMap("title")
        public String title;

        @NameInMap("trackId")
        public String trackId;

        @NameInMap("trackUrl")
        public String trackUrl;

        public static CustomerSendMsgTaskRequestSendConfigUrlTrackConfig build(java.util.Map<String, ?> map) throws Exception {
            CustomerSendMsgTaskRequestSendConfigUrlTrackConfig self = new CustomerSendMsgTaskRequestSendConfigUrlTrackConfig();
            return TeaModel.build(map, self);
        }

        public CustomerSendMsgTaskRequestSendConfigUrlTrackConfig setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CustomerSendMsgTaskRequestSendConfigUrlTrackConfig setTrackId(String trackId) {
            this.trackId = trackId;
            return this;
        }
        public String getTrackId() {
            return this.trackId;
        }

        public CustomerSendMsgTaskRequestSendConfigUrlTrackConfig setTrackUrl(String trackUrl) {
            this.trackUrl = trackUrl;
            return this;
        }
        public String getTrackUrl() {
            return this.trackUrl;
        }

    }

    public static class CustomerSendMsgTaskRequestSendConfig extends TeaModel {
        @NameInMap("needUrlTrack")
        public Boolean needUrlTrack;

        @NameInMap("sendTime")
        public String sendTime;

        @NameInMap("sendType")
        public String sendType;

        @NameInMap("urlTrackConfig")
        public java.util.List<CustomerSendMsgTaskRequestSendConfigUrlTrackConfig> urlTrackConfig;

        public static CustomerSendMsgTaskRequestSendConfig build(java.util.Map<String, ?> map) throws Exception {
            CustomerSendMsgTaskRequestSendConfig self = new CustomerSendMsgTaskRequestSendConfig();
            return TeaModel.build(map, self);
        }

        public CustomerSendMsgTaskRequestSendConfig setNeedUrlTrack(Boolean needUrlTrack) {
            this.needUrlTrack = needUrlTrack;
            return this;
        }
        public Boolean getNeedUrlTrack() {
            return this.needUrlTrack;
        }

        public CustomerSendMsgTaskRequestSendConfig setSendTime(String sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public String getSendTime() {
            return this.sendTime;
        }

        public CustomerSendMsgTaskRequestSendConfig setSendType(String sendType) {
            this.sendType = sendType;
            return this;
        }
        public String getSendType() {
            return this.sendType;
        }

        public CustomerSendMsgTaskRequestSendConfig setUrlTrackConfig(java.util.List<CustomerSendMsgTaskRequestSendConfigUrlTrackConfig> urlTrackConfig) {
            this.urlTrackConfig = urlTrackConfig;
            return this;
        }
        public java.util.List<CustomerSendMsgTaskRequestSendConfigUrlTrackConfig> getUrlTrackConfig() {
            return this.urlTrackConfig;
        }

    }

}
