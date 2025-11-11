// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkminutes_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetMinutesDetailsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public BatchGetMinutesDetailsResponse BatchGetMinutesDetailsWithOptions(BatchGetMinutesDetailsRequest request, BatchGetMinutesDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuids))
            {
                body["taskUuids"] = request.TaskUuids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMinutesDetails",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMinutesDetailsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetMinutesDetailsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public async Task<BatchGetMinutesDetailsResponse> BatchGetMinutesDetailsWithOptionsAsync(BatchGetMinutesDetailsRequest request, BatchGetMinutesDetailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuids))
            {
                body["taskUuids"] = request.TaskUuids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMinutesDetails",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMinutesDetailsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public BatchGetMinutesDetailsResponse BatchGetMinutesDetails(BatchGetMinutesDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetMinutesDetailsHeaders headers = new BatchGetMinutesDetailsHeaders();
            return BatchGetMinutesDetailsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取闪记详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetMinutesDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMinutesDetailsResponse
        /// </returns>
        public async Task<BatchGetMinutesDetailsResponse> BatchGetMinutesDetailsAsync(BatchGetMinutesDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetMinutesDetailsHeaders headers = new BatchGetMinutesDetailsHeaders();
            return await BatchGetMinutesDetailsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public DeleteMinutesResponse DeleteMinutesWithOptions(string taskUuid, DeleteMinutesRequest request, DeleteMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public async Task<DeleteMinutesResponse> DeleteMinutesWithOptionsAsync(string taskUuid, DeleteMinutesRequest request, DeleteMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public DeleteMinutesResponse DeleteMinutes(string taskUuid, DeleteMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMinutesHeaders headers = new DeleteMinutesHeaders();
            return DeleteMinutesWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪记</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMinutesResponse
        /// </returns>
        public async Task<DeleteMinutesResponse> DeleteMinutesAsync(string taskUuid, DeleteMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMinutesHeaders headers = new DeleteMinutesHeaders();
            return await DeleteMinutesWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// ExportMinutesTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public ExportMinutesTaskResultResponse ExportMinutesTaskResultWithOptions(ExportMinutesTaskResultRequest request, ExportMinutesTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryExportSetting))
            {
                body["summaryExportSetting"] = request.SummaryExportSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                body["taskUuid"] = request.TaskUuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportMinutesTaskResult",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/minutesTask/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportMinutesTaskResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// ExportMinutesTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public async Task<ExportMinutesTaskResultResponse> ExportMinutesTaskResultWithOptionsAsync(ExportMinutesTaskResultRequest request, ExportMinutesTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryExportSetting))
            {
                body["summaryExportSetting"] = request.SummaryExportSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                body["taskUuid"] = request.TaskUuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportMinutesTaskResult",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/minutesTask/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportMinutesTaskResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public ExportMinutesTaskResultResponse ExportMinutesTaskResult(ExportMinutesTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportMinutesTaskResultHeaders headers = new ExportMinutesTaskResultHeaders();
            return ExportMinutesTaskResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出闪记任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportMinutesTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportMinutesTaskResultResponse
        /// </returns>
        public async Task<ExportMinutesTaskResultResponse> ExportMinutesTaskResultAsync(ExportMinutesTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExportMinutesTaskResultHeaders headers = new ExportMinutesTaskResultHeaders();
            return await ExportMinutesTaskResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// OpenQueryMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public OpenQueryMinutesSummaryResponse OpenQueryMinutesSummaryWithOptions(OpenQueryMinutesSummaryRequest request, OpenQueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenQueryMinutesSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesSummary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenQueryMinutesSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// <param name="headers">
        /// OpenQueryMinutesSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public async Task<OpenQueryMinutesSummaryResponse> OpenQueryMinutesSummaryWithOptionsAsync(OpenQueryMinutesSummaryRequest request, OpenQueryMinutesSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenQueryMinutesSummary",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesSummary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenQueryMinutesSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public OpenQueryMinutesSummaryResponse OpenQueryMinutesSummary(OpenQueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenQueryMinutesSummaryHeaders headers = new OpenQueryMinutesSummaryHeaders();
            return OpenQueryMinutesSummaryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenQueryMinutesSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenQueryMinutesSummaryResponse
        /// </returns>
        public async Task<OpenQueryMinutesSummaryResponse> OpenQueryMinutesSummaryAsync(OpenQueryMinutesSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenQueryMinutesSummaryHeaders headers = new OpenQueryMinutesSummaryHeaders();
            return await OpenQueryMinutesSummaryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryBizMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public QueryBizMinutesResponse QueryBizMinutesWithOptions(QueryBizMinutesRequest request, QueryBizMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBizMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryBizMinutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryBizMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public async Task<QueryBizMinutesResponse> QueryBizMinutesWithOptionsAsync(QueryBizMinutesRequest request, QueryBizMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBizMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryBizMinutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public QueryBizMinutesResponse QueryBizMinutes(QueryBizMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizMinutesHeaders headers = new QueryBizMinutesHeaders();
            return QueryBizMinutesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪会、文档等来源的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBizMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBizMinutesResponse
        /// </returns>
        public async Task<QueryBizMinutesResponse> QueryBizMinutesAsync(QueryBizMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizMinutesHeaders headers = new QueryBizMinutesHeaders();
            return await QueryBizMinutesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// <param name="headers">
        /// QueryCreateMinutesListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public QueryCreateMinutesListResponse QueryCreateMinutesListWithOptions(QueryCreateMinutesListRequest request, QueryCreateMinutesListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCreateMinutesList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/createLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateMinutesListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// <param name="headers">
        /// QueryCreateMinutesListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public async Task<QueryCreateMinutesListResponse> QueryCreateMinutesListWithOptionsAsync(QueryCreateMinutesListRequest request, QueryCreateMinutesListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCreateMinutesList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/createLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateMinutesListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public QueryCreateMinutesListResponse QueryCreateMinutesList(QueryCreateMinutesListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCreateMinutesListHeaders headers = new QueryCreateMinutesListHeaders();
            return QueryCreateMinutesListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自己创建的闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateMinutesListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateMinutesListResponse
        /// </returns>
        public async Task<QueryCreateMinutesListResponse> QueryCreateMinutesListAsync(QueryCreateMinutesListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCreateMinutesListHeaders headers = new QueryCreateMinutesListHeaders();
            return await QueryCreateMinutesListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public QueryMinutesBasicInfoResponse QueryMinutesBasicInfoWithOptions(QueryMinutesBasicInfoRequest request, QueryMinutesBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesBasicInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesBasicInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public async Task<QueryMinutesBasicInfoResponse> QueryMinutesBasicInfoWithOptionsAsync(QueryMinutesBasicInfoRequest request, QueryMinutesBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                query["taskUuid"] = request.TaskUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesBasicInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/queryMinutesBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public QueryMinutesBasicInfoResponse QueryMinutesBasicInfo(QueryMinutesBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesBasicInfoHeaders headers = new QueryMinutesBasicInfoHeaders();
            return QueryMinutesBasicInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesBasicInfoResponse
        /// </returns>
        public async Task<QueryMinutesBasicInfoResponse> QueryMinutesBasicInfoAsync(QueryMinutesBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesBasicInfoHeaders headers = new QueryMinutesBasicInfoHeaders();
            return await QueryMinutesBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public QueryMinutesPlayInfoResponse QueryMinutesPlayInfoWithOptions(string taskUuid, QueryMinutesPlayInfoRequest request, QueryMinutesPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesPlayInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public async Task<QueryMinutesPlayInfoResponse> QueryMinutesPlayInfoWithOptionsAsync(string taskUuid, QueryMinutesPlayInfoRequest request, QueryMinutesPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesPlayInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public QueryMinutesPlayInfoResponse QueryMinutesPlayInfo(string taskUuid, QueryMinutesPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesPlayInfoHeaders headers = new QueryMinutesPlayInfoHeaders();
            return QueryMinutesPlayInfoWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记媒体播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesPlayInfoResponse
        /// </returns>
        public async Task<QueryMinutesPlayInfoResponse> QueryMinutesPlayInfoAsync(string taskUuid, QueryMinutesPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesPlayInfoHeaders headers = new QueryMinutesPlayInfoHeaders();
            return await QueryMinutesPlayInfoWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesShareListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public QueryMinutesShareListResponse QueryMinutesShareListWithOptions(QueryMinutesShareListRequest request, QueryMinutesShareListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesShareList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/shareLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesShareListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesShareListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public async Task<QueryMinutesShareListResponse> QueryMinutesShareListWithOptionsAsync(QueryMinutesShareListRequest request, QueryMinutesShareListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesShareList",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/shareLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesShareListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public QueryMinutesShareListResponse QueryMinutesShareList(QueryMinutesShareListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesShareListHeaders headers = new QueryMinutesShareListHeaders();
            return QueryMinutesShareListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取与我共享闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesShareListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesShareListResponse
        /// </returns>
        public async Task<QueryMinutesShareListResponse> QueryMinutesShareListAsync(QueryMinutesShareListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesShareListHeaders headers = new QueryMinutesShareListHeaders();
            return await QueryMinutesShareListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public QueryMinutesStatusResponse QueryMinutesStatusWithOptions(string taskUuid, QueryMinutesStatusRequest request, QueryMinutesStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesStatus",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/taskStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public async Task<QueryMinutesStatusResponse> QueryMinutesStatusWithOptionsAsync(string taskUuid, QueryMinutesStatusRequest request, QueryMinutesStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesStatus",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/taskStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public QueryMinutesStatusResponse QueryMinutesStatus(string taskUuid, QueryMinutesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesStatusHeaders headers = new QueryMinutesStatusHeaders();
            return QueryMinutesStatusWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesStatusResponse
        /// </returns>
        public async Task<QueryMinutesStatusResponse> QueryMinutesStatusAsync(string taskUuid, QueryMinutesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesStatusHeaders headers = new QueryMinutesStatusHeaders();
            return await QueryMinutesStatusWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记转写文本内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public QueryMinutesTextResponse QueryMinutesTextWithOptions(string taskUuid, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesText",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/textInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTextResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记转写文本内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// <param name="headers">
        /// QueryMinutesTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public async Task<QueryMinutesTextResponse> QueryMinutesTextWithOptionsAsync(string taskUuid, QueryMinutesTextRequest request, QueryMinutesTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinutesText",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/" + taskUuid + "/textInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinutesTextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记转写文本内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public QueryMinutesTextResponse QueryMinutesText(string taskUuid, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return QueryMinutesTextWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闪记转写文本内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinutesTextRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinutesTextResponse
        /// </returns>
        public async Task<QueryMinutesTextResponse> QueryMinutesTextAsync(string taskUuid, QueryMinutesTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMinutesTextHeaders headers = new QueryMinutesTextHeaders();
            return await QueryMinutesTextWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConfMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public QueryScheduleConfMinutesResponse QueryScheduleConfMinutesWithOptions(string scheduleConferenceId, QueryScheduleConfMinutesRequest request, QueryScheduleConfMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["eventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScheduleConfMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/scheduleConference/" + scheduleConferenceId + "/minutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfMinutesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// <param name="headers">
        /// QueryScheduleConfMinutesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public async Task<QueryScheduleConfMinutesResponse> QueryScheduleConfMinutesWithOptionsAsync(string scheduleConferenceId, QueryScheduleConfMinutesRequest request, QueryScheduleConfMinutesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["eventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScheduleConfMinutes",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/scheduleConference/" + scheduleConferenceId + "/minutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConfMinutesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public QueryScheduleConfMinutesResponse QueryScheduleConfMinutes(string scheduleConferenceId, QueryScheduleConfMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfMinutesHeaders headers = new QueryScheduleConfMinutesHeaders();
            return QueryScheduleConfMinutesWithOptions(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预约会议闪记列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScheduleConfMinutesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScheduleConfMinutesResponse
        /// </returns>
        public async Task<QueryScheduleConfMinutesResponse> QueryScheduleConfMinutesAsync(string scheduleConferenceId, QueryScheduleConfMinutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConfMinutesHeaders headers = new QueryScheduleConfMinutesHeaders();
            return await QueryScheduleConfMinutesWithOptionsAsync(scheduleConferenceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryUploadVideoPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public QueryUploadVideoPlayInfoResponse QueryUploadVideoPlayInfoWithOptions(string videoId, QueryUploadVideoPlayInfoRequest request, QueryUploadVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUploadVideoPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/uploadVideos/" + videoId + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUploadVideoPlayInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryUploadVideoPlayInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public async Task<QueryUploadVideoPlayInfoResponse> QueryUploadVideoPlayInfoWithOptionsAsync(string videoId, QueryUploadVideoPlayInfoRequest request, QueryUploadVideoPlayInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUploadVideoPlayInfo",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/uploadVideos/" + videoId + "/playInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUploadVideoPlayInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public QueryUploadVideoPlayInfoResponse QueryUploadVideoPlayInfo(string videoId, QueryUploadVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUploadVideoPlayInfoHeaders headers = new QueryUploadVideoPlayInfoHeaders();
            return QueryUploadVideoPlayInfoWithOptions(videoId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上传视频播放信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUploadVideoPlayInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUploadVideoPlayInfoResponse
        /// </returns>
        public async Task<QueryUploadVideoPlayInfoResponse> QueryUploadVideoPlayInfoAsync(string videoId, QueryUploadVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUploadVideoPlayInfoHeaders headers = new QueryUploadVideoPlayInfoHeaders();
            return await QueryUploadVideoPlayInfoWithOptionsAsync(videoId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMinutesTitleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public UpdateMinutesTitleResponse UpdateMinutesTitleWithOptions(string taskUuid, UpdateMinutesTitleRequest request, UpdateMinutesTitleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMinutesTitle",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/titles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMinutesTitleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMinutesTitleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public async Task<UpdateMinutesTitleResponse> UpdateMinutesTitleWithOptionsAsync(string taskUuid, UpdateMinutesTitleRequest request, UpdateMinutesTitleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMinutesTitle",
                Version = "minutes_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/minutes/flashMinutes/tasks/" + taskUuid + "/titles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMinutesTitleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public UpdateMinutesTitleResponse UpdateMinutesTitle(string taskUuid, UpdateMinutesTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMinutesTitleHeaders headers = new UpdateMinutesTitleHeaders();
            return UpdateMinutesTitleWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪记标题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMinutesTitleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMinutesTitleResponse
        /// </returns>
        public async Task<UpdateMinutesTitleResponse> UpdateMinutesTitleAsync(string taskUuid, UpdateMinutesTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMinutesTitleHeaders headers = new UpdateMinutesTitleHeaders();
            return await UpdateMinutesTitleWithOptionsAsync(taskUuid, request, headers, runtime);
        }

    }
}
