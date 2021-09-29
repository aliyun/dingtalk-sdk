// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationAuthorizationServiceApplicationInformationResponseBody extends TeaModel {
    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // applicationInformation
    @NameInMap("applicationInformation")
    public java.util.List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation> applicationInformation;

    // 当前第几页
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 总数量
    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListApplicationAuthorizationServiceApplicationInformationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationAuthorizationServiceApplicationInformationResponseBody self = new ListApplicationAuthorizationServiceApplicationInformationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponseBody setApplicationInformation(java.util.List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation> applicationInformation) {
        this.applicationInformation = applicationInformation;
        return this;
    }
    public java.util.List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation> getApplicationInformation() {
        return this.applicationInformation;
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins extends TeaModel {
        // pluginName
        @NameInMap("pluginName")
        public String pluginName;

        // iconUrl
        @NameInMap("iconUrl")
        public String iconUrl;

        public static ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins self = new ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins();
            return TeaModel.build(map, self);
        }

        public ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins setPluginName(String pluginName) {
            this.pluginName = pluginName;
            return this;
        }
        public String getPluginName() {
            return this.pluginName;
        }

        public ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

    }

    public static class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation extends TeaModel {
        // usagePlugins
        @NameInMap("usagePlugins")
        public java.util.List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins> usagePlugins;

        // appName
        @NameInMap("appName")
        public String appName;

        // appType
        @NameInMap("appType")
        public String appType;

        // instanceUsageAmount
        @NameInMap("instanceUsageAmount")
        public Long instanceUsageAmount;

        // attachmentUsageAmount
        @NameInMap("attachmentUsageAmount")
        public Long attachmentUsageAmount;

        public static ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation self = new ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation();
            return TeaModel.build(map, self);
        }

        public ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation setUsagePlugins(java.util.List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins> usagePlugins) {
            this.usagePlugins = usagePlugins;
            return this;
        }
        public java.util.List<ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins> getUsagePlugins() {
            return this.usagePlugins;
        }

        public ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation setInstanceUsageAmount(Long instanceUsageAmount) {
            this.instanceUsageAmount = instanceUsageAmount;
            return this;
        }
        public Long getInstanceUsageAmount() {
            return this.instanceUsageAmount;
        }

        public ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation setAttachmentUsageAmount(Long attachmentUsageAmount) {
            this.attachmentUsageAmount = attachmentUsageAmount;
            return this;
        }
        public Long getAttachmentUsageAmount() {
            return this.attachmentUsageAmount;
        }

    }

}
