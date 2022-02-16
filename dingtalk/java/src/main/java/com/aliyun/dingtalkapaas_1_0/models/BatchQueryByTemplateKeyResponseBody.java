// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryByTemplateKeyResponseBody extends TeaModel {
    @NameInMap("templateList")
    public java.util.List<BatchQueryByTemplateKeyResponseBodyTemplateList> templateList;

    public static BatchQueryByTemplateKeyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryByTemplateKeyResponseBody self = new BatchQueryByTemplateKeyResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryByTemplateKeyResponseBody setTemplateList(java.util.List<BatchQueryByTemplateKeyResponseBodyTemplateList> templateList) {
        this.templateList = templateList;
        return this;
    }
    public java.util.List<BatchQueryByTemplateKeyResponseBodyTemplateList> getTemplateList() {
        return this.templateList;
    }

    public static class BatchQueryByTemplateKeyResponseBodyTemplateList extends TeaModel {
        @NameInMap("adaptEnv")
        public java.util.List<String> adaptEnv;

        @NameInMap("appDesc")
        public String appDesc;

        @NameInMap("appIcon")
        public String appIcon;

        @NameInMap("caseVideoList")
        public java.util.List<String> caseVideoList;

        @NameInMap("category")
        public String category;

        @NameInMap("coverImgList")
        public java.util.List<String> coverImgList;

        @NameInMap("expUrl")
        public String expUrl;

        @NameInMap("industryLabelList")
        public java.util.List<String> industryLabelList;

        @NameInMap("installTimes")
        public Float installTimes;

        @NameInMap("mobilePreviewMediaList")
        public java.util.List<String> mobilePreviewMediaList;

        @NameInMap("name")
        public String name;

        @NameInMap("previewMediaList")
        public java.util.List<String> previewMediaList;

        @NameInMap("providerName")
        public String providerName;

        @NameInMap("roleLabelList")
        public java.util.List<String> roleLabelList;

        @NameInMap("simpleDesc")
        public String simpleDesc;

        @NameInMap("templateKey")
        public String templateKey;

        @NameInMap("useCasesMediaList")
        public java.util.List<String> useCasesMediaList;

        public static BatchQueryByTemplateKeyResponseBodyTemplateList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryByTemplateKeyResponseBodyTemplateList self = new BatchQueryByTemplateKeyResponseBodyTemplateList();
            return TeaModel.build(map, self);
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setAdaptEnv(java.util.List<String> adaptEnv) {
            this.adaptEnv = adaptEnv;
            return this;
        }
        public java.util.List<String> getAdaptEnv() {
            return this.adaptEnv;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setAppDesc(String appDesc) {
            this.appDesc = appDesc;
            return this;
        }
        public String getAppDesc() {
            return this.appDesc;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setAppIcon(String appIcon) {
            this.appIcon = appIcon;
            return this;
        }
        public String getAppIcon() {
            return this.appIcon;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setCaseVideoList(java.util.List<String> caseVideoList) {
            this.caseVideoList = caseVideoList;
            return this;
        }
        public java.util.List<String> getCaseVideoList() {
            return this.caseVideoList;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setCoverImgList(java.util.List<String> coverImgList) {
            this.coverImgList = coverImgList;
            return this;
        }
        public java.util.List<String> getCoverImgList() {
            return this.coverImgList;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setExpUrl(String expUrl) {
            this.expUrl = expUrl;
            return this;
        }
        public String getExpUrl() {
            return this.expUrl;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setIndustryLabelList(java.util.List<String> industryLabelList) {
            this.industryLabelList = industryLabelList;
            return this;
        }
        public java.util.List<String> getIndustryLabelList() {
            return this.industryLabelList;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setInstallTimes(Float installTimes) {
            this.installTimes = installTimes;
            return this;
        }
        public Float getInstallTimes() {
            return this.installTimes;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setMobilePreviewMediaList(java.util.List<String> mobilePreviewMediaList) {
            this.mobilePreviewMediaList = mobilePreviewMediaList;
            return this;
        }
        public java.util.List<String> getMobilePreviewMediaList() {
            return this.mobilePreviewMediaList;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setPreviewMediaList(java.util.List<String> previewMediaList) {
            this.previewMediaList = previewMediaList;
            return this;
        }
        public java.util.List<String> getPreviewMediaList() {
            return this.previewMediaList;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setProviderName(String providerName) {
            this.providerName = providerName;
            return this;
        }
        public String getProviderName() {
            return this.providerName;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setRoleLabelList(java.util.List<String> roleLabelList) {
            this.roleLabelList = roleLabelList;
            return this;
        }
        public java.util.List<String> getRoleLabelList() {
            return this.roleLabelList;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setSimpleDesc(String simpleDesc) {
            this.simpleDesc = simpleDesc;
            return this;
        }
        public String getSimpleDesc() {
            return this.simpleDesc;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setTemplateKey(String templateKey) {
            this.templateKey = templateKey;
            return this;
        }
        public String getTemplateKey() {
            return this.templateKey;
        }

        public BatchQueryByTemplateKeyResponseBodyTemplateList setUseCasesMediaList(java.util.List<String> useCasesMediaList) {
            this.useCasesMediaList = useCasesMediaList;
            return this;
        }
        public java.util.List<String> getUseCasesMediaList() {
            return this.useCasesMediaList;
        }

    }

}
