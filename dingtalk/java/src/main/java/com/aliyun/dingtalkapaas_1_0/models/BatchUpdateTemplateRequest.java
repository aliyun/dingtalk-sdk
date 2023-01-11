// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateTemplateRequest extends TeaModel {
    @NameInMap("templateList")
    public java.util.List<BatchUpdateTemplateRequestTemplateList> templateList;

    public static BatchUpdateTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateTemplateRequest self = new BatchUpdateTemplateRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateTemplateRequest setTemplateList(java.util.List<BatchUpdateTemplateRequestTemplateList> templateList) {
        this.templateList = templateList;
        return this;
    }
    public java.util.List<BatchUpdateTemplateRequestTemplateList> getTemplateList() {
        return this.templateList;
    }

    public static class BatchUpdateTemplateRequestTemplateList extends TeaModel {
        /**
         * <p>adaptEnv</p>
         */
        @NameInMap("adaptEnv")
        public java.util.List<String> adaptEnv;

        /**
         * <p>appDesc</p>
         */
        @NameInMap("appDesc")
        public String appDesc;

        /**
         * <p>appIcon</p>
         */
        @NameInMap("appIcon")
        public String appIcon;

        /**
         * <p>caseVideoList</p>
         */
        @NameInMap("caseVideoList")
        public java.util.List<String> caseVideoList;

        /**
         * <p>category</p>
         */
        @NameInMap("categoryCode")
        public String categoryCode;

        /**
         * <p>coverImgList</p>
         */
        @NameInMap("coverImgList")
        public java.util.List<String> coverImgList;

        /**
         * <p>expUrl</p>
         */
        @NameInMap("expUrl")
        public String expUrl;

        /**
         * <p>industryLabelList</p>
         */
        @NameInMap("industryLabelList")
        public java.util.List<String> industryLabelList;

        /**
         * <p>mobilePreviewMediaList</p>
         */
        @NameInMap("mobilePreviewMediaList")
        public java.util.List<String> mobilePreviewMediaList;

        /**
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>previewMediaList</p>
         */
        @NameInMap("previewMediaList")
        public java.util.List<String> previewMediaList;

        /**
         * <p>providerName</p>
         */
        @NameInMap("providerName")
        public String providerName;

        /**
         * <p>roleLabelList</p>
         */
        @NameInMap("roleLabelList")
        public java.util.List<String> roleLabelList;

        /**
         * <p>simpleDesc</p>
         */
        @NameInMap("simpleDesc")
        public String simpleDesc;

        /**
         * <p>templateKey</p>
         */
        @NameInMap("templateKey")
        public String templateKey;

        /**
         * <p>useCasesMediaList</p>
         */
        @NameInMap("useCasesMediaList")
        public java.util.List<String> useCasesMediaList;

        public static BatchUpdateTemplateRequestTemplateList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateTemplateRequestTemplateList self = new BatchUpdateTemplateRequestTemplateList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateTemplateRequestTemplateList setAdaptEnv(java.util.List<String> adaptEnv) {
            this.adaptEnv = adaptEnv;
            return this;
        }
        public java.util.List<String> getAdaptEnv() {
            return this.adaptEnv;
        }

        public BatchUpdateTemplateRequestTemplateList setAppDesc(String appDesc) {
            this.appDesc = appDesc;
            return this;
        }
        public String getAppDesc() {
            return this.appDesc;
        }

        public BatchUpdateTemplateRequestTemplateList setAppIcon(String appIcon) {
            this.appIcon = appIcon;
            return this;
        }
        public String getAppIcon() {
            return this.appIcon;
        }

        public BatchUpdateTemplateRequestTemplateList setCaseVideoList(java.util.List<String> caseVideoList) {
            this.caseVideoList = caseVideoList;
            return this;
        }
        public java.util.List<String> getCaseVideoList() {
            return this.caseVideoList;
        }

        public BatchUpdateTemplateRequestTemplateList setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public BatchUpdateTemplateRequestTemplateList setCoverImgList(java.util.List<String> coverImgList) {
            this.coverImgList = coverImgList;
            return this;
        }
        public java.util.List<String> getCoverImgList() {
            return this.coverImgList;
        }

        public BatchUpdateTemplateRequestTemplateList setExpUrl(String expUrl) {
            this.expUrl = expUrl;
            return this;
        }
        public String getExpUrl() {
            return this.expUrl;
        }

        public BatchUpdateTemplateRequestTemplateList setIndustryLabelList(java.util.List<String> industryLabelList) {
            this.industryLabelList = industryLabelList;
            return this;
        }
        public java.util.List<String> getIndustryLabelList() {
            return this.industryLabelList;
        }

        public BatchUpdateTemplateRequestTemplateList setMobilePreviewMediaList(java.util.List<String> mobilePreviewMediaList) {
            this.mobilePreviewMediaList = mobilePreviewMediaList;
            return this;
        }
        public java.util.List<String> getMobilePreviewMediaList() {
            return this.mobilePreviewMediaList;
        }

        public BatchUpdateTemplateRequestTemplateList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchUpdateTemplateRequestTemplateList setPreviewMediaList(java.util.List<String> previewMediaList) {
            this.previewMediaList = previewMediaList;
            return this;
        }
        public java.util.List<String> getPreviewMediaList() {
            return this.previewMediaList;
        }

        public BatchUpdateTemplateRequestTemplateList setProviderName(String providerName) {
            this.providerName = providerName;
            return this;
        }
        public String getProviderName() {
            return this.providerName;
        }

        public BatchUpdateTemplateRequestTemplateList setRoleLabelList(java.util.List<String> roleLabelList) {
            this.roleLabelList = roleLabelList;
            return this;
        }
        public java.util.List<String> getRoleLabelList() {
            return this.roleLabelList;
        }

        public BatchUpdateTemplateRequestTemplateList setSimpleDesc(String simpleDesc) {
            this.simpleDesc = simpleDesc;
            return this;
        }
        public String getSimpleDesc() {
            return this.simpleDesc;
        }

        public BatchUpdateTemplateRequestTemplateList setTemplateKey(String templateKey) {
            this.templateKey = templateKey;
            return this;
        }
        public String getTemplateKey() {
            return this.templateKey;
        }

        public BatchUpdateTemplateRequestTemplateList setUseCasesMediaList(java.util.List<String> useCasesMediaList) {
            this.useCasesMediaList = useCasesMediaList;
            return this;
        }
        public java.util.List<String> getUseCasesMediaList() {
            return this.useCasesMediaList;
        }

    }

}
