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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 创建工单
         *
         * @param request CreateTicketRequest
         * @param headers CreateTicketHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicketResponse
         */
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

        /**
         * @summary 创建工单
         *
         * @param request CreateTicketRequest
         * @param headers CreateTicketHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicketResponse
         */
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

        /**
         * @summary 创建工单
         *
         * @param request CreateTicketRequest
         * @return CreateTicketResponse
         */
        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return CreateTicketWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建工单
         *
         * @param request CreateTicketRequest
         * @return CreateTicketResponse
         */
        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return await CreateTicketWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 执行工单活动
         *
         * @param request ExecuteActivityRequest
         * @param headers ExecuteActivityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteActivityResponse
         */
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

        /**
         * @summary 执行工单活动
         *
         * @param request ExecuteActivityRequest
         * @param headers ExecuteActivityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteActivityResponse
         */
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

        /**
         * @summary 执行工单活动
         *
         * @param request ExecuteActivityRequest
         * @return ExecuteActivityResponse
         */
        public ExecuteActivityResponse ExecuteActivity(string ticketId, ExecuteActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteActivityHeaders headers = new ExecuteActivityHeaders();
            return ExecuteActivityWithOptions(ticketId, request, headers, runtime);
        }

        /**
         * @summary 执行工单活动
         *
         * @param request ExecuteActivityRequest
         * @return ExecuteActivityResponse
         */
        public async Task<ExecuteActivityResponse> ExecuteActivityAsync(string ticketId, ExecuteActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteActivityHeaders headers = new ExecuteActivityHeaders();
            return await ExecuteActivityWithOptionsAsync(ticketId, request, headers, runtime);
        }

        /**
         * @summary 获取source列表
         *
         * @param request GetUserSourceListRequest
         * @param headers GetUserSourceListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserSourceListResponse
         */
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

        /**
         * @summary 获取source列表
         *
         * @param request GetUserSourceListRequest
         * @param headers GetUserSourceListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserSourceListResponse
         */
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

        /**
         * @summary 获取source列表
         *
         * @param request GetUserSourceListRequest
         * @return GetUserSourceListResponse
         */
        public GetUserSourceListResponse GetUserSourceList(GetUserSourceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserSourceListHeaders headers = new GetUserSourceListHeaders();
            return GetUserSourceListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取source列表
         *
         * @param request GetUserSourceListRequest
         * @return GetUserSourceListResponse
         */
        public async Task<GetUserSourceListResponse> GetUserSourceListAsync(GetUserSourceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserSourceListHeaders headers = new GetUserSourceListHeaders();
            return await GetUserSourceListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询动作记录
         *
         * @param request PageListActionRequest
         * @param headers PageListActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListActionResponse
         */
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

        /**
         * @summary 查询动作记录
         *
         * @param request PageListActionRequest
         * @param headers PageListActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListActionResponse
         */
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

        /**
         * @summary 查询动作记录
         *
         * @param request PageListActionRequest
         * @return PageListActionResponse
         */
        public PageListActionResponse PageListAction(string ticketId, PageListActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListActionHeaders headers = new PageListActionHeaders();
            return PageListActionWithOptions(ticketId, request, headers, runtime);
        }

        /**
         * @summary 查询动作记录
         *
         * @param request PageListActionRequest
         * @return PageListActionResponse
         */
        public async Task<PageListActionResponse> PageListActionAsync(string ticketId, PageListActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListActionHeaders headers = new PageListActionHeaders();
            return await PageListActionWithOptionsAsync(ticketId, request, headers, runtime);
        }

        /**
         * @summary 分页查询机器人信息
         *
         * @param request PageListRobotRequest
         * @param headers PageListRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListRobotResponse
         */
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

        /**
         * @summary 分页查询机器人信息
         *
         * @param request PageListRobotRequest
         * @param headers PageListRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListRobotResponse
         */
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

        /**
         * @summary 分页查询机器人信息
         *
         * @param request PageListRobotRequest
         * @return PageListRobotResponse
         */
        public PageListRobotResponse PageListRobot(PageListRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListRobotHeaders headers = new PageListRobotHeaders();
            return PageListRobotWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询机器人信息
         *
         * @param request PageListRobotRequest
         * @return PageListRobotResponse
         */
        public async Task<PageListRobotResponse> PageListRobotAsync(PageListRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListRobotHeaders headers = new PageListRobotHeaders();
            return await PageListRobotWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询工单
         *
         * @param request PageListTicketRequest
         * @param headers PageListTicketHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListTicketResponse
         */
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

        /**
         * @summary 分页查询工单
         *
         * @param request PageListTicketRequest
         * @param headers PageListTicketHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListTicketResponse
         */
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

        /**
         * @summary 分页查询工单
         *
         * @param request PageListTicketRequest
         * @return PageListTicketResponse
         */
        public PageListTicketResponse PageListTicket(PageListTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListTicketHeaders headers = new PageListTicketHeaders();
            return PageListTicketWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询工单
         *
         * @param request PageListTicketRequest
         * @return PageListTicketResponse
         */
        public async Task<PageListTicketResponse> PageListTicketAsync(PageListTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageListTicketHeaders headers = new PageListTicketHeaders();
            return await PageListTicketWithOptionsAsync(request, headers, runtime);
        }

    }
}
