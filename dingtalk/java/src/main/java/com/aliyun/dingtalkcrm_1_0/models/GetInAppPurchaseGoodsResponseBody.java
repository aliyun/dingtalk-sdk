// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetInAppPurchaseGoodsResponseBody extends TeaModel {
    @NameInMap("result")
    public GetInAppPurchaseGoodsResponseBodyResult result;

    public static GetInAppPurchaseGoodsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInAppPurchaseGoodsResponseBody self = new GetInAppPurchaseGoodsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInAppPurchaseGoodsResponseBody setResult(GetInAppPurchaseGoodsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetInAppPurchaseGoodsResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo extends TeaModel {
        @NameInMap("goodsCode")
        public String goodsCode;

        @NameInMap("originalUrl")
        public String originalUrl;

        @NameInMap("url")
        public String url;

        public static GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo build(java.util.Map<String, ?> map) throws Exception {
            GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo self = new GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo();
            return TeaModel.build(map, self);
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo setGoodsCode(String goodsCode) {
            this.goodsCode = goodsCode;
            return this;
        }
        public String getGoodsCode() {
            return this.goodsCode;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo setOriginalUrl(String originalUrl) {
            this.originalUrl = originalUrl;
            return this;
        }
        public String getOriginalUrl() {
            return this.originalUrl;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia extends TeaModel {
        @NameInMap("mediaType")
        public String mediaType;

        @NameInMap("url")
        public String url;

        public static GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia build(java.util.Map<String, ?> map) throws Exception {
            GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia self = new GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia();
            return TeaModel.build(map, self);
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia setMediaType(String mediaType) {
            this.mediaType = mediaType;
            return this;
        }
        public String getMediaType() {
            return this.mediaType;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo extends TeaModel {
        @NameInMap("goodsCode")
        public String goodsCode;

        @NameInMap("originalUrl")
        public String originalUrl;

        @NameInMap("url")
        public String url;

        public static GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo build(java.util.Map<String, ?> map) throws Exception {
            GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo self = new GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo();
            return TeaModel.build(map, self);
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo setGoodsCode(String goodsCode) {
            this.goodsCode = goodsCode;
            return this;
        }
        public String getGoodsCode() {
            return this.goodsCode;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo setOriginalUrl(String originalUrl) {
            this.originalUrl = originalUrl;
            return this;
        }
        public String getOriginalUrl() {
            return this.originalUrl;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList extends TeaModel {
        @NameInMap("applicableVersion")
        public java.util.List<String> applicableVersion;

        @NameInMap("applyNum")
        public Long applyNum;

        @NameInMap("belongIndustry")
        public java.util.List<String> belongIndustry;

        @NameInMap("goodsId")
        public String goodsId;

        @NameInMap("goodsType")
        public String goodsType;

        @NameInMap("icon")
        public String icon;

        @NameInMap("mainOperationInfo")
        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo mainOperationInfo;

        @NameInMap("media")
        public java.util.List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia> media;

        @NameInMap("price")
        public String price;

        @NameInMap("subOperationInfo")
        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo subOperationInfo;

        @NameInMap("subTitle")
        public String subTitle;

        @NameInMap("tag")
        public java.util.List<String> tag;

        @NameInMap("title")
        public String title;

        public static GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList build(java.util.Map<String, ?> map) throws Exception {
            GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList self = new GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList();
            return TeaModel.build(map, self);
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setApplicableVersion(java.util.List<String> applicableVersion) {
            this.applicableVersion = applicableVersion;
            return this;
        }
        public java.util.List<String> getApplicableVersion() {
            return this.applicableVersion;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setApplyNum(Long applyNum) {
            this.applyNum = applyNum;
            return this;
        }
        public Long getApplyNum() {
            return this.applyNum;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setBelongIndustry(java.util.List<String> belongIndustry) {
            this.belongIndustry = belongIndustry;
            return this;
        }
        public java.util.List<String> getBelongIndustry() {
            return this.belongIndustry;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setGoodsId(String goodsId) {
            this.goodsId = goodsId;
            return this;
        }
        public String getGoodsId() {
            return this.goodsId;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setGoodsType(String goodsType) {
            this.goodsType = goodsType;
            return this;
        }
        public String getGoodsType() {
            return this.goodsType;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setMainOperationInfo(GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo mainOperationInfo) {
            this.mainOperationInfo = mainOperationInfo;
            return this;
        }
        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo getMainOperationInfo() {
            return this.mainOperationInfo;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setMedia(java.util.List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia> media) {
            this.media = media;
            return this;
        }
        public java.util.List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia> getMedia() {
            return this.media;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setPrice(String price) {
            this.price = price;
            return this;
        }
        public String getPrice() {
            return this.price;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setSubOperationInfo(GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo subOperationInfo) {
            this.subOperationInfo = subOperationInfo;
            return this;
        }
        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo getSubOperationInfo() {
            return this.subOperationInfo;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setSubTitle(String subTitle) {
            this.subTitle = subTitle;
            return this;
        }
        public String getSubTitle() {
            return this.subTitle;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setTag(java.util.List<String> tag) {
            this.tag = tag;
            return this;
        }
        public java.util.List<String> getTag() {
            return this.tag;
        }

        public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetInAppPurchaseGoodsResponseBodyResult extends TeaModel {
        @NameInMap("orderVersion")
        public String orderVersion;

        @NameInMap("purchaseGoodsList")
        public java.util.List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList> purchaseGoodsList;

        public static GetInAppPurchaseGoodsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetInAppPurchaseGoodsResponseBodyResult self = new GetInAppPurchaseGoodsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetInAppPurchaseGoodsResponseBodyResult setOrderVersion(String orderVersion) {
            this.orderVersion = orderVersion;
            return this;
        }
        public String getOrderVersion() {
            return this.orderVersion;
        }

        public GetInAppPurchaseGoodsResponseBodyResult setPurchaseGoodsList(java.util.List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList> purchaseGoodsList) {
            this.purchaseGoodsList = purchaseGoodsList;
            return this;
        }
        public java.util.List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList> getPurchaseGoodsList() {
            return this.purchaseGoodsList;
        }

    }

}
