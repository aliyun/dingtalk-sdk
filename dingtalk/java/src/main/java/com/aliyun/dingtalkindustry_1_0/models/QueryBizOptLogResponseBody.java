// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryBizOptLogResponseBody extends TeaModel {
    // content
    @NameInMap("content")
    public java.util.List<QueryBizOptLogResponseBodyContent> content;

    // 下次拉取数据的起始位置
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryBizOptLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBizOptLogResponseBody self = new QueryBizOptLogResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBizOptLogResponseBody setContent(java.util.List<QueryBizOptLogResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryBizOptLogResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryBizOptLogResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryBizOptLogResponseBodyContent extends TeaModel {
        // 业务类型
        @NameInMap("bizType")
        public Integer bizType;

        // 数据类型
        @NameInMap("dataType")
        public Integer dataType;

        // 日志ID
        @NameInMap("id")
        public Long id;

        // 操作后对象数据快照，json格式
        @NameInMap("optAfterData")
        public String optAfterData;

        // 操作前对象数据快照，json格式
        @NameInMap("optBeforeData")
        public String optBeforeData;

        // 操作业务类型
        @NameInMap("optBizType")
        public Integer optBizType;

        // 扩展信息，map json格式
        @NameInMap("optExtend")
        public String optExtend;

        // 操作者工号
        @NameInMap("optJobNumber")
        public String optJobNumber;

        // 操作对象code，人员code，或者部门code
        @NameInMap("optObjectCode")
        public String optObjectCode;

        // 操作对象名称
        @NameInMap("optObjectName")
        public String optObjectName;

        // 操作对象人员工号
        @NameInMap("optObjectUserJobNo")
        public String optObjectUserJobNo;

        // 操作是否成功
        @NameInMap("optSuccess")
        public Integer optSuccess;

        // 操作时间 时间戳
        @NameInMap("optTime")
        public Long optTime;

        // 操作类型
        @NameInMap("optType")
        public Integer optType;

        // 操作用户code
        @NameInMap("optUserCode")
        public String optUserCode;

        // 操作用户名称
        @NameInMap("optUserName")
        public String optUserName;

        // 备注
        @NameInMap("remark")
        public String remark;

        public static QueryBizOptLogResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryBizOptLogResponseBodyContent self = new QueryBizOptLogResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryBizOptLogResponseBodyContent setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public QueryBizOptLogResponseBodyContent setDataType(Integer dataType) {
            this.dataType = dataType;
            return this;
        }
        public Integer getDataType() {
            return this.dataType;
        }

        public QueryBizOptLogResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryBizOptLogResponseBodyContent setOptAfterData(String optAfterData) {
            this.optAfterData = optAfterData;
            return this;
        }
        public String getOptAfterData() {
            return this.optAfterData;
        }

        public QueryBizOptLogResponseBodyContent setOptBeforeData(String optBeforeData) {
            this.optBeforeData = optBeforeData;
            return this;
        }
        public String getOptBeforeData() {
            return this.optBeforeData;
        }

        public QueryBizOptLogResponseBodyContent setOptBizType(Integer optBizType) {
            this.optBizType = optBizType;
            return this;
        }
        public Integer getOptBizType() {
            return this.optBizType;
        }

        public QueryBizOptLogResponseBodyContent setOptExtend(String optExtend) {
            this.optExtend = optExtend;
            return this;
        }
        public String getOptExtend() {
            return this.optExtend;
        }

        public QueryBizOptLogResponseBodyContent setOptJobNumber(String optJobNumber) {
            this.optJobNumber = optJobNumber;
            return this;
        }
        public String getOptJobNumber() {
            return this.optJobNumber;
        }

        public QueryBizOptLogResponseBodyContent setOptObjectCode(String optObjectCode) {
            this.optObjectCode = optObjectCode;
            return this;
        }
        public String getOptObjectCode() {
            return this.optObjectCode;
        }

        public QueryBizOptLogResponseBodyContent setOptObjectName(String optObjectName) {
            this.optObjectName = optObjectName;
            return this;
        }
        public String getOptObjectName() {
            return this.optObjectName;
        }

        public QueryBizOptLogResponseBodyContent setOptObjectUserJobNo(String optObjectUserJobNo) {
            this.optObjectUserJobNo = optObjectUserJobNo;
            return this;
        }
        public String getOptObjectUserJobNo() {
            return this.optObjectUserJobNo;
        }

        public QueryBizOptLogResponseBodyContent setOptSuccess(Integer optSuccess) {
            this.optSuccess = optSuccess;
            return this;
        }
        public Integer getOptSuccess() {
            return this.optSuccess;
        }

        public QueryBizOptLogResponseBodyContent setOptTime(Long optTime) {
            this.optTime = optTime;
            return this;
        }
        public Long getOptTime() {
            return this.optTime;
        }

        public QueryBizOptLogResponseBodyContent setOptType(Integer optType) {
            this.optType = optType;
            return this;
        }
        public Integer getOptType() {
            return this.optType;
        }

        public QueryBizOptLogResponseBodyContent setOptUserCode(String optUserCode) {
            this.optUserCode = optUserCode;
            return this;
        }
        public String getOptUserCode() {
            return this.optUserCode;
        }

        public QueryBizOptLogResponseBodyContent setOptUserName(String optUserName) {
            this.optUserName = optUserName;
            return this;
        }
        public String getOptUserName() {
            return this.optUserName;
        }

        public QueryBizOptLogResponseBodyContent setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

    }

}
