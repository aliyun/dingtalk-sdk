// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelDataQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public HrbrainLabelDataQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainLabelDataQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelDataQueryResponseBody self = new HrbrainLabelDataQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelDataQueryResponseBody setContent(HrbrainLabelDataQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public HrbrainLabelDataQueryResponseBodyContent getContent() {
        return this.content;
    }

    public HrbrainLabelDataQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainLabelDataQueryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainLabelDataQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainLabelDataQueryResponseBodyContentLabelDatas extends TeaModel {
        @NameInMap("deptName")
        public String deptName;

        @NameInMap("deptNo")
        public String deptNo;

        @NameInMap("jobLevel")
        public String jobLevel;

        @NameInMap("labelTitle")
        public String labelTitle;

        @NameInMap("labelValue")
        public String labelValue;

        @NameInMap("name")
        public String name;

        @NameInMap("postName")
        public String postName;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainLabelDataQueryResponseBodyContentLabelDatas build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelDataQueryResponseBodyContentLabelDatas self = new HrbrainLabelDataQueryResponseBodyContentLabelDatas();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setJobLevel(String jobLevel) {
            this.jobLevel = jobLevel;
            return this;
        }
        public String getJobLevel() {
            return this.jobLevel;
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setLabelTitle(String labelTitle) {
            this.labelTitle = labelTitle;
            return this;
        }
        public String getLabelTitle() {
            return this.labelTitle;
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setLabelValue(String labelValue) {
            this.labelValue = labelValue;
            return this;
        }
        public String getLabelValue() {
            return this.labelValue;
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setPostName(String postName) {
            this.postName = postName;
            return this;
        }
        public String getPostName() {
            return this.postName;
        }

        public HrbrainLabelDataQueryResponseBodyContentLabelDatas setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

    public static class HrbrainLabelDataQueryResponseBodyContent extends TeaModel {
        @NameInMap("labelDatas")
        public java.util.List<HrbrainLabelDataQueryResponseBodyContentLabelDatas> labelDatas;

        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("totalCount")
        public Long totalCount;

        public static HrbrainLabelDataQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelDataQueryResponseBodyContent self = new HrbrainLabelDataQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelDataQueryResponseBodyContent setLabelDatas(java.util.List<HrbrainLabelDataQueryResponseBodyContentLabelDatas> labelDatas) {
            this.labelDatas = labelDatas;
            return this;
        }
        public java.util.List<HrbrainLabelDataQueryResponseBodyContentLabelDatas> getLabelDatas() {
            return this.labelDatas;
        }

        public HrbrainLabelDataQueryResponseBodyContent setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public HrbrainLabelDataQueryResponseBodyContent setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public HrbrainLabelDataQueryResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
