// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TemplateCategoriesRequest extends TeaModel {
    @NameInMap("option")
    public TemplateCategoriesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public TemplateCategoriesRequestParam param;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static TemplateCategoriesRequest build(java.util.Map<String, ?> map) throws Exception {
        TemplateCategoriesRequest self = new TemplateCategoriesRequest();
        return TeaModel.build(map, self);
    }

    public TemplateCategoriesRequest setOption(TemplateCategoriesRequestOption option) {
        this.option = option;
        return this;
    }
    public TemplateCategoriesRequestOption getOption() {
        return this.option;
    }

    public TemplateCategoriesRequest setParam(TemplateCategoriesRequestParam param) {
        this.param = param;
        return this;
    }
    public TemplateCategoriesRequestParam getParam() {
        return this.param;
    }

    public TemplateCategoriesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class TemplateCategoriesRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("categoryStatus")
        public Integer categoryStatus;

        /**
         * <strong>example:</strong>
         * <p>-1</p>
         */
        @NameInMap("industryId")
        public Integer industryId;

        public static TemplateCategoriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            TemplateCategoriesRequestOption self = new TemplateCategoriesRequestOption();
            return TeaModel.build(map, self);
        }

        public TemplateCategoriesRequestOption setCategoryStatus(Integer categoryStatus) {
            this.categoryStatus = categoryStatus;
            return this;
        }
        public Integer getCategoryStatus() {
            return this.categoryStatus;
        }

        public TemplateCategoriesRequestOption setIndustryId(Integer industryId) {
            this.industryId = industryId;
            return this;
        }
        public Integer getIndustryId() {
            return this.industryId;
        }

    }

    public static class TemplateCategoriesRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>tenantId</p>
         */
        @NameInMap("tenantId")
        public String tenantId;

        public static TemplateCategoriesRequestParam build(java.util.Map<String, ?> map) throws Exception {
            TemplateCategoriesRequestParam self = new TemplateCategoriesRequestParam();
            return TeaModel.build(map, self);
        }

        public TemplateCategoriesRequestParam setTenantId(String tenantId) {
            this.tenantId = tenantId;
            return this;
        }
        public String getTenantId() {
            return this.tenantId;
        }

    }

}
