// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripInvoiceRequest extends TeaModel {
    @NameInMap("channelOrderNo")
    public String channelOrderNo;

    @NameInMap("channelType")
    public String channelType;

    @NameInMap("customerCorpId")
    public String customerCorpId;

    @NameInMap("dingUserId")
    public String dingUserId;

    @NameInMap("invoiceDetailList")
    public java.util.List<SyncTripInvoiceRequestInvoiceDetailList> invoiceDetailList;

    public static SyncTripInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTripInvoiceRequest self = new SyncTripInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public SyncTripInvoiceRequest setChannelOrderNo(String channelOrderNo) {
        this.channelOrderNo = channelOrderNo;
        return this;
    }
    public String getChannelOrderNo() {
        return this.channelOrderNo;
    }

    public SyncTripInvoiceRequest setChannelType(String channelType) {
        this.channelType = channelType;
        return this;
    }
    public String getChannelType() {
        return this.channelType;
    }

    public SyncTripInvoiceRequest setCustomerCorpId(String customerCorpId) {
        this.customerCorpId = customerCorpId;
        return this;
    }
    public String getCustomerCorpId() {
        return this.customerCorpId;
    }

    public SyncTripInvoiceRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public SyncTripInvoiceRequest setInvoiceDetailList(java.util.List<SyncTripInvoiceRequestInvoiceDetailList> invoiceDetailList) {
        this.invoiceDetailList = invoiceDetailList;
        return this;
    }
    public java.util.List<SyncTripInvoiceRequestInvoiceDetailList> getInvoiceDetailList() {
        return this.invoiceDetailList;
    }

    public static class SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList extends TeaModel {
        @NameInMap("travelItineraryUrl")
        public String travelItineraryUrl;

        public static SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList build(java.util.Map<String, ?> map) throws Exception {
            SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList self = new SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList();
            return TeaModel.build(map, self);
        }

        public SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList setTravelItineraryUrl(String travelItineraryUrl) {
            this.travelItineraryUrl = travelItineraryUrl;
            return this;
        }
        public String getTravelItineraryUrl() {
            return this.travelItineraryUrl;
        }

    }

    public static class SyncTripInvoiceRequestInvoiceDetailList extends TeaModel {
        @NameInMap("failCode")
        public String failCode;

        @NameInMap("failMessage")
        public String failMessage;

        @NameInMap("invoiceResult")
        public Boolean invoiceResult;

        @NameInMap("ofdInvoiceUrl")
        public String ofdInvoiceUrl;

        @NameInMap("pdfInvoiceUrl")
        public String pdfInvoiceUrl;

        @NameInMap("travelItineraryInfoList")
        public java.util.List<SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList> travelItineraryInfoList;

        @NameInMap("xmlInvoiceUrl")
        public String xmlInvoiceUrl;

        public static SyncTripInvoiceRequestInvoiceDetailList build(java.util.Map<String, ?> map) throws Exception {
            SyncTripInvoiceRequestInvoiceDetailList self = new SyncTripInvoiceRequestInvoiceDetailList();
            return TeaModel.build(map, self);
        }

        public SyncTripInvoiceRequestInvoiceDetailList setFailCode(String failCode) {
            this.failCode = failCode;
            return this;
        }
        public String getFailCode() {
            return this.failCode;
        }

        public SyncTripInvoiceRequestInvoiceDetailList setFailMessage(String failMessage) {
            this.failMessage = failMessage;
            return this;
        }
        public String getFailMessage() {
            return this.failMessage;
        }

        public SyncTripInvoiceRequestInvoiceDetailList setInvoiceResult(Boolean invoiceResult) {
            this.invoiceResult = invoiceResult;
            return this;
        }
        public Boolean getInvoiceResult() {
            return this.invoiceResult;
        }

        public SyncTripInvoiceRequestInvoiceDetailList setOfdInvoiceUrl(String ofdInvoiceUrl) {
            this.ofdInvoiceUrl = ofdInvoiceUrl;
            return this;
        }
        public String getOfdInvoiceUrl() {
            return this.ofdInvoiceUrl;
        }

        public SyncTripInvoiceRequestInvoiceDetailList setPdfInvoiceUrl(String pdfInvoiceUrl) {
            this.pdfInvoiceUrl = pdfInvoiceUrl;
            return this;
        }
        public String getPdfInvoiceUrl() {
            return this.pdfInvoiceUrl;
        }

        public SyncTripInvoiceRequestInvoiceDetailList setTravelItineraryInfoList(java.util.List<SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList> travelItineraryInfoList) {
            this.travelItineraryInfoList = travelItineraryInfoList;
            return this;
        }
        public java.util.List<SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList> getTravelItineraryInfoList() {
            return this.travelItineraryInfoList;
        }

        public SyncTripInvoiceRequestInvoiceDetailList setXmlInvoiceUrl(String xmlInvoiceUrl) {
            this.xmlInvoiceUrl = xmlInvoiceUrl;
            return this;
        }
        public String getXmlInvoiceUrl() {
            return this.xmlInvoiceUrl;
        }

    }

}
