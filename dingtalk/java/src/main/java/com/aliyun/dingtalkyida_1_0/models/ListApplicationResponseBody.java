// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ListApplicationResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static ListApplicationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationResponseBody self = new ListApplicationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListApplicationResponseBody setData(java.util.List<ListApplicationResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ListApplicationResponseBodyData> getData() {
        return this.data;
    }

    public ListApplicationResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ListApplicationResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListApplicationResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;ODIN_TOPIC_ID&quot;:&quot;2560649&quot;,&quot;APPPROVIDER&quot;:&quot;vigo&quot;,&quot;NEEDAYALYSIS&quot;:&quot;n&quot;,&quot;NAVTYPE&quot;:&quot;top_side&quot;,&quot;SHOWICON&quot;:&quot;n&quot;,&quot;REPORT_SUPPORT_META_3&quot;:&quot;y&quot;,&quot;ALLOW_EXTERNAL_ADDRESS_BOOK&quot;:&quot;y&quot;,&quot;REPORTVERSION&quot;:&quot;V5&quot;,&quot;FORM_SCHEMA_VERSION&quot;:&quot;V5&quot;,&quot;EXCEL_SOURCE&quot;:&quot;LOCAL&quot;,&quot;DEVICETYPE&quot;:&quot;web,mobile&quot;,&quot;ENABLE_CSRF_SWITCH&quot;:&quot;y&quot;,&quot;NEW_ALLOW_EXTERNAL_ADDRESS_BOOK&quot;:&quot;y&quot;,&quot;COLOUR&quot;:&quot;blue&quot;,&quot;DINGTALK_CID&quot;:&quot;LOCAL&quot;,&quot;APPMODE&quot;:&quot;normal&quot;,&quot;NAVLAYOUT&quot;:&quot;auto&quot;,&quot;SHOWNAV&quot;:&quot;y&quot;,&quot;SHOWCRUMB&quot;:&quot;y&quot;,&quot;SUPPORT_META_3&quot;:&quot;y&quot;,&quot;SUPPORT_META_2&quot;:&quot;y&quot;,&quot;SYSTEMLINK&quot;:&quot;<a href="https://www.aliwork.com/APP_LDYQVBGT167NAON5KB1X/workbench%22,%22DATA_QUERY_VERSION%22:%22V1%22,%22DB_SOURCE_TYPE%22:%22TDDL_MYSQL%22,%22ISTODINGAPPCENTER%22:%22n%22,%22REVERSION%22:%225.9.16%22,%22EDS_DB_INDEX%22:%2224%22,%22NAVIGATION%22:%22TODO,DONE,SUBMIT%22,%22APPTYPE%22:%22single%22%7D">https://www.aliwork.com/APP_LDYQVBGT167NAON5KB1X/workbench&quot;,&quot;DATA_QUERY_VERSION&quot;:&quot;V1&quot;,&quot;DB_SOURCE_TYPE&quot;:&quot;TDDL_MYSQL&quot;,&quot;ISTODINGAPPCENTER&quot;:&quot;n&quot;,&quot;REVERSION&quot;:&quot;5.9.16&quot;,&quot;EDS_DB_INDEX&quot;:&quot;24&quot;,&quot;NAVIGATION&quot;:&quot;TODO,DONE,SUBMIT&quot;,&quot;APPTYPE&quot;:&quot;single&quot;}</a></p>
         */
        @NameInMap("appConfig")
        public String appConfig;

        /**
         * <strong>example:</strong>
         * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
         */
        @NameInMap("appType")
        public String appType;

        /**
         * <strong>example:</strong>
         * <p>上线:ONLINE，下线:OFFLINE</p>
         */
        @NameInMap("applicationStatus")
        public String applicationStatus;

        /**
         * <strong>example:</strong>
         * <p>ding5d17e3add038d44535c2f4657eb6378e</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>ding12345</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>步凡创建的宜搭应用</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>appdiqiu%%#0089FF</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>已删除:y，未删除:n</p>
         */
        @NameInMap("inexistence")
        public String inexistence;

        /**
         * <strong>example:</strong>
         * <p>测试应用</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>ding8eaadfkksj45343wksff334</p>
         */
        @NameInMap("subCorpId")
        public String subCorpId;

        @NameInMap("systemToken")
        public String systemToken;

        public static ListApplicationResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationResponseBodyData self = new ListApplicationResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListApplicationResponseBodyData setAppConfig(String appConfig) {
            this.appConfig = appConfig;
            return this;
        }
        public String getAppConfig() {
            return this.appConfig;
        }

        public ListApplicationResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public ListApplicationResponseBodyData setApplicationStatus(String applicationStatus) {
            this.applicationStatus = applicationStatus;
            return this;
        }
        public String getApplicationStatus() {
            return this.applicationStatus;
        }

        public ListApplicationResponseBodyData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListApplicationResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public ListApplicationResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListApplicationResponseBodyData setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListApplicationResponseBodyData setInexistence(String inexistence) {
            this.inexistence = inexistence;
            return this;
        }
        public String getInexistence() {
            return this.inexistence;
        }

        public ListApplicationResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListApplicationResponseBodyData setSubCorpId(String subCorpId) {
            this.subCorpId = subCorpId;
            return this;
        }
        public String getSubCorpId() {
            return this.subCorpId;
        }

        public ListApplicationResponseBodyData setSystemToken(String systemToken) {
            this.systemToken = systemToken;
            return this;
        }
        public String getSystemToken() {
            return this.systemToken;
        }

    }

}
