// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncBusinessSignInfoRequest extends TeaModel {
    @NameInMap("bizTypeList")
    public java.util.List<String> bizTypeList;

    /**
     * <strong>example:</strong>
     * <p>1661927020219</p>
     */
    @NameInMap("gmtOrgPay")
    public String gmtOrgPay;

    /**
     * <strong>example:</strong>
     * <p>1661927020219</p>
     */
    @NameInMap("gmtSign")
    public String gmtSign;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ORG_PAY</p>
     */
    @NameInMap("orgPayStatus")
    public String orgPayStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SIGN</p>
     */
    @NameInMap("signStatus")
    public String signStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding89233847892ndkas</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("tmcProductDetailList")
    public java.util.List<SyncBusinessSignInfoRequestTmcProductDetailList> tmcProductDetailList;

    @NameInMap("tmcProductList")
    public java.util.List<SyncBusinessSignInfoRequestTmcProductList> tmcProductList;

    public static SyncBusinessSignInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncBusinessSignInfoRequest self = new SyncBusinessSignInfoRequest();
        return TeaModel.build(map, self);
    }

    public SyncBusinessSignInfoRequest setBizTypeList(java.util.List<String> bizTypeList) {
        this.bizTypeList = bizTypeList;
        return this;
    }
    public java.util.List<String> getBizTypeList() {
        return this.bizTypeList;
    }

    public SyncBusinessSignInfoRequest setGmtOrgPay(String gmtOrgPay) {
        this.gmtOrgPay = gmtOrgPay;
        return this;
    }
    public String getGmtOrgPay() {
        return this.gmtOrgPay;
    }

    public SyncBusinessSignInfoRequest setGmtSign(String gmtSign) {
        this.gmtSign = gmtSign;
        return this;
    }
    public String getGmtSign() {
        return this.gmtSign;
    }

    public SyncBusinessSignInfoRequest setOrgPayStatus(String orgPayStatus) {
        this.orgPayStatus = orgPayStatus;
        return this;
    }
    public String getOrgPayStatus() {
        return this.orgPayStatus;
    }

    public SyncBusinessSignInfoRequest setSignStatus(String signStatus) {
        this.signStatus = signStatus;
        return this;
    }
    public String getSignStatus() {
        return this.signStatus;
    }

    public SyncBusinessSignInfoRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public SyncBusinessSignInfoRequest setTmcProductDetailList(java.util.List<SyncBusinessSignInfoRequestTmcProductDetailList> tmcProductDetailList) {
        this.tmcProductDetailList = tmcProductDetailList;
        return this;
    }
    public java.util.List<SyncBusinessSignInfoRequestTmcProductDetailList> getTmcProductDetailList() {
        return this.tmcProductDetailList;
    }

    public SyncBusinessSignInfoRequest setTmcProductList(java.util.List<SyncBusinessSignInfoRequestTmcProductList> tmcProductList) {
        this.tmcProductList = tmcProductList;
        return this;
    }
    public java.util.List<SyncBusinessSignInfoRequestTmcProductList> getTmcProductList() {
        return this.tmcProductList;
    }

    public static class SyncBusinessSignInfoRequestTmcProductDetailList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1661927020219</p>
         */
        @NameInMap("gmtOrgPay")
        public String gmtOrgPay;

        @NameInMap("payType")
        public String payType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("product")
        public String product;

        public static SyncBusinessSignInfoRequestTmcProductDetailList build(java.util.Map<String, ?> map) throws Exception {
            SyncBusinessSignInfoRequestTmcProductDetailList self = new SyncBusinessSignInfoRequestTmcProductDetailList();
            return TeaModel.build(map, self);
        }

        public SyncBusinessSignInfoRequestTmcProductDetailList setGmtOrgPay(String gmtOrgPay) {
            this.gmtOrgPay = gmtOrgPay;
            return this;
        }
        public String getGmtOrgPay() {
            return this.gmtOrgPay;
        }

        public SyncBusinessSignInfoRequestTmcProductDetailList setPayType(String payType) {
            this.payType = payType;
            return this;
        }
        public String getPayType() {
            return this.payType;
        }

        public SyncBusinessSignInfoRequestTmcProductDetailList setProduct(String product) {
            this.product = product;
            return this;
        }
        public String getProduct() {
            return this.product;
        }

    }

    public static class SyncBusinessSignInfoRequestTmcProductListProductDetailList extends TeaModel {
        @NameInMap("categoryType")
        public String categoryType;

        /**
         * <strong>example:</strong>
         * <p>1661927020219</p>
         */
        @NameInMap("gmtOrgPay")
        public String gmtOrgPay;

        @NameInMap("openStatus")
        public Boolean openStatus;

        @NameInMap("payType")
        public String payType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("product")
        public String product;

        public static SyncBusinessSignInfoRequestTmcProductListProductDetailList build(java.util.Map<String, ?> map) throws Exception {
            SyncBusinessSignInfoRequestTmcProductListProductDetailList self = new SyncBusinessSignInfoRequestTmcProductListProductDetailList();
            return TeaModel.build(map, self);
        }

        public SyncBusinessSignInfoRequestTmcProductListProductDetailList setCategoryType(String categoryType) {
            this.categoryType = categoryType;
            return this;
        }
        public String getCategoryType() {
            return this.categoryType;
        }

        public SyncBusinessSignInfoRequestTmcProductListProductDetailList setGmtOrgPay(String gmtOrgPay) {
            this.gmtOrgPay = gmtOrgPay;
            return this;
        }
        public String getGmtOrgPay() {
            return this.gmtOrgPay;
        }

        public SyncBusinessSignInfoRequestTmcProductListProductDetailList setOpenStatus(Boolean openStatus) {
            this.openStatus = openStatus;
            return this;
        }
        public Boolean getOpenStatus() {
            return this.openStatus;
        }

        public SyncBusinessSignInfoRequestTmcProductListProductDetailList setPayType(String payType) {
            this.payType = payType;
            return this;
        }
        public String getPayType() {
            return this.payType;
        }

        public SyncBusinessSignInfoRequestTmcProductListProductDetailList setProduct(String product) {
            this.product = product;
            return this;
        }
        public String getProduct() {
            return this.product;
        }

    }

    public static class SyncBusinessSignInfoRequestTmcProductList extends TeaModel {
        @NameInMap("productDetailList")
        public java.util.List<SyncBusinessSignInfoRequestTmcProductListProductDetailList> productDetailList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("tmcCorpId")
        public String tmcCorpId;

        public static SyncBusinessSignInfoRequestTmcProductList build(java.util.Map<String, ?> map) throws Exception {
            SyncBusinessSignInfoRequestTmcProductList self = new SyncBusinessSignInfoRequestTmcProductList();
            return TeaModel.build(map, self);
        }

        public SyncBusinessSignInfoRequestTmcProductList setProductDetailList(java.util.List<SyncBusinessSignInfoRequestTmcProductListProductDetailList> productDetailList) {
            this.productDetailList = productDetailList;
            return this;
        }
        public java.util.List<SyncBusinessSignInfoRequestTmcProductListProductDetailList> getProductDetailList() {
            return this.productDetailList;
        }

        public SyncBusinessSignInfoRequestTmcProductList setTmcCorpId(String tmcCorpId) {
            this.tmcCorpId = tmcCorpId;
            return this;
        }
        public String getTmcCorpId() {
            return this.tmcCorpId;
        }

    }

}
