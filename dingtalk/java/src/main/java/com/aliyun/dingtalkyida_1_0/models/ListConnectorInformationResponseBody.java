// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListConnectorInformationResponseBody extends TeaModel {
    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 当前第几页
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    // pluginInfos
    @NameInMap("pluginInfos")
    public java.util.List<ListConnectorInformationResponseBodyPluginInfos> pluginInfos;

    public static ListConnectorInformationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListConnectorInformationResponseBody self = new ListConnectorInformationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListConnectorInformationResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListConnectorInformationResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListConnectorInformationResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public ListConnectorInformationResponseBody setPluginInfos(java.util.List<ListConnectorInformationResponseBodyPluginInfos> pluginInfos) {
        this.pluginInfos = pluginInfos;
        return this;
    }
    public java.util.List<ListConnectorInformationResponseBodyPluginInfos> getPluginInfos() {
        return this.pluginInfos;
    }

    public static class ListConnectorInformationResponseBodyPluginInfosApps extends TeaModel {
        // appName
        @NameInMap("appName")
        public String appName;

        public static ListConnectorInformationResponseBodyPluginInfosApps build(java.util.Map<String, ?> map) throws Exception {
            ListConnectorInformationResponseBodyPluginInfosApps self = new ListConnectorInformationResponseBodyPluginInfosApps();
            return TeaModel.build(map, self);
        }

        public ListConnectorInformationResponseBodyPluginInfosApps setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

    }

    public static class ListConnectorInformationResponseBodyPluginInfos extends TeaModel {
        // pluginUuid
        @NameInMap("pluginUuid")
        public String pluginUuid;

        // pluginTotalAmount
        @NameInMap("pluginTotalAmount")
        public Long pluginTotalAmount;

        // pluginName
        @NameInMap("pluginName")
        public String pluginName;

        // iconUrl
        @NameInMap("iconUrl")
        public String iconUrl;

        // pluginPayType
        @NameInMap("pluginPayType")
        public Integer pluginPayType;

        // pluginUsageAmount
        @NameInMap("pluginUsageAmount")
        public Long pluginUsageAmount;

        // pluginStatus
        @NameInMap("pluginStatus")
        public Integer pluginStatus;

        // apps
        @NameInMap("apps")
        public java.util.List<ListConnectorInformationResponseBodyPluginInfosApps> apps;

        public static ListConnectorInformationResponseBodyPluginInfos build(java.util.Map<String, ?> map) throws Exception {
            ListConnectorInformationResponseBodyPluginInfos self = new ListConnectorInformationResponseBodyPluginInfos();
            return TeaModel.build(map, self);
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginUuid(String pluginUuid) {
            this.pluginUuid = pluginUuid;
            return this;
        }
        public String getPluginUuid() {
            return this.pluginUuid;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginTotalAmount(Long pluginTotalAmount) {
            this.pluginTotalAmount = pluginTotalAmount;
            return this;
        }
        public Long getPluginTotalAmount() {
            return this.pluginTotalAmount;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginName(String pluginName) {
            this.pluginName = pluginName;
            return this;
        }
        public String getPluginName() {
            return this.pluginName;
        }

        public ListConnectorInformationResponseBodyPluginInfos setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginPayType(Integer pluginPayType) {
            this.pluginPayType = pluginPayType;
            return this;
        }
        public Integer getPluginPayType() {
            return this.pluginPayType;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginUsageAmount(Long pluginUsageAmount) {
            this.pluginUsageAmount = pluginUsageAmount;
            return this;
        }
        public Long getPluginUsageAmount() {
            return this.pluginUsageAmount;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginStatus(Integer pluginStatus) {
            this.pluginStatus = pluginStatus;
            return this;
        }
        public Integer getPluginStatus() {
            return this.pluginStatus;
        }

        public ListConnectorInformationResponseBodyPluginInfos setApps(java.util.List<ListConnectorInformationResponseBodyPluginInfosApps> apps) {
            this.apps = apps;
            return this;
        }
        public java.util.List<ListConnectorInformationResponseBodyPluginInfosApps> getApps() {
            return this.apps;
        }

    }

}
