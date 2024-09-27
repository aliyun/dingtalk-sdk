// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0
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
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="headers">
        /// CreateTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, CreateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignName))
            {
                body["foreignName"] = request.ForeignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                body["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                body["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateTicket",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="headers">
        /// CreateTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, CreateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignName))
            {
                body["foreignName"] = request.ForeignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                body["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                body["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateTicket",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return CreateTicketWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return await CreateTicketWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行工单活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteActivityRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteActivityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteActivityResponse
        /// </returns>
        public ExecuteActivityResponse ExecuteActivityWithOptions(string ticketId, ExecuteActivityRequest request, ExecuteActivityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityCode))
            {
                body["activityCode"] = request.ActivityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignName))
            {
                body["foreignName"] = request.ForeignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                body["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                body["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
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
                Action = "ExecuteActivity",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets/" + ticketId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteActivityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行工单活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteActivityRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteActivityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteActivityResponse
        /// </returns>
        public async Task<ExecuteActivityResponse> ExecuteActivityWithOptionsAsync(string ticketId, ExecuteActivityRequest request, ExecuteActivityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityCode))
            {
                body["activityCode"] = request.ActivityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignName))
            {
                body["foreignName"] = request.ForeignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                body["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                body["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
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
                Action = "ExecuteActivity",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets/" + ticketId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteActivityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行工单活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteActivityResponse
        /// </returns>
        public ExecuteActivityResponse ExecuteActivity(string ticketId, ExecuteActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteActivityHeaders headers = new ExecuteActivityHeaders();
            return ExecuteActivityWithOptions(ticketId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行工单活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteActivityResponse
        /// </returns>
        public async Task<ExecuteActivityResponse> ExecuteActivityAsync(string ticketId, ExecuteActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteActivityHeaders headers = new ExecuteActivityHeaders();
            return await ExecuteActivityWithOptionsAsync(ticketId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取source列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserSourceListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserSourceListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserSourceListResponse
        /// </returns>
        public GetUserSourceListResponse GetUserSourceListWithOptions(GetUserSourceListRequest request, GetUserSourceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
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
                Action = "GetUserSourceList",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/customers/sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserSourceListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取source列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserSourceListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserSourceListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserSourceListResponse
        /// </returns>
        public async Task<GetUserSourceListResponse> GetUserSourceListWithOptionsAsync(GetUserSourceListRequest request, GetUserSourceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
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
                Action = "GetUserSourceList",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/customers/sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserSourceListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取source列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserSourceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserSourceListResponse
        /// </returns>
        public GetUserSourceListResponse GetUserSourceList(GetUserSourceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserSourceListHeaders headers = new GetUserSourceListHeaders();
            return GetUserSourceListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取source列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserSourceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserSourceListResponse
        /// </returns>
        public async Task<GetUserSourceListResponse> GetUserSourceListAsync(GetUserSourceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserSourceListHeaders headers = new GetUserSourceListHeaders();
            return await GetUserSourceListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListActionRequest
        /// </param>
        /// <param name="headers">
        /// PageListActionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListActionResponse
        /// </returns>
        public PageListActionResponse PageListActionWithOptions(string ticketId, PageListActionRequest request, PageListActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
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
                Action = "PageListAction",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets/" + ticketId + "/actions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListActionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListActionRequest
        /// </param>
        /// <param name="headers">
        /// PageListActionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListActionResponse
        /// </returns>
        public async Task<PageListActionResponse> PageListActionWithOptionsAsync(string ticketId, PageListActionRequest request, PageListActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
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
                Action = "PageListAction",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets/" + ticketId + "/actions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListActionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListActionRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListActionResponse
        /// </returns>
        public PageListActionResponse PageListAction(string ticketId, PageListActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListActionHeaders headers = new PageListActionHeaders();
            return PageListActionWithOptions(ticketId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListActionRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListActionResponse
        /// </returns>
        public async Task<PageListActionResponse> PageListActionAsync(string ticketId, PageListActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListActionHeaders headers = new PageListActionHeaders();
            return await PageListActionWithOptionsAsync(ticketId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListRobotRequest
        /// </param>
        /// <param name="headers">
        /// PageListRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListRobotResponse
        /// </returns>
        public PageListRobotResponse PageListRobotWithOptions(PageListRobotRequest request, PageListRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
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
                Action = "PageListRobot",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListRobotResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListRobotRequest
        /// </param>
        /// <param name="headers">
        /// PageListRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListRobotResponse
        /// </returns>
        public async Task<PageListRobotResponse> PageListRobotWithOptionsAsync(PageListRobotRequest request, PageListRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
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
                Action = "PageListRobot",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListRobotResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListRobotResponse
        /// </returns>
        public PageListRobotResponse PageListRobot(PageListRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListRobotHeaders headers = new PageListRobotHeaders();
            return PageListRobotWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListRobotResponse
        /// </returns>
        public async Task<PageListRobotResponse> PageListRobotAsync(PageListRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListRobotHeaders headers = new PageListRobotHeaders();
            return await PageListRobotWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListTicketRequest
        /// </param>
        /// <param name="headers">
        /// PageListTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListTicketResponse
        /// </returns>
        public PageListTicketResponse PageListTicketWithOptions(PageListTicketRequest request, PageListTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                query["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketId))
            {
                query["ticketId"] = request.TicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketStatus))
            {
                query["ticketStatus"] = request.TicketStatus;
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
                Action = "PageListTicket",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListTicketResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListTicketRequest
        /// </param>
        /// <param name="headers">
        /// PageListTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListTicketResponse
        /// </returns>
        public async Task<PageListTicketResponse> PageListTicketWithOptionsAsync(PageListTicketRequest request, PageListTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                query["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenInstanceId))
            {
                query["openInstanceId"] = request.OpenInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionType))
            {
                query["productionType"] = request.ProductionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketId))
            {
                query["ticketId"] = request.TicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketStatus))
            {
                query["ticketStatus"] = request.TicketStatus;
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
                Action = "PageListTicket",
                Version = "customerService_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/customerService/tickets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListTicketResponse
        /// </returns>
        public PageListTicketResponse PageListTicket(PageListTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListTicketHeaders headers = new PageListTicketHeaders();
            return PageListTicketWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListTicketResponse
        /// </returns>
        public async Task<PageListTicketResponse> PageListTicketAsync(PageListTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListTicketHeaders headers = new PageListTicketHeaders();
            return await PageListTicketWithOptionsAsync(request, headers, runtime);
        }

    }
}
