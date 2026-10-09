// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.domain20180129.models;

import com.aliyun.tea.*;

public class QueryDomainListRequest extends TeaModel {
    @NameInMap("AutoRenewEnabled")
    public Boolean autoRenewEnabled;

    @NameInMap("Ccompany")
    public String ccompany;

    @NameInMap("Dns")
    public String dns;

    @NameInMap("DomainGroupId")
    public String domainGroupId;

    @NameInMap("DomainName")
    public String domainName;

    @NameInMap("EndExpirationDate")
    public Long endExpirationDate;

    @NameInMap("EndRegistrationDate")
    public Long endRegistrationDate;

    @NameInMap("Lang")
    public String lang;

    @NameInMap("OrderByType")
    public String orderByType;

    @NameInMap("OrderKeyType")
    public String orderKeyType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("PageNum")
    public Integer pageNum;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("PageSize")
    public Integer pageSize;

    @NameInMap("ProductDomainType")
    public String productDomainType;

    @NameInMap("QueryType")
    public String queryType;

    @NameInMap("Registrar")
    public String registrar;

    @NameInMap("ResourceGroupId")
    public String resourceGroupId;

    @NameInMap("StartExpirationDate")
    public Long startExpirationDate;

    @NameInMap("StartRegistrationDate")
    public Long startRegistrationDate;

    @NameInMap("Tag")
    public java.util.List<QueryDomainListRequestTag> tag;

    @NameInMap("UserClientIp")
    public String userClientIp;

    public static QueryDomainListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDomainListRequest self = new QueryDomainListRequest();
        return TeaModel.build(map, self);
    }

    public QueryDomainListRequest setAutoRenewEnabled(Boolean autoRenewEnabled) {
        this.autoRenewEnabled = autoRenewEnabled;
        return this;
    }
    public Boolean getAutoRenewEnabled() {
        return this.autoRenewEnabled;
    }

    public QueryDomainListRequest setCcompany(String ccompany) {
        this.ccompany = ccompany;
        return this;
    }
    public String getCcompany() {
        return this.ccompany;
    }

    public QueryDomainListRequest setDns(String dns) {
        this.dns = dns;
        return this;
    }
    public String getDns() {
        return this.dns;
    }

    public QueryDomainListRequest setDomainGroupId(String domainGroupId) {
        this.domainGroupId = domainGroupId;
        return this;
    }
    public String getDomainGroupId() {
        return this.domainGroupId;
    }

    public QueryDomainListRequest setDomainName(String domainName) {
        this.domainName = domainName;
        return this;
    }
    public String getDomainName() {
        return this.domainName;
    }

    public QueryDomainListRequest setEndExpirationDate(Long endExpirationDate) {
        this.endExpirationDate = endExpirationDate;
        return this;
    }
    public Long getEndExpirationDate() {
        return this.endExpirationDate;
    }

    public QueryDomainListRequest setEndRegistrationDate(Long endRegistrationDate) {
        this.endRegistrationDate = endRegistrationDate;
        return this;
    }
    public Long getEndRegistrationDate() {
        return this.endRegistrationDate;
    }

    public QueryDomainListRequest setLang(String lang) {
        this.lang = lang;
        return this;
    }
    public String getLang() {
        return this.lang;
    }

    public QueryDomainListRequest setOrderByType(String orderByType) {
        this.orderByType = orderByType;
        return this;
    }
    public String getOrderByType() {
        return this.orderByType;
    }

    public QueryDomainListRequest setOrderKeyType(String orderKeyType) {
        this.orderKeyType = orderKeyType;
        return this;
    }
    public String getOrderKeyType() {
        return this.orderKeyType;
    }

    public QueryDomainListRequest setPageNum(Integer pageNum) {
        this.pageNum = pageNum;
        return this;
    }
    public Integer getPageNum() {
        return this.pageNum;
    }

    public QueryDomainListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryDomainListRequest setProductDomainType(String productDomainType) {
        this.productDomainType = productDomainType;
        return this;
    }
    public String getProductDomainType() {
        return this.productDomainType;
    }

    public QueryDomainListRequest setQueryType(String queryType) {
        this.queryType = queryType;
        return this;
    }
    public String getQueryType() {
        return this.queryType;
    }

    public QueryDomainListRequest setRegistrar(String registrar) {
        this.registrar = registrar;
        return this;
    }
    public String getRegistrar() {
        return this.registrar;
    }

    public QueryDomainListRequest setResourceGroupId(String resourceGroupId) {
        this.resourceGroupId = resourceGroupId;
        return this;
    }
    public String getResourceGroupId() {
        return this.resourceGroupId;
    }

    public QueryDomainListRequest setStartExpirationDate(Long startExpirationDate) {
        this.startExpirationDate = startExpirationDate;
        return this;
    }
    public Long getStartExpirationDate() {
        return this.startExpirationDate;
    }

    public QueryDomainListRequest setStartRegistrationDate(Long startRegistrationDate) {
        this.startRegistrationDate = startRegistrationDate;
        return this;
    }
    public Long getStartRegistrationDate() {
        return this.startRegistrationDate;
    }

    public QueryDomainListRequest setTag(java.util.List<QueryDomainListRequestTag> tag) {
        this.tag = tag;
        return this;
    }
    public java.util.List<QueryDomainListRequestTag> getTag() {
        return this.tag;
    }

    public QueryDomainListRequest setUserClientIp(String userClientIp) {
        this.userClientIp = userClientIp;
        return this;
    }
    public String getUserClientIp() {
        return this.userClientIp;
    }

    public static class QueryDomainListRequestTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static QueryDomainListRequestTag build(java.util.Map<String, ?> map) throws Exception {
            QueryDomainListRequestTag self = new QueryDomainListRequestTag();
            return TeaModel.build(map, self);
        }

        public QueryDomainListRequestTag setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public QueryDomainListRequestTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
