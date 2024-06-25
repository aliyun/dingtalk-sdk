// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationAuthorizationServiceConnectorInformationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("plugInformation")
    public java.util.List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation> plugInformation;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static ListApplicationAuthorizationServiceConnectorInformationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationAuthorizationServiceConnectorInformationResponseBody self = new ListApplicationAuthorizationServiceConnectorInformationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponseBody setPlugInformation(java.util.List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation> plugInformation) {
        this.plugInformation = plugInformation;
        return this;
    }
    public java.util.List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation> getPlugInformation() {
        return this.plugInformation;
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications extends TeaModel {
        @NameInMap("appName")
        public String appName;

        public static ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications self = new ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications();
            return TeaModel.build(map, self);
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

    }

    public static class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation extends TeaModel {
        @NameInMap("applications")
        public java.util.List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications> applications;

        @NameInMap("iconUrl")
        public String iconUrl;

        @NameInMap("plugName")
        public String plugName;

        @NameInMap("plugPayType")
        public Integer plugPayType;

        @NameInMap("plugStatus")
        public Integer plugStatus;

        @NameInMap("plugTotalAmount")
        public Long plugTotalAmount;

        @NameInMap("plugUsageAmount")
        public Long plugUsageAmount;

        @NameInMap("plugUuid")
        public String plugUuid;

        public static ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation self = new ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation();
            return TeaModel.build(map, self);
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setApplications(java.util.List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications> applications) {
            this.applications = applications;
            return this;
        }
        public java.util.List<ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications> getApplications() {
            return this.applications;
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setPlugName(String plugName) {
            this.plugName = plugName;
            return this;
        }
        public String getPlugName() {
            return this.plugName;
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setPlugPayType(Integer plugPayType) {
            this.plugPayType = plugPayType;
            return this;
        }
        public Integer getPlugPayType() {
            return this.plugPayType;
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setPlugStatus(Integer plugStatus) {
            this.plugStatus = plugStatus;
            return this;
        }
        public Integer getPlugStatus() {
            return this.plugStatus;
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setPlugTotalAmount(Long plugTotalAmount) {
            this.plugTotalAmount = plugTotalAmount;
            return this;
        }
        public Long getPlugTotalAmount() {
            return this.plugTotalAmount;
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setPlugUsageAmount(Long plugUsageAmount) {
            this.plugUsageAmount = plugUsageAmount;
            return this;
        }
        public Long getPlugUsageAmount() {
            return this.plugUsageAmount;
        }

        public ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation setPlugUuid(String plugUuid) {
            this.plugUuid = plugUuid;
            return this;
        }
        public String getPlugUuid() {
            return this.plugUuid;
        }

    }

}
