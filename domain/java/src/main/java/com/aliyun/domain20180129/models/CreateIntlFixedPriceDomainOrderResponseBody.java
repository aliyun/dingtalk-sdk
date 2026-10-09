// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.domain20180129.models;

import com.aliyun.tea.*;

public class CreateIntlFixedPriceDomainOrderResponseBody extends TeaModel {
    @NameInMap("Module")
    public CreateIntlFixedPriceDomainOrderResponseBodyModule module;

    @NameInMap("RequestId")
    public String requestId;

    public static CreateIntlFixedPriceDomainOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateIntlFixedPriceDomainOrderResponseBody self = new CreateIntlFixedPriceDomainOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateIntlFixedPriceDomainOrderResponseBody setModule(CreateIntlFixedPriceDomainOrderResponseBodyModule module) {
        this.module = module;
        return this;
    }
    public CreateIntlFixedPriceDomainOrderResponseBodyModule getModule() {
        return this.module;
    }

    public CreateIntlFixedPriceDomainOrderResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class CreateIntlFixedPriceDomainOrderResponseBodyModule extends TeaModel {
        @NameInMap("Domain")
        public String domain;

        @NameInMap("OrderNo")
        public String orderNo;

        @NameInMap("PayPrice")
        public Long payPrice;

        @NameInMap("PayUrl")
        public String payUrl;

        public static CreateIntlFixedPriceDomainOrderResponseBodyModule build(java.util.Map<String, ?> map) throws Exception {
            CreateIntlFixedPriceDomainOrderResponseBodyModule self = new CreateIntlFixedPriceDomainOrderResponseBodyModule();
            return TeaModel.build(map, self);
        }

        public CreateIntlFixedPriceDomainOrderResponseBodyModule setDomain(String domain) {
            this.domain = domain;
            return this;
        }
        public String getDomain() {
            return this.domain;
        }

        public CreateIntlFixedPriceDomainOrderResponseBodyModule setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public CreateIntlFixedPriceDomainOrderResponseBodyModule setPayPrice(Long payPrice) {
            this.payPrice = payPrice;
            return this;
        }
        public Long getPayPrice() {
            return this.payPrice;
        }

        public CreateIntlFixedPriceDomainOrderResponseBodyModule setPayUrl(String payUrl) {
            this.payUrl = payUrl;
            return this;
        }
        public String getPayUrl() {
            return this.payUrl;
        }

    }

}
