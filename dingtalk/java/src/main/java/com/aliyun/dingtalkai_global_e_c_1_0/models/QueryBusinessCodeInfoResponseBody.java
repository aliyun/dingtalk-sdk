// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class QueryBusinessCodeInfoResponseBody extends TeaModel {
    @NameInMap("businessCode")
    public String businessCode;

    @NameInMap("imageType")
    public String imageType;

    @NameInMap("imageUrls")
    public java.util.List<String> imageUrls;

    @NameInMap("productId")
    public String productId;

    @NameInMap("skuList")
    public java.util.List<QueryBusinessCodeInfoResponseBodySkuList> skuList;

    public static QueryBusinessCodeInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBusinessCodeInfoResponseBody self = new QueryBusinessCodeInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBusinessCodeInfoResponseBody setBusinessCode(String businessCode) {
        this.businessCode = businessCode;
        return this;
    }
    public String getBusinessCode() {
        return this.businessCode;
    }

    public QueryBusinessCodeInfoResponseBody setImageType(String imageType) {
        this.imageType = imageType;
        return this;
    }
    public String getImageType() {
        return this.imageType;
    }

    public QueryBusinessCodeInfoResponseBody setImageUrls(java.util.List<String> imageUrls) {
        this.imageUrls = imageUrls;
        return this;
    }
    public java.util.List<String> getImageUrls() {
        return this.imageUrls;
    }

    public QueryBusinessCodeInfoResponseBody setProductId(String productId) {
        this.productId = productId;
        return this;
    }
    public String getProductId() {
        return this.productId;
    }

    public QueryBusinessCodeInfoResponseBody setSkuList(java.util.List<QueryBusinessCodeInfoResponseBodySkuList> skuList) {
        this.skuList = skuList;
        return this;
    }
    public java.util.List<QueryBusinessCodeInfoResponseBodySkuList> getSkuList() {
        return this.skuList;
    }

    public static class QueryBusinessCodeInfoResponseBodySkuList extends TeaModel {
        @NameInMap("imageUrl")
        public String imageUrl;

        @NameInMap("skuId")
        public String skuId;

        public static QueryBusinessCodeInfoResponseBodySkuList build(java.util.Map<String, ?> map) throws Exception {
            QueryBusinessCodeInfoResponseBodySkuList self = new QueryBusinessCodeInfoResponseBodySkuList();
            return TeaModel.build(map, self);
        }

        public QueryBusinessCodeInfoResponseBodySkuList setImageUrl(String imageUrl) {
            this.imageUrl = imageUrl;
            return this;
        }
        public String getImageUrl() {
            return this.imageUrl;
        }

        public QueryBusinessCodeInfoResponseBodySkuList setSkuId(String skuId) {
            this.skuId = skuId;
            return this;
        }
        public String getSkuId() {
            return this.skuId;
        }

    }

}
