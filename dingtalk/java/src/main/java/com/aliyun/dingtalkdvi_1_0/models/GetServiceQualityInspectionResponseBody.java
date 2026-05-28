// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceQualityInspectionResponseBody extends TeaModel {
    @NameInMap("result")
    public GetServiceQualityInspectionResponseBodyResult result;

    public static GetServiceQualityInspectionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetServiceQualityInspectionResponseBody self = new GetServiceQualityInspectionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetServiceQualityInspectionResponseBody setResult(GetServiceQualityInspectionResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetServiceQualityInspectionResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("time")
        public Long time;

        public static GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations build(java.util.Map<String, ?> map) throws Exception {
            GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations self = new GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations();
            return TeaModel.build(map, self);
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

    }

    public static class GetServiceQualityInspectionResponseBodyResultGroupListItemList extends TeaModel {
        @NameInMap("citations")
        public java.util.List<GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations> citations;

        @NameInMap("flowName")
        public String flowName;

        @NameInMap("highlights")
        public String highlights;

        @NameInMap("isHit")
        public String isHit;

        @NameInMap("name")
        public String name;

        @NameInMap("reason")
        public String reason;

        @NameInMap("score")
        public Integer score;

        @NameInMap("script")
        public String script;

        public static GetServiceQualityInspectionResponseBodyResultGroupListItemList build(java.util.Map<String, ?> map) throws Exception {
            GetServiceQualityInspectionResponseBodyResultGroupListItemList self = new GetServiceQualityInspectionResponseBodyResultGroupListItemList();
            return TeaModel.build(map, self);
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setCitations(java.util.List<GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations> citations) {
            this.citations = citations;
            return this;
        }
        public java.util.List<GetServiceQualityInspectionResponseBodyResultGroupListItemListCitations> getCitations() {
            return this.citations;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setFlowName(String flowName) {
            this.flowName = flowName;
            return this;
        }
        public String getFlowName() {
            return this.flowName;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setHighlights(String highlights) {
            this.highlights = highlights;
            return this;
        }
        public String getHighlights() {
            return this.highlights;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setIsHit(String isHit) {
            this.isHit = isHit;
            return this;
        }
        public String getIsHit() {
            return this.isHit;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setScore(Integer score) {
            this.score = score;
            return this;
        }
        public Integer getScore() {
            return this.score;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupListItemList setScript(String script) {
            this.script = script;
            return this;
        }
        public String getScript() {
            return this.script;
        }

    }

    public static class GetServiceQualityInspectionResponseBodyResultGroupList extends TeaModel {
        @NameInMap("itemList")
        public java.util.List<GetServiceQualityInspectionResponseBodyResultGroupListItemList> itemList;

        @NameInMap("name")
        public String name;

        public static GetServiceQualityInspectionResponseBodyResultGroupList build(java.util.Map<String, ?> map) throws Exception {
            GetServiceQualityInspectionResponseBodyResultGroupList self = new GetServiceQualityInspectionResponseBodyResultGroupList();
            return TeaModel.build(map, self);
        }

        public GetServiceQualityInspectionResponseBodyResultGroupList setItemList(java.util.List<GetServiceQualityInspectionResponseBodyResultGroupListItemList> itemList) {
            this.itemList = itemList;
            return this;
        }
        public java.util.List<GetServiceQualityInspectionResponseBodyResultGroupListItemList> getItemList() {
            return this.itemList;
        }

        public GetServiceQualityInspectionResponseBodyResultGroupList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetServiceQualityInspectionResponseBodyResult extends TeaModel {
        @NameInMap("groupList")
        public java.util.List<GetServiceQualityInspectionResponseBodyResultGroupList> groupList;

        @NameInMap("score")
        public Integer score;

        @NameInMap("summary")
        public String summary;

        public static GetServiceQualityInspectionResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetServiceQualityInspectionResponseBodyResult self = new GetServiceQualityInspectionResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetServiceQualityInspectionResponseBodyResult setGroupList(java.util.List<GetServiceQualityInspectionResponseBodyResultGroupList> groupList) {
            this.groupList = groupList;
            return this;
        }
        public java.util.List<GetServiceQualityInspectionResponseBodyResultGroupList> getGroupList() {
            return this.groupList;
        }

        public GetServiceQualityInspectionResponseBodyResult setScore(Integer score) {
            this.score = score;
            return this;
        }
        public Integer getScore() {
            return this.score;
        }

        public GetServiceQualityInspectionResponseBodyResult setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

    }

}
