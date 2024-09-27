// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkreport_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// CreateTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplatesResponse
        /// </returns>
        public CreateTemplatesResponse CreateTemplatesWithOptions(CreateTemplatesRequest request, CreateTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowAddReceivers))
            {
                body["allowAddReceivers"] = request.AllowAddReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowEdit))
            {
                body["allowEdit"] = request.AllowEdit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowGetLocation))
            {
                body["allowGetLocation"] = request.AllowGetLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthDeptIds))
            {
                body["authDeptIds"] = request.AuthDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUserIds))
            {
                body["authUserIds"] = request.AuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedCids))
            {
                body["defaultReceivedCids"] = request.DefaultReceivedCids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedMasterLevels))
            {
                body["defaultReceivedMasterLevels"] = request.DefaultReceivedMasterLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivers))
            {
                body["defaultReceivers"] = request.DefaultReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWordCount))
            {
                body["maxWordCount"] = request.MaxWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinWordCount))
            {
                body["minWordCount"] = request.MinWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateManagers))
            {
                body["templateManagers"] = request.TemplateManagers;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplates",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// CreateTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplatesResponse
        /// </returns>
        public async Task<CreateTemplatesResponse> CreateTemplatesWithOptionsAsync(CreateTemplatesRequest request, CreateTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowAddReceivers))
            {
                body["allowAddReceivers"] = request.AllowAddReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowEdit))
            {
                body["allowEdit"] = request.AllowEdit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowGetLocation))
            {
                body["allowGetLocation"] = request.AllowGetLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthDeptIds))
            {
                body["authDeptIds"] = request.AuthDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUserIds))
            {
                body["authUserIds"] = request.AuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedCids))
            {
                body["defaultReceivedCids"] = request.DefaultReceivedCids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivedMasterLevels))
            {
                body["defaultReceivedMasterLevels"] = request.DefaultReceivedMasterLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultReceivers))
            {
                body["defaultReceivers"] = request.DefaultReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                body["logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWordCount))
            {
                body["maxWordCount"] = request.MaxWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinWordCount))
            {
                body["minWordCount"] = request.MinWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateManagers))
            {
                body["templateManagers"] = request.TemplateManagers;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplates",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplatesResponse
        /// </returns>
        public CreateTemplatesResponse CreateTemplates(CreateTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplatesHeaders headers = new CreateTemplatesHeaders();
            return CreateTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplatesResponse
        /// </returns>
        public async Task<CreateTemplatesResponse> CreateTemplatesAsync(CreateTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplatesHeaders headers = new CreateTemplatesHeaders();
            return await CreateTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询员工提交和收到的日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSendAndReceiveReportListRequest
        /// </param>
        /// <param name="headers">
        /// GetSendAndReceiveReportListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSendAndReceiveReportListResponse
        /// </returns>
        public GetSendAndReceiveReportListResponse GetSendAndReceiveReportListWithOptions(GetSendAndReceiveReportListRequest request, GetSendAndReceiveReportListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "GetSendAndReceiveReportList",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/users/sendAndReceiveLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSendAndReceiveReportListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询员工提交和收到的日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSendAndReceiveReportListRequest
        /// </param>
        /// <param name="headers">
        /// GetSendAndReceiveReportListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSendAndReceiveReportListResponse
        /// </returns>
        public async Task<GetSendAndReceiveReportListResponse> GetSendAndReceiveReportListWithOptionsAsync(GetSendAndReceiveReportListRequest request, GetSendAndReceiveReportListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "GetSendAndReceiveReportList",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/users/sendAndReceiveLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSendAndReceiveReportListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询员工提交和收到的日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSendAndReceiveReportListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSendAndReceiveReportListResponse
        /// </returns>
        public GetSendAndReceiveReportListResponse GetSendAndReceiveReportList(GetSendAndReceiveReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSendAndReceiveReportListHeaders headers = new GetSendAndReceiveReportListHeaders();
            return GetSendAndReceiveReportListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询员工提交和收到的日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSendAndReceiveReportListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSendAndReceiveReportListResponse
        /// </returns>
        public async Task<GetSendAndReceiveReportListResponse> GetSendAndReceiveReportListAsync(GetSendAndReceiveReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSendAndReceiveReportListHeaders headers = new GetSendAndReceiveReportListHeaders();
            return await GetSendAndReceiveReportListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定周期的提交统计结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmitStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// GetSubmitStatisticsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubmitStatisticsResponse
        /// </returns>
        public GetSubmitStatisticsResponse GetSubmitStatisticsWithOptions(GetSubmitStatisticsRequest request, GetSubmitStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindId))
            {
                query["remindId"] = request.RemindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "GetSubmitStatistics",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/submitStatisticalResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubmitStatisticsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定周期的提交统计结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmitStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// GetSubmitStatisticsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubmitStatisticsResponse
        /// </returns>
        public async Task<GetSubmitStatisticsResponse> GetSubmitStatisticsWithOptionsAsync(GetSubmitStatisticsRequest request, GetSubmitStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindId))
            {
                query["remindId"] = request.RemindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "GetSubmitStatistics",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/submitStatisticalResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubmitStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定周期的提交统计结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmitStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubmitStatisticsResponse
        /// </returns>
        public GetSubmitStatisticsResponse GetSubmitStatistics(GetSubmitStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSubmitStatisticsHeaders headers = new GetSubmitStatisticsHeaders();
            return GetSubmitStatisticsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定周期的提交统计结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmitStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubmitStatisticsResponse
        /// </returns>
        public async Task<GetSubmitStatisticsResponse> GetSubmitStatisticsAsync(GetSubmitStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSubmitStatisticsHeaders headers = new GetSubmitStatisticsHeaders();
            return await GetSubmitStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建的统计规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRemindResultsRequest
        /// </param>
        /// <param name="headers">
        /// QueryRemindResultsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRemindResultsResponse
        /// </returns>
        public QueryRemindResultsResponse QueryRemindResultsWithOptions(QueryRemindResultsRequest request, QueryRemindResultsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "QueryRemindResults",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/statisticalRules/results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRemindResultsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建的统计规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRemindResultsRequest
        /// </param>
        /// <param name="headers">
        /// QueryRemindResultsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRemindResultsResponse
        /// </returns>
        public async Task<QueryRemindResultsResponse> QueryRemindResultsWithOptionsAsync(QueryRemindResultsRequest request, QueryRemindResultsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationUserId))
            {
                query["operationUserId"] = request.OperationUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "QueryRemindResults",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/statisticalRules/results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRemindResultsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建的统计规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRemindResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRemindResultsResponse
        /// </returns>
        public QueryRemindResultsResponse QueryRemindResults(QueryRemindResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRemindResultsHeaders headers = new QueryRemindResultsHeaders();
            return QueryRemindResultsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建的统计规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRemindResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRemindResultsResponse
        /// </returns>
        public async Task<QueryRemindResultsResponse> QueryRemindResultsAsync(QueryRemindResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRemindResultsHeaders headers = new QueryRemindResultsHeaders();
            return await QueryRemindResultsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryReportDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReportDetailResponse
        /// </returns>
        public QueryReportDetailResponse QueryReportDetailWithOptions(QueryReportDetailRequest request, QueryReportDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["reportId"] = request.ReportId;
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
                Action = "QueryReportDetail",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReportDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryReportDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReportDetailResponse
        /// </returns>
        public async Task<QueryReportDetailResponse> QueryReportDetailWithOptionsAsync(QueryReportDetailRequest request, QueryReportDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["reportId"] = request.ReportId;
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
                Action = "QueryReportDetail",
                Version = "report_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/report/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReportDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReportDetailResponse
        /// </returns>
        public QueryReportDetailResponse QueryReportDetail(QueryReportDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportDetailHeaders headers = new QueryReportDetailHeaders();
            return QueryReportDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReportDetailResponse
        /// </returns>
        public async Task<QueryReportDetailResponse> QueryReportDetailAsync(QueryReportDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportDetailHeaders headers = new QueryReportDetailHeaders();
            return await QueryReportDetailWithOptionsAsync(request, headers, runtime);
        }

    }
}
