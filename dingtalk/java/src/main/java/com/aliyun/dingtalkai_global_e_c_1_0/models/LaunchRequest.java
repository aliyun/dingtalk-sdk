// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class LaunchRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("imageUrls")
    public java.util.List<String> imageUrls;

    @NameInMap("platform")
    public java.util.List<String> platform;

    @NameInMap("productName")
    public String productName;

    @NameInMap("sellingPoints")
    public java.util.List<String> sellingPoints;

    @NameInMap("sourceData")
    public String sourceData;

    @NameInMap("variants")
    public java.util.List<LaunchRequestVariants> variants;

    @NameInMap("videoUrls")
    public java.util.List<String> videoUrls;

    @NameInMap("dingAgentId")
    public Long dingAgentId;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingUid")
    public Long dingUid;

    public static LaunchRequest build(java.util.Map<String, ?> map) throws Exception {
        LaunchRequest self = new LaunchRequest();
        return TeaModel.build(map, self);
    }

    public LaunchRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public LaunchRequest setImageUrls(java.util.List<String> imageUrls) {
        this.imageUrls = imageUrls;
        return this;
    }
    public java.util.List<String> getImageUrls() {
        return this.imageUrls;
    }

    public LaunchRequest setPlatform(java.util.List<String> platform) {
        this.platform = platform;
        return this;
    }
    public java.util.List<String> getPlatform() {
        return this.platform;
    }

    public LaunchRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public LaunchRequest setSellingPoints(java.util.List<String> sellingPoints) {
        this.sellingPoints = sellingPoints;
        return this;
    }
    public java.util.List<String> getSellingPoints() {
        return this.sellingPoints;
    }

    public LaunchRequest setSourceData(String sourceData) {
        this.sourceData = sourceData;
        return this;
    }
    public String getSourceData() {
        return this.sourceData;
    }

    public LaunchRequest setVariants(java.util.List<LaunchRequestVariants> variants) {
        this.variants = variants;
        return this;
    }
    public java.util.List<LaunchRequestVariants> getVariants() {
        return this.variants;
    }

    public LaunchRequest setVideoUrls(java.util.List<String> videoUrls) {
        this.videoUrls = videoUrls;
        return this;
    }
    public java.util.List<String> getVideoUrls() {
        return this.videoUrls;
    }

    public LaunchRequest setDingAgentId(Long dingAgentId) {
        this.dingAgentId = dingAgentId;
        return this;
    }
    public Long getDingAgentId() {
        return this.dingAgentId;
    }

    public LaunchRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public LaunchRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public LaunchRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public LaunchRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public LaunchRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public LaunchRequest setDingUid(Long dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public Long getDingUid() {
        return this.dingUid;
    }

    public static class LaunchRequestVariantsOptionValues extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static LaunchRequestVariantsOptionValues build(java.util.Map<String, ?> map) throws Exception {
            LaunchRequestVariantsOptionValues self = new LaunchRequestVariantsOptionValues();
            return TeaModel.build(map, self);
        }

        public LaunchRequestVariantsOptionValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public LaunchRequestVariantsOptionValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class LaunchRequestVariants extends TeaModel {
        @NameInMap("images")
        public java.util.List<String> images;

        @NameInMap("optionValues")
        public java.util.List<LaunchRequestVariantsOptionValues> optionValues;

        @NameInMap("price")
        public String price;

        @NameInMap("sku")
        public String sku;

        public static LaunchRequestVariants build(java.util.Map<String, ?> map) throws Exception {
            LaunchRequestVariants self = new LaunchRequestVariants();
            return TeaModel.build(map, self);
        }

        public LaunchRequestVariants setImages(java.util.List<String> images) {
            this.images = images;
            return this;
        }
        public java.util.List<String> getImages() {
            return this.images;
        }

        public LaunchRequestVariants setOptionValues(java.util.List<LaunchRequestVariantsOptionValues> optionValues) {
            this.optionValues = optionValues;
            return this;
        }
        public java.util.List<LaunchRequestVariantsOptionValues> getOptionValues() {
            return this.optionValues;
        }

        public LaunchRequestVariants setPrice(String price) {
            this.price = price;
            return this;
        }
        public String getPrice() {
            return this.price;
        }

        public LaunchRequestVariants setSku(String sku) {
            this.sku = sku;
            return this;
        }
        public String getSku() {
            return this.sku;
        }

    }

}
