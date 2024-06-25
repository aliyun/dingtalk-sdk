// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class QueryReportDetailResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryReportDetailResponseBodyContent> content;

    /**
     * <strong>example:</strong>
     * <p>1507564800000</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("creatorId")
    public String creatorId;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("creatorName")
    public String creatorName;

    /**
     * <strong>example:</strong>
     * <p>部门1</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <strong>example:</strong>
     * <p>1507564800000</p>
     */
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    /**
     * <strong>example:</strong>
     * <p>这是备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <strong>example:</strong>
     * <p>18XXXX</p>
     */
    @NameInMap("reportId")
    public String reportId;

    /**
     * <strong>example:</strong>
     * <p>日报</p>
     */
    @NameInMap("templateName")
    public String templateName;

    public static QueryReportDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryReportDetailResponseBody self = new QueryReportDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryReportDetailResponseBody setContent(java.util.List<QueryReportDetailResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryReportDetailResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryReportDetailResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public QueryReportDetailResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public QueryReportDetailResponseBody setCreatorName(String creatorName) {
        this.creatorName = creatorName;
        return this;
    }
    public String getCreatorName() {
        return this.creatorName;
    }

    public QueryReportDetailResponseBody setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public QueryReportDetailResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public QueryReportDetailResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public QueryReportDetailResponseBody setReportId(String reportId) {
        this.reportId = reportId;
        return this;
    }
    public String getReportId() {
        return this.reportId;
    }

    public QueryReportDetailResponseBody setTemplateName(String templateName) {
        this.templateName = templateName;
        return this;
    }
    public String getTemplateName() {
        return this.templateName;
    }

    public static class QueryReportDetailResponseBodyContent extends TeaModel {
        @NameInMap("images")
        public java.util.List<String> images;

        /**
         * <strong>example:</strong>
         * <p>今日工作</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("sort")
        public String sort;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>开发工作</p>
         */
        @NameInMap("value")
        public String value;

        public static QueryReportDetailResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryReportDetailResponseBodyContent self = new QueryReportDetailResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryReportDetailResponseBodyContent setImages(java.util.List<String> images) {
            this.images = images;
            return this;
        }
        public java.util.List<String> getImages() {
            return this.images;
        }

        public QueryReportDetailResponseBodyContent setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public QueryReportDetailResponseBodyContent setSort(String sort) {
            this.sort = sort;
            return this;
        }
        public String getSort() {
            return this.sort;
        }

        public QueryReportDetailResponseBodyContent setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryReportDetailResponseBodyContent setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
