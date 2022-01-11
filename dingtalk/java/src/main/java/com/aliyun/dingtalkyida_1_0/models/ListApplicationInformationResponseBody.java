// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationInformationResponseBody extends TeaModel {
    // applicationInformation
    @NameInMap("applicationInformation")
    public java.util.List<ListApplicationInformationResponseBodyApplicationInformation> applicationInformation;

    // 当前第几页
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 总数量
    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListApplicationInformationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationInformationResponseBody self = new ListApplicationInformationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListApplicationInformationResponseBody setApplicationInformation(java.util.List<ListApplicationInformationResponseBodyApplicationInformation> applicationInformation) {
        this.applicationInformation = applicationInformation;
        return this;
    }
    public java.util.List<ListApplicationInformationResponseBodyApplicationInformation> getApplicationInformation() {
        return this.applicationInformation;
    }

    public ListApplicationInformationResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListApplicationInformationResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListApplicationInformationResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListApplicationInformationResponseBodyApplicationInformationUsagePlugins extends TeaModel {
        // iconUrl
        @NameInMap("iconUrl")
        public String iconUrl;

        // pluginName
        @NameInMap("pluginName")
        public String pluginName;

        public static ListApplicationInformationResponseBodyApplicationInformationUsagePlugins build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationInformationResponseBodyApplicationInformationUsagePlugins self = new ListApplicationInformationResponseBodyApplicationInformationUsagePlugins();
            return TeaModel.build(map, self);
        }

        public ListApplicationInformationResponseBodyApplicationInformationUsagePlugins setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public ListApplicationInformationResponseBodyApplicationInformationUsagePlugins setPluginName(String pluginName) {
            this.pluginName = pluginName;
            return this;
        }
        public String getPluginName() {
            return this.pluginName;
        }

    }

    public static class ListApplicationInformationResponseBodyApplicationInformation extends TeaModel {
        // appName
        @NameInMap("appName")
        public String appName;

        // appType
        @NameInMap("appType")
        public String appType;

        // attachmentUsageAmount
        @NameInMap("attachmentUsageAmount")
        public Long attachmentUsageAmount;

        // instanceUsageAmount
        @NameInMap("instanceUsageAmount")
        public Long instanceUsageAmount;

        // usagePlugins
        @NameInMap("usagePlugins")
        public java.util.List<ListApplicationInformationResponseBodyApplicationInformationUsagePlugins> usagePlugins;

        public static ListApplicationInformationResponseBodyApplicationInformation build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationInformationResponseBodyApplicationInformation self = new ListApplicationInformationResponseBodyApplicationInformation();
            return TeaModel.build(map, self);
        }

        public ListApplicationInformationResponseBodyApplicationInformation setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public ListApplicationInformationResponseBodyApplicationInformation setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public ListApplicationInformationResponseBodyApplicationInformation setAttachmentUsageAmount(Long attachmentUsageAmount) {
            this.attachmentUsageAmount = attachmentUsageAmount;
            return this;
        }
        public Long getAttachmentUsageAmount() {
            return this.attachmentUsageAmount;
        }

        public ListApplicationInformationResponseBodyApplicationInformation setInstanceUsageAmount(Long instanceUsageAmount) {
            this.instanceUsageAmount = instanceUsageAmount;
            return this;
        }
        public Long getInstanceUsageAmount() {
            return this.instanceUsageAmount;
        }

        public ListApplicationInformationResponseBodyApplicationInformation setUsagePlugins(java.util.List<ListApplicationInformationResponseBodyApplicationInformationUsagePlugins> usagePlugins) {
            this.usagePlugins = usagePlugins;
            return this;
        }
        public java.util.List<ListApplicationInformationResponseBodyApplicationInformationUsagePlugins> getUsagePlugins() {
            return this.usagePlugins;
        }

    }

}
