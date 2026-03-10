// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceBatchRequest extends TeaModel {
    @NameInMap("detailList")
    public java.util.List<CreateTrustedDeviceBatchRequestDetailList> detailList;

    @NameInMap("macAddressList")
    public java.util.List<String> macAddressList;

    /**
     * <strong>example:</strong>
     * <p>Win</p>
     */
    @NameInMap("platform")
    public String platform;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CreateTrustedDeviceBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceBatchRequest self = new CreateTrustedDeviceBatchRequest();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceBatchRequest setDetailList(java.util.List<CreateTrustedDeviceBatchRequestDetailList> detailList) {
        this.detailList = detailList;
        return this;
    }
    public java.util.List<CreateTrustedDeviceBatchRequestDetailList> getDetailList() {
        return this.detailList;
    }

    public CreateTrustedDeviceBatchRequest setMacAddressList(java.util.List<String> macAddressList) {
        this.macAddressList = macAddressList;
        return this;
    }
    public java.util.List<String> getMacAddressList() {
        return this.macAddressList;
    }

    public CreateTrustedDeviceBatchRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public CreateTrustedDeviceBatchRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CreateTrustedDeviceBatchRequestDetailList extends TeaModel {
        @NameInMap("did")
        public String did;

        @NameInMap("macAddress")
        public String macAddress;

        @NameInMap("platform")
        public String platform;

        @NameInMap("serialNumber")
        public String serialNumber;

        @NameInMap("status")
        public Long status;

        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        public static CreateTrustedDeviceBatchRequestDetailList build(java.util.Map<String, ?> map) throws Exception {
            CreateTrustedDeviceBatchRequestDetailList self = new CreateTrustedDeviceBatchRequestDetailList();
            return TeaModel.build(map, self);
        }

        public CreateTrustedDeviceBatchRequestDetailList setDid(String did) {
            this.did = did;
            return this;
        }
        public String getDid() {
            return this.did;
        }

        public CreateTrustedDeviceBatchRequestDetailList setMacAddress(String macAddress) {
            this.macAddress = macAddress;
            return this;
        }
        public String getMacAddress() {
            return this.macAddress;
        }

        public CreateTrustedDeviceBatchRequestDetailList setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public CreateTrustedDeviceBatchRequestDetailList setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public CreateTrustedDeviceBatchRequestDetailList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public CreateTrustedDeviceBatchRequestDetailList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CreateTrustedDeviceBatchRequestDetailList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
