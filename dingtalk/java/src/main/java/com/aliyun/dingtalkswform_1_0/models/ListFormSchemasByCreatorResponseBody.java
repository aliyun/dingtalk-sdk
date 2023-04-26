// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormSchemasByCreatorResponseBody extends TeaModel {
    @NameInMap("result")
    public ListFormSchemasByCreatorResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ListFormSchemasByCreatorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFormSchemasByCreatorResponseBody self = new ListFormSchemasByCreatorResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFormSchemasByCreatorResponseBody setResult(ListFormSchemasByCreatorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListFormSchemasByCreatorResponseBodyResult getResult() {
        return this.result;
    }

    public ListFormSchemasByCreatorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListFormSchemasByCreatorResponseBodyResultListSetting extends TeaModel {
        @NameInMap("bizType")
        public Integer bizType;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("endTime")
        public String endTime;

        @NameInMap("formType")
        public Integer formType;

        @NameInMap("loopDays")
        public java.util.List<Integer> loopDays;

        @NameInMap("loopTime")
        public String loopTime;

        @NameInMap("stop")
        public Boolean stop;

        public static ListFormSchemasByCreatorResponseBodyResultListSetting build(java.util.Map<String, ?> map) throws Exception {
            ListFormSchemasByCreatorResponseBodyResultListSetting self = new ListFormSchemasByCreatorResponseBodyResultListSetting();
            return TeaModel.build(map, self);
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setFormType(Integer formType) {
            this.formType = formType;
            return this;
        }
        public Integer getFormType() {
            return this.formType;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setLoopDays(java.util.List<Integer> loopDays) {
            this.loopDays = loopDays;
            return this;
        }
        public java.util.List<Integer> getLoopDays() {
            return this.loopDays;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setLoopTime(String loopTime) {
            this.loopTime = loopTime;
            return this;
        }
        public String getLoopTime() {
            return this.loopTime;
        }

        public ListFormSchemasByCreatorResponseBodyResultListSetting setStop(Boolean stop) {
            this.stop = stop;
            return this;
        }
        public Boolean getStop() {
            return this.stop;
        }

    }

    public static class ListFormSchemasByCreatorResponseBodyResultList extends TeaModel {
        @NameInMap("creator")
        public String creator;

        @NameInMap("formCode")
        public String formCode;

        @NameInMap("memo")
        public String memo;

        @NameInMap("name")
        public String name;

        @NameInMap("setting")
        public ListFormSchemasByCreatorResponseBodyResultListSetting setting;

        public static ListFormSchemasByCreatorResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            ListFormSchemasByCreatorResponseBodyResultList self = new ListFormSchemasByCreatorResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public ListFormSchemasByCreatorResponseBodyResultList setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListFormSchemasByCreatorResponseBodyResultList setSetting(ListFormSchemasByCreatorResponseBodyResultListSetting setting) {
            this.setting = setting;
            return this;
        }
        public ListFormSchemasByCreatorResponseBodyResultListSetting getSetting() {
            return this.setting;
        }

    }

    public static class ListFormSchemasByCreatorResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<ListFormSchemasByCreatorResponseBodyResultList> list;

        @NameInMap("nextToken")
        public Long nextToken;

        public static ListFormSchemasByCreatorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListFormSchemasByCreatorResponseBodyResult self = new ListFormSchemasByCreatorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListFormSchemasByCreatorResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public ListFormSchemasByCreatorResponseBodyResult setList(java.util.List<ListFormSchemasByCreatorResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<ListFormSchemasByCreatorResponseBodyResultList> getList() {
            return this.list;
        }

        public ListFormSchemasByCreatorResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

    }

}
