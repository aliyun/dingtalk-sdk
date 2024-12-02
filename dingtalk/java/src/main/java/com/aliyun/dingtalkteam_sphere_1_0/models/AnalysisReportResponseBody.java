// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class AnalysisReportResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<AnalysisReportResponseBodyResult> result;

    public static AnalysisReportResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AnalysisReportResponseBody self = new AnalysisReportResponseBody();
        return TeaModel.build(map, self);
    }

    public AnalysisReportResponseBody setResult(java.util.List<AnalysisReportResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<AnalysisReportResponseBodyResult> getResult() {
        return this.result;
    }

    public static class AnalysisReportResponseBodyResultCols extends TeaModel {
        @NameInMap("baseType")
        public String baseType;

        @NameInMap("name")
        public String name;

        @NameInMap("theme")
        public String theme;

        public static AnalysisReportResponseBodyResultCols build(java.util.Map<String, ?> map) throws Exception {
            AnalysisReportResponseBodyResultCols self = new AnalysisReportResponseBodyResultCols();
            return TeaModel.build(map, self);
        }

        public AnalysisReportResponseBodyResultCols setBaseType(String baseType) {
            this.baseType = baseType;
            return this;
        }
        public String getBaseType() {
            return this.baseType;
        }

        public AnalysisReportResponseBodyResultCols setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AnalysisReportResponseBodyResultCols setTheme(String theme) {
            this.theme = theme;
            return this;
        }
        public String getTheme() {
            return this.theme;
        }

    }

    public static class AnalysisReportResponseBodyResultListQuery extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static AnalysisReportResponseBodyResultListQuery build(java.util.Map<String, ?> map) throws Exception {
            AnalysisReportResponseBodyResultListQuery self = new AnalysisReportResponseBodyResultListQuery();
            return TeaModel.build(map, self);
        }

        public AnalysisReportResponseBodyResultListQuery setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public AnalysisReportResponseBodyResultListQuery setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AnalysisReportResponseBodyResultVisualizationSettings extends TeaModel {
        @NameInMap("dimension")
        public Long dimension;

        @NameInMap("type")
        public String type;

        public static AnalysisReportResponseBodyResultVisualizationSettings build(java.util.Map<String, ?> map) throws Exception {
            AnalysisReportResponseBodyResultVisualizationSettings self = new AnalysisReportResponseBodyResultVisualizationSettings();
            return TeaModel.build(map, self);
        }

        public AnalysisReportResponseBodyResultVisualizationSettings setDimension(Long dimension) {
            this.dimension = dimension;
            return this;
        }
        public Long getDimension() {
            return this.dimension;
        }

        public AnalysisReportResponseBodyResultVisualizationSettings setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class AnalysisReportResponseBodyResult extends TeaModel {
        @NameInMap("cols")
        public java.util.List<AnalysisReportResponseBodyResultCols> cols;

        @NameInMap("listQuery")
        public java.util.List<java.util.List<AnalysisReportResponseBodyResultListQuery>> listQuery;

        @NameInMap("name")
        public String name;

        @NameInMap("rows")
        public java.util.List<java.util.List<String>> rows;

        @NameInMap("tips")
        public String tips;

        @NameInMap("title")
        public String title;

        @NameInMap("visualizationSettings")
        public AnalysisReportResponseBodyResultVisualizationSettings visualizationSettings;

        public static AnalysisReportResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AnalysisReportResponseBodyResult self = new AnalysisReportResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AnalysisReportResponseBodyResult setCols(java.util.List<AnalysisReportResponseBodyResultCols> cols) {
            this.cols = cols;
            return this;
        }
        public java.util.List<AnalysisReportResponseBodyResultCols> getCols() {
            return this.cols;
        }

        public AnalysisReportResponseBodyResult setListQuery(java.util.List<java.util.List<AnalysisReportResponseBodyResultListQuery>> listQuery) {
            this.listQuery = listQuery;
            return this;
        }
        public java.util.List<java.util.List<AnalysisReportResponseBodyResultListQuery>> getListQuery() {
            return this.listQuery;
        }

        public AnalysisReportResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AnalysisReportResponseBodyResult setRows(java.util.List<java.util.List<String>> rows) {
            this.rows = rows;
            return this;
        }
        public java.util.List<java.util.List<String>> getRows() {
            return this.rows;
        }

        public AnalysisReportResponseBodyResult setTips(String tips) {
            this.tips = tips;
            return this;
        }
        public String getTips() {
            return this.tips;
        }

        public AnalysisReportResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public AnalysisReportResponseBodyResult setVisualizationSettings(AnalysisReportResponseBodyResultVisualizationSettings visualizationSettings) {
            this.visualizationSettings = visualizationSettings;
            return this;
        }
        public AnalysisReportResponseBodyResultVisualizationSettings getVisualizationSettings() {
            return this.visualizationSettings;
        }

    }

}
