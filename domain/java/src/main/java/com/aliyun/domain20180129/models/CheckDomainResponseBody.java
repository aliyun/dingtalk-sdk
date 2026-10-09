// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.domain20180129.models;

import com.aliyun.tea.*;

public class CheckDomainResponseBody extends TeaModel {
    @NameInMap("Avail")
    public String avail;

    @NameInMap("DomainName")
    public String domainName;

    @NameInMap("DynamicCheck")
    public Boolean dynamicCheck;

    @NameInMap("Premium")
    public String premium;

    @NameInMap("Price")
    public Long price;

    @NameInMap("Reason")
    public String reason;

    @NameInMap("RequestId")
    public String requestId;

    @NameInMap("StaticPriceInfo")
    public CheckDomainResponseBodyStaticPriceInfo staticPriceInfo;

    public static CheckDomainResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckDomainResponseBody self = new CheckDomainResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckDomainResponseBody setAvail(String avail) {
        this.avail = avail;
        return this;
    }
    public String getAvail() {
        return this.avail;
    }

    public CheckDomainResponseBody setDomainName(String domainName) {
        this.domainName = domainName;
        return this;
    }
    public String getDomainName() {
        return this.domainName;
    }

    public CheckDomainResponseBody setDynamicCheck(Boolean dynamicCheck) {
        this.dynamicCheck = dynamicCheck;
        return this;
    }
    public Boolean getDynamicCheck() {
        return this.dynamicCheck;
    }

    public CheckDomainResponseBody setPremium(String premium) {
        this.premium = premium;
        return this;
    }
    public String getPremium() {
        return this.premium;
    }

    public CheckDomainResponseBody setPrice(Long price) {
        this.price = price;
        return this;
    }
    public Long getPrice() {
        return this.price;
    }

    public CheckDomainResponseBody setReason(String reason) {
        this.reason = reason;
        return this;
    }
    public String getReason() {
        return this.reason;
    }

    public CheckDomainResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CheckDomainResponseBody setStaticPriceInfo(CheckDomainResponseBodyStaticPriceInfo staticPriceInfo) {
        this.staticPriceInfo = staticPriceInfo;
        return this;
    }
    public CheckDomainResponseBodyStaticPriceInfo getStaticPriceInfo() {
        return this.staticPriceInfo;
    }

    public static class CheckDomainResponseBodyStaticPriceInfoPriceInfo extends TeaModel {
        @NameInMap("action")
        public String action;

        @NameInMap("money")
        public Double money;

        @NameInMap("period")
        public Long period;

        public static CheckDomainResponseBodyStaticPriceInfoPriceInfo build(java.util.Map<String, ?> map) throws Exception {
            CheckDomainResponseBodyStaticPriceInfoPriceInfo self = new CheckDomainResponseBodyStaticPriceInfoPriceInfo();
            return TeaModel.build(map, self);
        }

        public CheckDomainResponseBodyStaticPriceInfoPriceInfo setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public CheckDomainResponseBodyStaticPriceInfoPriceInfo setMoney(Double money) {
            this.money = money;
            return this;
        }
        public Double getMoney() {
            return this.money;
        }

        public CheckDomainResponseBodyStaticPriceInfoPriceInfo setPeriod(Long period) {
            this.period = period;
            return this;
        }
        public Long getPeriod() {
            return this.period;
        }

    }

    public static class CheckDomainResponseBodyStaticPriceInfo extends TeaModel {
        @NameInMap("PriceInfo")
        public java.util.List<CheckDomainResponseBodyStaticPriceInfoPriceInfo> priceInfo;

        public static CheckDomainResponseBodyStaticPriceInfo build(java.util.Map<String, ?> map) throws Exception {
            CheckDomainResponseBodyStaticPriceInfo self = new CheckDomainResponseBodyStaticPriceInfo();
            return TeaModel.build(map, self);
        }

        public CheckDomainResponseBodyStaticPriceInfo setPriceInfo(java.util.List<CheckDomainResponseBodyStaticPriceInfoPriceInfo> priceInfo) {
            this.priceInfo = priceInfo;
            return this;
        }
        public java.util.List<CheckDomainResponseBodyStaticPriceInfoPriceInfo> getPriceInfo() {
            return this.priceInfo;
        }

    }

}
