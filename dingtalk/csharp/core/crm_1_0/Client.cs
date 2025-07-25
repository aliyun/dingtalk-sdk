// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcrm_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0
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
        /// <para>从私海放弃客户（退回公海）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbandonCustomerRequest
        /// </param>
        /// <param name="headers">
        /// AbandonCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbandonCustomerResponse
        /// </returns>
        public AbandonCustomerResponse AbandonCustomerWithOptions(AbandonCustomerRequest request, AbandonCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTrackDesc))
            {
                body["customTrackDesc"] = request.CustomTrackDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptType))
            {
                body["optType"] = request.OptType;
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
                Action = "AbandonCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/abandon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbandonCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从私海放弃客户（退回公海）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbandonCustomerRequest
        /// </param>
        /// <param name="headers">
        /// AbandonCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbandonCustomerResponse
        /// </returns>
        public async Task<AbandonCustomerResponse> AbandonCustomerWithOptionsAsync(AbandonCustomerRequest request, AbandonCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTrackDesc))
            {
                body["customTrackDesc"] = request.CustomTrackDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptType))
            {
                body["optType"] = request.OptType;
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
                Action = "AbandonCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/abandon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbandonCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从私海放弃客户（退回公海）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbandonCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// AbandonCustomerResponse
        /// </returns>
        public AbandonCustomerResponse AbandonCustomer(AbandonCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AbandonCustomerHeaders headers = new AbandonCustomerHeaders();
            return AbandonCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从私海放弃客户（退回公海）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbandonCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// AbandonCustomerResponse
        /// </returns>
        public async Task<AbandonCustomerResponse> AbandonCustomerAsync(AbandonCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AbandonCustomerHeaders headers = new AbandonCustomerHeaders();
            return await AbandonCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// AddCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCrmPersonalCustomerResponse
        /// </returns>
        public AddCrmPersonalCustomerResponse AddCrmPersonalCustomerWithOptions(AddCrmPersonalCustomerRequest request, AddCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNick))
            {
                body["creatorNick"] = request.CreatorNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "AddCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCrmPersonalCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// AddCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCrmPersonalCustomerResponse
        /// </returns>
        public async Task<AddCrmPersonalCustomerResponse> AddCrmPersonalCustomerWithOptionsAsync(AddCrmPersonalCustomerRequest request, AddCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNick))
            {
                body["creatorNick"] = request.CreatorNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "AddCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCrmPersonalCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCrmPersonalCustomerResponse
        /// </returns>
        public AddCrmPersonalCustomerResponse AddCrmPersonalCustomer(AddCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCrmPersonalCustomerHeaders headers = new AddCrmPersonalCustomerHeaders();
            return AddCrmPersonalCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCrmPersonalCustomerResponse
        /// </returns>
        public async Task<AddCrmPersonalCustomerResponse> AddCrmPersonalCustomerAsync(AddCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCrmPersonalCustomerHeaders headers = new AddCrmPersonalCustomerHeaders();
            return await AddCrmPersonalCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomerTrackRequest
        /// </param>
        /// <param name="headers">
        /// AddCustomerTrackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerTrackResponse
        /// </returns>
        public AddCustomerTrackResponse AddCustomerTrackWithOptions(AddCustomerTrackRequest request, AddCustomerTrackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["customerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraBizInfo))
            {
                body["extraBizInfo"] = request.ExtraBizInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentKey))
            {
                body["idempotentKey"] = request.IdempotentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskedContent))
            {
                body["maskedContent"] = request.MaskedContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "AddCustomerTrack",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerTracks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomerTrackResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomerTrackRequest
        /// </param>
        /// <param name="headers">
        /// AddCustomerTrackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerTrackResponse
        /// </returns>
        public async Task<AddCustomerTrackResponse> AddCustomerTrackWithOptionsAsync(AddCustomerTrackRequest request, AddCustomerTrackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["customerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraBizInfo))
            {
                body["extraBizInfo"] = request.ExtraBizInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentKey))
            {
                body["idempotentKey"] = request.IdempotentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskedContent))
            {
                body["maskedContent"] = request.MaskedContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "AddCustomerTrack",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerTracks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomerTrackResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomerTrackRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerTrackResponse
        /// </returns>
        public AddCustomerTrackResponse AddCustomerTrack(AddCustomerTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomerTrackHeaders headers = new AddCustomerTrackHeaders();
            return AddCustomerTrackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomerTrackRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerTrackResponse
        /// </returns>
        public async Task<AddCustomerTrackResponse> AddCustomerTrackAsync(AddCustomerTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomerTrackHeaders headers = new AddCustomerTrackHeaders();
            return await AddCustomerTrackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLeadsRequest
        /// </param>
        /// <param name="headers">
        /// AddLeadsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLeadsResponse
        /// </returns>
        public AddLeadsResponse AddLeadsWithOptions(AddLeadsRequest request, AddLeadsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignTimestamp))
            {
                body["assignTimestamp"] = request.AssignTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignedUserId))
            {
                body["assignedUserId"] = request.AssignedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Leads))
            {
                body["leads"] = request.Leads;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
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
                Action = "AddLeads",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/leads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLeadsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLeadsRequest
        /// </param>
        /// <param name="headers">
        /// AddLeadsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLeadsResponse
        /// </returns>
        public async Task<AddLeadsResponse> AddLeadsWithOptionsAsync(AddLeadsRequest request, AddLeadsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignTimestamp))
            {
                body["assignTimestamp"] = request.AssignTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignUserId))
            {
                body["assignUserId"] = request.AssignUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignedUserId))
            {
                body["assignedUserId"] = request.AssignedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Leads))
            {
                body["leads"] = request.Leads;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
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
                Action = "AddLeads",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/leads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLeadsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLeadsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLeadsResponse
        /// </returns>
        public AddLeadsResponse AddLeads(AddLeadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLeadsHeaders headers = new AddLeadsHeaders();
            return AddLeadsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddLeadsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLeadsResponse
        /// </returns>
        public async Task<AddLeadsResponse> AddLeadsAsync(AddLeadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLeadsHeaders headers = new AddLeadsHeaders();
            return await AddLeadsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMetaModelFieldRequest
        /// </param>
        /// <param name="headers">
        /// AddMetaModelFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMetaModelFieldResponse
        /// </returns>
        public AddMetaModelFieldResponse AddMetaModelFieldWithOptions(AddMetaModelFieldRequest request, AddMetaModelFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "AddMetaModelField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/metas/models/fields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMetaModelFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMetaModelFieldRequest
        /// </param>
        /// <param name="headers">
        /// AddMetaModelFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMetaModelFieldResponse
        /// </returns>
        public async Task<AddMetaModelFieldResponse> AddMetaModelFieldWithOptionsAsync(AddMetaModelFieldRequest request, AddMetaModelFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "AddMetaModelField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/metas/models/fields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMetaModelFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMetaModelFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMetaModelFieldResponse
        /// </returns>
        public AddMetaModelFieldResponse AddMetaModelField(AddMetaModelFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMetaModelFieldHeaders headers = new AddMetaModelFieldHeaders();
            return AddMetaModelFieldWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMetaModelFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMetaModelFieldResponse
        /// </returns>
        public async Task<AddMetaModelFieldResponse> AddMetaModelFieldAsync(AddMetaModelFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMetaModelFieldHeaders headers = new AddMetaModelFieldHeaders();
            return await AddMetaModelFieldWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRelationMetaFieldRequest
        /// </param>
        /// <param name="headers">
        /// AddRelationMetaFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRelationMetaFieldResponse
        /// </returns>
        public AddRelationMetaFieldResponse AddRelationMetaFieldWithOptions(AddRelationMetaFieldRequest request, AddRelationMetaFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "AddRelationMetaField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/fields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRelationMetaFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRelationMetaFieldRequest
        /// </param>
        /// <param name="headers">
        /// AddRelationMetaFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRelationMetaFieldResponse
        /// </returns>
        public async Task<AddRelationMetaFieldResponse> AddRelationMetaFieldWithOptionsAsync(AddRelationMetaFieldRequest request, AddRelationMetaFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "AddRelationMetaField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/fields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRelationMetaFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRelationMetaFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRelationMetaFieldResponse
        /// </returns>
        public AddRelationMetaFieldResponse AddRelationMetaField(AddRelationMetaFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRelationMetaFieldHeaders headers = new AddRelationMetaFieldHeaders();
            return AddRelationMetaFieldWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构增加字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRelationMetaFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRelationMetaFieldResponse
        /// </returns>
        public async Task<AddRelationMetaFieldResponse> AddRelationMetaFieldAsync(AddRelationMetaFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRelationMetaFieldHeaders headers = new AddRelationMetaFieldHeaders();
            return await AddRelationMetaFieldWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendCustomerDataAuthRequest
        /// </param>
        /// <param name="headers">
        /// AppendCustomerDataAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendCustomerDataAuthResponse
        /// </returns>
        public AppendCustomerDataAuthResponse AppendCustomerDataAuthWithOptions(AppendCustomerDataAuthRequest request, AppendCustomerDataAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerIds))
            {
                body["customerIds"] = request.CustomerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAuthUserIds))
            {
                body["dataAuthUserIds"] = request.DataAuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["roleType"] = request.RoleType;
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
                Action = "AppendCustomerDataAuth",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/dataAuth/append",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendCustomerDataAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendCustomerDataAuthRequest
        /// </param>
        /// <param name="headers">
        /// AppendCustomerDataAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendCustomerDataAuthResponse
        /// </returns>
        public async Task<AppendCustomerDataAuthResponse> AppendCustomerDataAuthWithOptionsAsync(AppendCustomerDataAuthRequest request, AppendCustomerDataAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerIds))
            {
                body["customerIds"] = request.CustomerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAuthUserIds))
            {
                body["dataAuthUserIds"] = request.DataAuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["roleType"] = request.RoleType;
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
                Action = "AppendCustomerDataAuth",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/dataAuth/append",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendCustomerDataAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendCustomerDataAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendCustomerDataAuthResponse
        /// </returns>
        public AppendCustomerDataAuthResponse AppendCustomerDataAuth(AppendCustomerDataAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendCustomerDataAuthHeaders headers = new AppendCustomerDataAuthHeaders();
            return AppendCustomerDataAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendCustomerDataAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendCustomerDataAuthResponse
        /// </returns>
        public async Task<AppendCustomerDataAuthResponse> AppendCustomerDataAuthAsync(AppendCustomerDataAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendCustomerDataAuthHeaders headers = new AppendCustomerDataAuthHeaders();
            return await AppendCustomerDataAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddContactsRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddContactsResponse
        /// </returns>
        public BatchAddContactsResponse BatchAddContactsWithOptions(BatchAddContactsRequest request, BatchAddContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
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
                Action = "BatchAddContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/contacts/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddContactsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddContactsRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddContactsResponse
        /// </returns>
        public async Task<BatchAddContactsResponse> BatchAddContactsWithOptionsAsync(BatchAddContactsRequest request, BatchAddContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
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
                Action = "BatchAddContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/contacts/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddContactsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddContactsResponse
        /// </returns>
        public BatchAddContactsResponse BatchAddContacts(BatchAddContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddContactsHeaders headers = new BatchAddContactsHeaders();
            return BatchAddContactsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddContactsResponse
        /// </returns>
        public async Task<BatchAddContactsResponse> BatchAddContactsAsync(BatchAddContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddContactsHeaders headers = new BatchAddContactsHeaders();
            return await BatchAddContactsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddFollowRecordsResponse
        /// </returns>
        public BatchAddFollowRecordsResponse BatchAddFollowRecordsWithOptions(BatchAddFollowRecordsRequest request, BatchAddFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                body["instanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "BatchAddFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/followRecords/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddFollowRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddFollowRecordsResponse
        /// </returns>
        public async Task<BatchAddFollowRecordsResponse> BatchAddFollowRecordsWithOptionsAsync(BatchAddFollowRecordsRequest request, BatchAddFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                body["instanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "BatchAddFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/followRecords/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddFollowRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddFollowRecordsResponse
        /// </returns>
        public BatchAddFollowRecordsResponse BatchAddFollowRecords(BatchAddFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddFollowRecordsHeaders headers = new BatchAddFollowRecordsHeaders();
            return BatchAddFollowRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddFollowRecordsResponse
        /// </returns>
        public async Task<BatchAddFollowRecordsResponse> BatchAddFollowRecordsAsync(BatchAddFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddFollowRecordsHeaders headers = new BatchAddFollowRecordsHeaders();
            return await BatchAddFollowRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddRelationDatasRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddRelationDatasHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddRelationDatasResponse
        /// </returns>
        public BatchAddRelationDatasResponse BatchAddRelationDatasWithOptions(BatchAddRelationDatasRequest request, BatchAddRelationDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "BatchAddRelationDatas",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relationDatas/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddRelationDatasResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddRelationDatasRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddRelationDatasHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddRelationDatasResponse
        /// </returns>
        public async Task<BatchAddRelationDatasResponse> BatchAddRelationDatasWithOptionsAsync(BatchAddRelationDatasRequest request, BatchAddRelationDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "BatchAddRelationDatas",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relationDatas/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddRelationDatasResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddRelationDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddRelationDatasResponse
        /// </returns>
        public BatchAddRelationDatasResponse BatchAddRelationDatas(BatchAddRelationDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddRelationDatasHeaders headers = new BatchAddRelationDatasHeaders();
            return BatchAddRelationDatasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddRelationDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddRelationDatasResponse
        /// </returns>
        public async Task<BatchAddRelationDatasResponse> BatchAddRelationDatasAsync(BatchAddRelationDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddRelationDatasHeaders headers = new BatchAddRelationDatasHeaders();
            return await BatchAddRelationDatasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建线索数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateClueDataRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateClueDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateClueDataResponse
        /// </returns>
        public BatchCreateClueDataResponse BatchCreateClueDataWithOptions(BatchCreateClueDataRequest request, BatchCreateClueDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataList))
            {
                body["dataList"] = request.DataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateSeas))
            {
                body["privateSeas"] = request.PrivateSeas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "BatchCreateClueData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/clues/datas/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateClueDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建线索数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateClueDataRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateClueDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateClueDataResponse
        /// </returns>
        public async Task<BatchCreateClueDataResponse> BatchCreateClueDataWithOptionsAsync(BatchCreateClueDataRequest request, BatchCreateClueDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataList))
            {
                body["dataList"] = request.DataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateSeas))
            {
                body["privateSeas"] = request.PrivateSeas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "BatchCreateClueData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/clues/datas/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateClueDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建线索数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateClueDataRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateClueDataResponse
        /// </returns>
        public BatchCreateClueDataResponse BatchCreateClueData(BatchCreateClueDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateClueDataHeaders headers = new BatchCreateClueDataHeaders();
            return BatchCreateClueDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建线索数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateClueDataRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateClueDataResponse
        /// </returns>
        public async Task<BatchCreateClueDataResponse> BatchCreateClueDataAsync(BatchCreateClueDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateClueDataHeaders headers = new BatchCreateClueDataHeaders();
            return await BatchCreateClueDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemoveFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// BatchRemoveFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRemoveFollowRecordsResponse
        /// </returns>
        public BatchRemoveFollowRecordsResponse BatchRemoveFollowRecordsWithOptions(BatchRemoveFollowRecordsRequest request, BatchRemoveFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                body["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "BatchRemoveFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/followRecords/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRemoveFollowRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemoveFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// BatchRemoveFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRemoveFollowRecordsResponse
        /// </returns>
        public async Task<BatchRemoveFollowRecordsResponse> BatchRemoveFollowRecordsWithOptionsAsync(BatchRemoveFollowRecordsRequest request, BatchRemoveFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                body["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "BatchRemoveFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/followRecords/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRemoveFollowRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemoveFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRemoveFollowRecordsResponse
        /// </returns>
        public BatchRemoveFollowRecordsResponse BatchRemoveFollowRecords(BatchRemoveFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRemoveFollowRecordsHeaders headers = new BatchRemoveFollowRecordsHeaders();
            return BatchRemoveFollowRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemoveFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRemoveFollowRecordsResponse
        /// </returns>
        public async Task<BatchRemoveFollowRecordsResponse> BatchRemoveFollowRecordsAsync(BatchRemoveFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRemoveFollowRecordsHeaders headers = new BatchRemoveFollowRecordsHeaders();
            return await BatchRemoveFollowRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOfficialAccountOTOMessageRequest
        /// </param>
        /// <param name="headers">
        /// BatchSendOfficialAccountOTOMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOfficialAccountOTOMessageResponse
        /// </returns>
        public BatchSendOfficialAccountOTOMessageResponse BatchSendOfficialAccountOTOMessageWithOptions(BatchSendOfficialAccountOTOMessageRequest request, BatchSendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "BatchSendOfficialAccountOTOMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendOfficialAccountOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOfficialAccountOTOMessageRequest
        /// </param>
        /// <param name="headers">
        /// BatchSendOfficialAccountOTOMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOfficialAccountOTOMessageResponse
        /// </returns>
        public async Task<BatchSendOfficialAccountOTOMessageResponse> BatchSendOfficialAccountOTOMessageWithOptionsAsync(BatchSendOfficialAccountOTOMessageRequest request, BatchSendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "BatchSendOfficialAccountOTOMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendOfficialAccountOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOfficialAccountOTOMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOfficialAccountOTOMessageResponse
        /// </returns>
        public BatchSendOfficialAccountOTOMessageResponse BatchSendOfficialAccountOTOMessage(BatchSendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOfficialAccountOTOMessageHeaders headers = new BatchSendOfficialAccountOTOMessageHeaders();
            return BatchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOfficialAccountOTOMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOfficialAccountOTOMessageResponse
        /// </returns>
        public async Task<BatchSendOfficialAccountOTOMessageResponse> BatchSendOfficialAccountOTOMessageAsync(BatchSendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOfficialAccountOTOMessageHeaders headers = new BatchSendOfficialAccountOTOMessageHeaders();
            return await BatchSendOfficialAccountOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateContactsRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateContactsResponse
        /// </returns>
        public BatchUpdateContactsResponse BatchUpdateContactsWithOptions(BatchUpdateContactsRequest request, BatchUpdateContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
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
                Action = "BatchUpdateContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/contacts/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateContactsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateContactsRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateContactsResponse
        /// </returns>
        public async Task<BatchUpdateContactsResponse> BatchUpdateContactsWithOptionsAsync(BatchUpdateContactsRequest request, BatchUpdateContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
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
                Action = "BatchUpdateContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/contacts/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateContactsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateContactsResponse
        /// </returns>
        public BatchUpdateContactsResponse BatchUpdateContacts(BatchUpdateContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateContactsHeaders headers = new BatchUpdateContactsHeaders();
            return BatchUpdateContactsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateContactsResponse
        /// </returns>
        public async Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(BatchUpdateContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateContactsHeaders headers = new BatchUpdateContactsHeaders();
            return await BatchUpdateContactsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFollowRecordsResponse
        /// </returns>
        public BatchUpdateFollowRecordsResponse BatchUpdateFollowRecordsWithOptions(BatchUpdateFollowRecordsRequest request, BatchUpdateFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                body["instanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "BatchUpdateFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/followRecords/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFollowRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFollowRecordsResponse
        /// </returns>
        public async Task<BatchUpdateFollowRecordsResponse> BatchUpdateFollowRecordsWithOptionsAsync(BatchUpdateFollowRecordsRequest request, BatchUpdateFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                body["instanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "BatchUpdateFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/followRecords/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFollowRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFollowRecordsResponse
        /// </returns>
        public BatchUpdateFollowRecordsResponse BatchUpdateFollowRecords(BatchUpdateFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateFollowRecordsHeaders headers = new BatchUpdateFollowRecordsHeaders();
            return BatchUpdateFollowRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改跟进记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFollowRecordsResponse
        /// </returns>
        public async Task<BatchUpdateFollowRecordsResponse> BatchUpdateFollowRecordsAsync(BatchUpdateFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateFollowRecordsHeaders headers = new BatchUpdateFollowRecordsHeaders();
            return await BatchUpdateFollowRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateRelationDatasRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateRelationDatasHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateRelationDatasResponse
        /// </returns>
        public BatchUpdateRelationDatasResponse BatchUpdateRelationDatasWithOptions(BatchUpdateRelationDatasRequest request, BatchUpdateRelationDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "BatchUpdateRelationDatas",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relationDatas/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateRelationDatasResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateRelationDatasRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateRelationDatasHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateRelationDatasResponse
        /// </returns>
        public async Task<BatchUpdateRelationDatasResponse> BatchUpdateRelationDatasWithOptionsAsync(BatchUpdateRelationDatasRequest request, BatchUpdateRelationDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationList))
            {
                body["relationList"] = request.RelationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "BatchUpdateRelationDatas",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relationDatas/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateRelationDatasResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateRelationDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateRelationDatasResponse
        /// </returns>
        public BatchUpdateRelationDatasResponse BatchUpdateRelationDatas(BatchUpdateRelationDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateRelationDatasHeaders headers = new BatchUpdateRelationDatasHeaders();
            return BatchUpdateRelationDatasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateRelationDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateRelationDatasResponse
        /// </returns>
        public async Task<BatchUpdateRelationDatasResponse> BatchUpdateRelationDatasAsync(BatchUpdateRelationDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateRelationDatasHeaders headers = new BatchUpdateRelationDatasHeaders();
            return await BatchUpdateRelationDatasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核销权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConsumeBenefitInventoryRequest
        /// </param>
        /// <param name="headers">
        /// ConsumeBenefitInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConsumeBenefitInventoryResponse
        /// </returns>
        public ConsumeBenefitInventoryResponse ConsumeBenefitInventoryWithOptions(ConsumeBenefitInventoryRequest request, ConsumeBenefitInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeQuota))
            {
                body["consumeQuota"] = request.ConsumeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
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
                Action = "ConsumeBenefitInventory",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitInventories/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumeBenefitInventoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核销权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConsumeBenefitInventoryRequest
        /// </param>
        /// <param name="headers">
        /// ConsumeBenefitInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConsumeBenefitInventoryResponse
        /// </returns>
        public async Task<ConsumeBenefitInventoryResponse> ConsumeBenefitInventoryWithOptionsAsync(ConsumeBenefitInventoryRequest request, ConsumeBenefitInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeQuota))
            {
                body["consumeQuota"] = request.ConsumeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
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
                Action = "ConsumeBenefitInventory",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitInventories/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumeBenefitInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核销权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConsumeBenefitInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ConsumeBenefitInventoryResponse
        /// </returns>
        public ConsumeBenefitInventoryResponse ConsumeBenefitInventory(ConsumeBenefitInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsumeBenefitInventoryHeaders headers = new ConsumeBenefitInventoryHeaders();
            return ConsumeBenefitInventoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核销权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConsumeBenefitInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ConsumeBenefitInventoryResponse
        /// </returns>
        public async Task<ConsumeBenefitInventoryResponse> ConsumeBenefitInventoryAsync(ConsumeBenefitInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsumeBenefitInventoryHeaders headers = new ConsumeBenefitInventoryHeaders();
            return await ConsumeBenefitInventoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CRM客户通讯录数据写入接口，支持客户&amp;联系人数据合并写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// <param name="headers">
        /// CreateCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public CreateCustomerResponse CreateCustomerWithOptions(CreateCustomerRequest request, CreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contacts))
            {
                body["contacts"] = request.Contacts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveOption))
            {
                body["saveOption"] = request.SaveOption;
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
                Action = "CreateCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CRM客户通讯录数据写入接口，支持客户&amp;联系人数据合并写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// <param name="headers">
        /// CreateCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public async Task<CreateCustomerResponse> CreateCustomerWithOptionsAsync(CreateCustomerRequest request, CreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contacts))
            {
                body["contacts"] = request.Contacts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveOption))
            {
                body["saveOption"] = request.SaveOption;
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
                Action = "CreateCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CRM客户通讯录数据写入接口，支持客户&amp;联系人数据合并写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return CreateCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CRM客户通讯录数据写入接口，支持客户&amp;联系人数据合并写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public async Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return await CreateCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                body["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
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
                Action = "CreateGroup",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                body["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
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
                Action = "CreateGroup",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return CreateGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return await CreateGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupSetResponse
        /// </returns>
        public CreateGroupSetResponse CreateGroupSetWithOptions(CreateGroupSetRequest request, CreateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserIds))
            {
                body["managerUserIds"] = request.ManagerUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberQuota))
            {
                body["memberQuota"] = request.MemberQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notice))
            {
                body["notice"] = request.Notice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeToped))
            {
                body["noticeToped"] = request.NoticeToped;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Welcome))
            {
                body["welcome"] = request.Welcome;
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
                Action = "CreateGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupSetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupSetResponse
        /// </returns>
        public async Task<CreateGroupSetResponse> CreateGroupSetWithOptionsAsync(CreateGroupSetRequest request, CreateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserIds))
            {
                body["managerUserIds"] = request.ManagerUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberQuota))
            {
                body["memberQuota"] = request.MemberQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notice))
            {
                body["notice"] = request.Notice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeToped))
            {
                body["noticeToped"] = request.NoticeToped;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Welcome))
            {
                body["welcome"] = request.Welcome;
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
                Action = "CreateGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupSetResponse
        /// </returns>
        public CreateGroupSetResponse CreateGroupSet(CreateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
            return CreateGroupSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupSetResponse
        /// </returns>
        public async Task<CreateGroupSetResponse> CreateGroupSetAsync(CreateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
            return await CreateGroupSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRelationMetaRequest
        /// </param>
        /// <param name="headers">
        /// CreateRelationMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRelationMetaResponse
        /// </returns>
        public CreateRelationMetaResponse CreateRelationMetaWithOptions(CreateRelationMetaRequest request, CreateRelationMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationMetaDTO))
            {
                body["relationMetaDTO"] = request.RelationMetaDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "CreateRelationMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRelationMetaResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRelationMetaRequest
        /// </param>
        /// <param name="headers">
        /// CreateRelationMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRelationMetaResponse
        /// </returns>
        public async Task<CreateRelationMetaResponse> CreateRelationMetaWithOptionsAsync(CreateRelationMetaRequest request, CreateRelationMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationMetaDTO))
            {
                body["relationMetaDTO"] = request.RelationMetaDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "CreateRelationMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRelationMetaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRelationMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRelationMetaResponse
        /// </returns>
        public CreateRelationMetaResponse CreateRelationMeta(CreateRelationMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRelationMetaHeaders headers = new CreateRelationMetaHeaders();
            return CreateRelationMetaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRelationMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRelationMetaResponse
        /// </returns>
        public async Task<CreateRelationMetaResponse> CreateRelationMetaAsync(CreateRelationMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRelationMetaHeaders headers = new CreateRelationMetaHeaders();
            return await CreateRelationMetaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除CRM自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmCustomObjectDataRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCrmCustomObjectDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmCustomObjectDataResponse
        /// </returns>
        public DeleteCrmCustomObjectDataResponse DeleteCrmCustomObjectDataWithOptions(string instanceId, DeleteCrmCustomObjectDataRequest request, DeleteCrmCustomObjectDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
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
                Action = "DeleteCrmCustomObjectData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customObjectDatas/instances/" + instanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrmCustomObjectDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除CRM自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmCustomObjectDataRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCrmCustomObjectDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmCustomObjectDataResponse
        /// </returns>
        public async Task<DeleteCrmCustomObjectDataResponse> DeleteCrmCustomObjectDataWithOptionsAsync(string instanceId, DeleteCrmCustomObjectDataRequest request, DeleteCrmCustomObjectDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                query["formCode"] = request.FormCode;
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
                Action = "DeleteCrmCustomObjectData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customObjectDatas/instances/" + instanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrmCustomObjectDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除CRM自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmCustomObjectDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmCustomObjectDataResponse
        /// </returns>
        public DeleteCrmCustomObjectDataResponse DeleteCrmCustomObjectData(string instanceId, DeleteCrmCustomObjectDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmCustomObjectDataHeaders headers = new DeleteCrmCustomObjectDataHeaders();
            return DeleteCrmCustomObjectDataWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除CRM自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmCustomObjectDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmCustomObjectDataResponse
        /// </returns>
        public async Task<DeleteCrmCustomObjectDataResponse> DeleteCrmCustomObjectDataAsync(string instanceId, DeleteCrmCustomObjectDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmCustomObjectDataHeaders headers = new DeleteCrmCustomObjectDataHeaders();
            return await DeleteCrmCustomObjectDataWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>crm自定义表单数据删除接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCrmFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmFormInstanceResponse
        /// </returns>
        public DeleteCrmFormInstanceResponse DeleteCrmFormInstanceWithOptions(string instanceId, DeleteCrmFormInstanceRequest request, DeleteCrmFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "DeleteCrmFormInstance",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/formInstances/" + instanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrmFormInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>crm自定义表单数据删除接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmFormInstanceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCrmFormInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmFormInstanceResponse
        /// </returns>
        public async Task<DeleteCrmFormInstanceResponse> DeleteCrmFormInstanceWithOptionsAsync(string instanceId, DeleteCrmFormInstanceRequest request, DeleteCrmFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "DeleteCrmFormInstance",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/formInstances/" + instanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrmFormInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>crm自定义表单数据删除接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmFormInstanceResponse
        /// </returns>
        public DeleteCrmFormInstanceResponse DeleteCrmFormInstance(string instanceId, DeleteCrmFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmFormInstanceHeaders headers = new DeleteCrmFormInstanceHeaders();
            return DeleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>crm自定义表单数据删除接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmFormInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmFormInstanceResponse
        /// </returns>
        public async Task<DeleteCrmFormInstanceResponse> DeleteCrmFormInstanceAsync(string instanceId, DeleteCrmFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmFormInstanceHeaders headers = new DeleteCrmFormInstanceHeaders();
            return await DeleteCrmFormInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmPersonalCustomerResponse
        /// </returns>
        public DeleteCrmPersonalCustomerResponse DeleteCrmPersonalCustomerWithOptions(string dataId, DeleteCrmPersonalCustomerRequest request, DeleteCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "DeleteCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers/" + dataId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrmPersonalCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmPersonalCustomerResponse
        /// </returns>
        public async Task<DeleteCrmPersonalCustomerResponse> DeleteCrmPersonalCustomerWithOptionsAsync(string dataId, DeleteCrmPersonalCustomerRequest request, DeleteCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "DeleteCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers/" + dataId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrmPersonalCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmPersonalCustomerResponse
        /// </returns>
        public DeleteCrmPersonalCustomerResponse DeleteCrmPersonalCustomer(string dataId, DeleteCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmPersonalCustomerHeaders headers = new DeleteCrmPersonalCustomerHeaders();
            return DeleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrmPersonalCustomerResponse
        /// </returns>
        public async Task<DeleteCrmPersonalCustomerResponse> DeleteCrmPersonalCustomerAsync(string dataId, DeleteCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmPersonalCustomerHeaders headers = new DeleteCrmPersonalCustomerHeaders();
            return await DeleteCrmPersonalCustomerWithOptionsAsync(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLeadsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteLeadsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLeadsResponse
        /// </returns>
        public DeleteLeadsResponse DeleteLeadsWithOptions(DeleteLeadsRequest request, DeleteLeadsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutLeadsIds))
            {
                body["outLeadsIds"] = request.OutLeadsIds;
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
                Action = "DeleteLeads",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/leads/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLeadsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLeadsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteLeadsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLeadsResponse
        /// </returns>
        public async Task<DeleteLeadsResponse> DeleteLeadsWithOptionsAsync(DeleteLeadsRequest request, DeleteLeadsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutLeadsIds))
            {
                body["outLeadsIds"] = request.OutLeadsIds;
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
                Action = "DeleteLeads",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/leads/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLeadsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLeadsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLeadsResponse
        /// </returns>
        public DeleteLeadsResponse DeleteLeads(DeleteLeadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLeadsHeaders headers = new DeleteLeadsHeaders();
            return DeleteLeadsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除线索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLeadsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLeadsResponse
        /// </returns>
        public async Task<DeleteLeadsResponse> DeleteLeadsAsync(DeleteLeadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLeadsHeaders headers = new DeleteLeadsHeaders();
            return await DeleteLeadsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构删除字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRelationMetaFieldRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRelationMetaFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRelationMetaFieldResponse
        /// </returns>
        public DeleteRelationMetaFieldResponse DeleteRelationMetaFieldWithOptions(DeleteRelationMetaFieldRequest request, DeleteRelationMetaFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldIdList))
            {
                body["fieldIdList"] = request.FieldIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "DeleteRelationMetaField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/fields/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRelationMetaFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构删除字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRelationMetaFieldRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRelationMetaFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRelationMetaFieldResponse
        /// </returns>
        public async Task<DeleteRelationMetaFieldResponse> DeleteRelationMetaFieldWithOptionsAsync(DeleteRelationMetaFieldRequest request, DeleteRelationMetaFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldIdList))
            {
                body["fieldIdList"] = request.FieldIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "DeleteRelationMetaField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/fields/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRelationMetaFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构删除字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRelationMetaFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRelationMetaFieldResponse
        /// </returns>
        public DeleteRelationMetaFieldResponse DeleteRelationMetaField(DeleteRelationMetaFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRelationMetaFieldHeaders headers = new DeleteRelationMetaFieldHeaders();
            return DeleteRelationMetaFieldWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构删除字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRelationMetaFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRelationMetaFieldResponse
        /// </returns>
        public async Task<DeleteRelationMetaFieldResponse> DeleteRelationMetaFieldAsync(DeleteRelationMetaFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRelationMetaFieldHeaders headers = new DeleteRelationMetaFieldHeaders();
            return await DeleteRelationMetaFieldWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM客户对象的元数据描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrmPersonalCustomerObjectMetaRequest
        /// </param>
        /// <param name="headers">
        /// DescribeCrmPersonalCustomerObjectMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrmPersonalCustomerObjectMetaResponse
        /// </returns>
        public DescribeCrmPersonalCustomerObjectMetaResponse DescribeCrmPersonalCustomerObjectMetaWithOptions(DescribeCrmPersonalCustomerObjectMetaRequest request, DescribeCrmPersonalCustomerObjectMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "DescribeCrmPersonalCustomerObjectMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers/objectMeta",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrmPersonalCustomerObjectMetaResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM客户对象的元数据描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrmPersonalCustomerObjectMetaRequest
        /// </param>
        /// <param name="headers">
        /// DescribeCrmPersonalCustomerObjectMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrmPersonalCustomerObjectMetaResponse
        /// </returns>
        public async Task<DescribeCrmPersonalCustomerObjectMetaResponse> DescribeCrmPersonalCustomerObjectMetaWithOptionsAsync(DescribeCrmPersonalCustomerObjectMetaRequest request, DescribeCrmPersonalCustomerObjectMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "DescribeCrmPersonalCustomerObjectMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers/objectMeta",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrmPersonalCustomerObjectMetaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM客户对象的元数据描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrmPersonalCustomerObjectMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrmPersonalCustomerObjectMetaResponse
        /// </returns>
        public DescribeCrmPersonalCustomerObjectMetaResponse DescribeCrmPersonalCustomerObjectMeta(DescribeCrmPersonalCustomerObjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeCrmPersonalCustomerObjectMetaHeaders headers = new DescribeCrmPersonalCustomerObjectMetaHeaders();
            return DescribeCrmPersonalCustomerObjectMetaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM客户对象的元数据描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrmPersonalCustomerObjectMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrmPersonalCustomerObjectMetaResponse
        /// </returns>
        public async Task<DescribeCrmPersonalCustomerObjectMetaResponse> DescribeCrmPersonalCustomerObjectMetaAsync(DescribeCrmPersonalCustomerObjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeCrmPersonalCustomerObjectMetaHeaders headers = new DescribeCrmPersonalCustomerObjectMetaHeaders();
            return await DescribeCrmPersonalCustomerObjectMetaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetaModelRequest
        /// </param>
        /// <param name="headers">
        /// DescribeMetaModelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetaModelResponse
        /// </returns>
        public DescribeMetaModelResponse DescribeMetaModelWithOptions(DescribeMetaModelRequest request, DescribeMetaModelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                body["bizTypes"] = request.BizTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "DescribeMetaModel",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/metas/models/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetaModelResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetaModelRequest
        /// </param>
        /// <param name="headers">
        /// DescribeMetaModelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetaModelResponse
        /// </returns>
        public async Task<DescribeMetaModelResponse> DescribeMetaModelWithOptionsAsync(DescribeMetaModelRequest request, DescribeMetaModelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                body["bizTypes"] = request.BizTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "DescribeMetaModel",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/metas/models/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetaModelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetaModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetaModelResponse
        /// </returns>
        public DescribeMetaModelResponse DescribeMetaModel(DescribeMetaModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeMetaModelHeaders headers = new DescribeMetaModelHeaders();
            return DescribeMetaModelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetaModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetaModelResponse
        /// </returns>
        public async Task<DescribeMetaModelResponse> DescribeMetaModelAsync(DescribeMetaModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeMetaModelHeaders headers = new DescribeMetaModelHeaders();
            return await DescribeMetaModelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRelationMetaRequest
        /// </param>
        /// <param name="headers">
        /// DescribeRelationMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRelationMetaResponse
        /// </returns>
        public DescribeRelationMetaResponse DescribeRelationMetaWithOptions(DescribeRelationMetaRequest request, DescribeRelationMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationTypes))
            {
                body["relationTypes"] = request.RelationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "DescribeRelationMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRelationMetaResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRelationMetaRequest
        /// </param>
        /// <param name="headers">
        /// DescribeRelationMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRelationMetaResponse
        /// </returns>
        public async Task<DescribeRelationMetaResponse> DescribeRelationMetaWithOptionsAsync(DescribeRelationMetaRequest request, DescribeRelationMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationTypes))
            {
                body["relationTypes"] = request.RelationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "DescribeRelationMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRelationMetaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRelationMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRelationMetaResponse
        /// </returns>
        public DescribeRelationMetaResponse DescribeRelationMeta(DescribeRelationMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeRelationMetaHeaders headers = new DescribeRelationMetaHeaders();
            return DescribeRelationMetaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询关系模型表结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRelationMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRelationMetaResponse
        /// </returns>
        public async Task<DescribeRelationMetaResponse> DescribeRelationMetaAsync(DescribeRelationMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeRelationMetaHeaders headers = new DescribeRelationMetaHeaders();
            return await DescribeRelationMetaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取关联对象的跟进记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindTargetRelatedFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// FindTargetRelatedFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindTargetRelatedFollowRecordsResponse
        /// </returns>
        public FindTargetRelatedFollowRecordsResponse FindTargetRelatedFollowRecordsWithOptions(FindTargetRelatedFollowRecordsRequest request, FindTargetRelatedFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowTargetDataId))
            {
                body["followTargetDataId"] = request.FollowTargetDataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowTargetType))
            {
                body["followTargetType"] = request.FollowTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
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
                Action = "FindTargetRelatedFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/targetFollowRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindTargetRelatedFollowRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取关联对象的跟进记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindTargetRelatedFollowRecordsRequest
        /// </param>
        /// <param name="headers">
        /// FindTargetRelatedFollowRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindTargetRelatedFollowRecordsResponse
        /// </returns>
        public async Task<FindTargetRelatedFollowRecordsResponse> FindTargetRelatedFollowRecordsWithOptionsAsync(FindTargetRelatedFollowRecordsRequest request, FindTargetRelatedFollowRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowTargetDataId))
            {
                body["followTargetDataId"] = request.FollowTargetDataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowTargetType))
            {
                body["followTargetType"] = request.FollowTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
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
                Action = "FindTargetRelatedFollowRecords",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/targetFollowRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindTargetRelatedFollowRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取关联对象的跟进记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindTargetRelatedFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// FindTargetRelatedFollowRecordsResponse
        /// </returns>
        public FindTargetRelatedFollowRecordsResponse FindTargetRelatedFollowRecords(FindTargetRelatedFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FindTargetRelatedFollowRecordsHeaders headers = new FindTargetRelatedFollowRecordsHeaders();
            return FindTargetRelatedFollowRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取关联对象的跟进记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindTargetRelatedFollowRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// FindTargetRelatedFollowRecordsResponse
        /// </returns>
        public async Task<FindTargetRelatedFollowRecordsResponse> FindTargetRelatedFollowRecordsAsync(FindTargetRelatedFollowRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FindTargetRelatedFollowRecordsHeaders headers = new FindTargetRelatedFollowRecordsHeaders();
            return await FindTargetRelatedFollowRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取所有客户的掉保时间数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllCustomerRecyclesRequest
        /// </param>
        /// <param name="headers">
        /// GetAllCustomerRecyclesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllCustomerRecyclesResponse
        /// </returns>
        public GetAllCustomerRecyclesResponse GetAllCustomerRecyclesWithOptions(GetAllCustomerRecyclesRequest request, GetAllCustomerRecyclesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAllCustomerRecycles",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerRecycles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllCustomerRecyclesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取所有客户的掉保时间数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllCustomerRecyclesRequest
        /// </param>
        /// <param name="headers">
        /// GetAllCustomerRecyclesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllCustomerRecyclesResponse
        /// </returns>
        public async Task<GetAllCustomerRecyclesResponse> GetAllCustomerRecyclesWithOptionsAsync(GetAllCustomerRecyclesRequest request, GetAllCustomerRecyclesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAllCustomerRecycles",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerRecycles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllCustomerRecyclesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取所有客户的掉保时间数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllCustomerRecyclesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllCustomerRecyclesResponse
        /// </returns>
        public GetAllCustomerRecyclesResponse GetAllCustomerRecycles(GetAllCustomerRecyclesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllCustomerRecyclesHeaders headers = new GetAllCustomerRecyclesHeaders();
            return GetAllCustomerRecyclesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取所有客户的掉保时间数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllCustomerRecyclesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllCustomerRecyclesResponse
        /// </returns>
        public async Task<GetAllCustomerRecyclesResponse> GetAllCustomerRecyclesAsync(GetAllCustomerRecyclesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllCustomerRecyclesHeaders headers = new GetAllCustomerRecyclesHeaders();
            return await GetAllCustomerRecyclesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactsRequest
        /// </param>
        /// <param name="headers">
        /// GetContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactsResponse
        /// </returns>
        public GetContactsResponse GetContactsWithOptions(GetContactsRequest request, GetContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                body["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderCorpId))
            {
                body["providerCorpId"] = request.ProviderCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                body["queryDsl"] = request.QueryDsl;
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
                Action = "GetContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customObjects/contacts/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactsRequest
        /// </param>
        /// <param name="headers">
        /// GetContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactsResponse
        /// </returns>
        public async Task<GetContactsResponse> GetContactsWithOptionsAsync(GetContactsRequest request, GetContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                body["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderCorpId))
            {
                body["providerCorpId"] = request.ProviderCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                body["queryDsl"] = request.QueryDsl;
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
                Action = "GetContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customObjects/contacts/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContactsResponse
        /// </returns>
        public GetContactsResponse GetContacts(GetContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContactsHeaders headers = new GetContactsHeaders();
            return GetContactsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContactsResponse
        /// </returns>
        public async Task<GetContactsResponse> GetContactsAsync(GetContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContactsHeaders headers = new GetContactsHeaders();
            return await GetContactsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCrmGroupChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatResponse
        /// </returns>
        public GetCrmGroupChatResponse GetCrmGroupChatWithOptions(string openConversationId, GetCrmGroupChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCrmGroupChat",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats/" + openConversationId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmGroupChatResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCrmGroupChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatResponse
        /// </returns>
        public async Task<GetCrmGroupChatResponse> GetCrmGroupChatWithOptionsAsync(string openConversationId, GetCrmGroupChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCrmGroupChat",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats/" + openConversationId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmGroupChatResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCrmGroupChatResponse
        /// </returns>
        public GetCrmGroupChatResponse GetCrmGroupChat(string openConversationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmGroupChatHeaders headers = new GetCrmGroupChatHeaders();
            return GetCrmGroupChatWithOptions(openConversationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCrmGroupChatResponse
        /// </returns>
        public async Task<GetCrmGroupChatResponse> GetCrmGroupChatAsync(string openConversationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmGroupChatHeaders headers = new GetCrmGroupChatHeaders();
            return await GetCrmGroupChatWithOptionsAsync(openConversationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取多个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatMultiRequest
        /// </param>
        /// <param name="headers">
        /// GetCrmGroupChatMultiHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatMultiResponse
        /// </returns>
        public GetCrmGroupChatMultiResponse GetCrmGroupChatMultiWithOptions(GetCrmGroupChatMultiRequest request, GetCrmGroupChatMultiHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
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
                Action = "GetCrmGroupChatMulti",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmGroupChatMultiResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取多个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatMultiRequest
        /// </param>
        /// <param name="headers">
        /// GetCrmGroupChatMultiHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatMultiResponse
        /// </returns>
        public async Task<GetCrmGroupChatMultiResponse> GetCrmGroupChatMultiWithOptionsAsync(GetCrmGroupChatMultiRequest request, GetCrmGroupChatMultiHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
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
                Action = "GetCrmGroupChatMulti",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmGroupChatMultiResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取多个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatMultiRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatMultiResponse
        /// </returns>
        public GetCrmGroupChatMultiResponse GetCrmGroupChatMulti(GetCrmGroupChatMultiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmGroupChatMultiHeaders headers = new GetCrmGroupChatMultiHeaders();
            return GetCrmGroupChatMultiWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取多个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatMultiRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatMultiResponse
        /// </returns>
        public async Task<GetCrmGroupChatMultiResponse> GetCrmGroupChatMultiAsync(GetCrmGroupChatMultiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmGroupChatMultiHeaders headers = new GetCrmGroupChatMultiHeaders();
            return await GetCrmGroupChatMultiWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatSingleRequest
        /// </param>
        /// <param name="headers">
        /// GetCrmGroupChatSingleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatSingleResponse
        /// </returns>
        public GetCrmGroupChatSingleResponse GetCrmGroupChatSingleWithOptions(GetCrmGroupChatSingleRequest request, GetCrmGroupChatSingleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
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
                Action = "GetCrmGroupChatSingle",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmGroupChatSingleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatSingleRequest
        /// </param>
        /// <param name="headers">
        /// GetCrmGroupChatSingleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatSingleResponse
        /// </returns>
        public async Task<GetCrmGroupChatSingleResponse> GetCrmGroupChatSingleWithOptionsAsync(GetCrmGroupChatSingleRequest request, GetCrmGroupChatSingleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
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
                Action = "GetCrmGroupChatSingle",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmGroupChatSingleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatSingleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatSingleResponse
        /// </returns>
        public GetCrmGroupChatSingleResponse GetCrmGroupChatSingle(GetCrmGroupChatSingleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmGroupChatSingleHeaders headers = new GetCrmGroupChatSingleHeaders();
            return GetCrmGroupChatSingleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmGroupChatSingleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCrmGroupChatSingleResponse
        /// </returns>
        public async Task<GetCrmGroupChatSingleResponse> GetCrmGroupChatSingleAsync(GetCrmGroupChatSingleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmGroupChatSingleHeaders headers = new GetCrmGroupChatSingleHeaders();
            return await GetCrmGroupChatSingleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM表单权限配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmRolePermissionRequest
        /// </param>
        /// <param name="headers">
        /// GetCrmRolePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmRolePermissionResponse
        /// </returns>
        public GetCrmRolePermissionResponse GetCrmRolePermissionWithOptions(GetCrmRolePermissionRequest request, GetCrmRolePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
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
                Action = "GetCrmRolePermission",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmRolePermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM表单权限配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmRolePermissionRequest
        /// </param>
        /// <param name="headers">
        /// GetCrmRolePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCrmRolePermissionResponse
        /// </returns>
        public async Task<GetCrmRolePermissionResponse> GetCrmRolePermissionWithOptionsAsync(GetCrmRolePermissionRequest request, GetCrmRolePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
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
                Action = "GetCrmRolePermission",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrmRolePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM表单权限配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmRolePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCrmRolePermissionResponse
        /// </returns>
        public GetCrmRolePermissionResponse GetCrmRolePermission(GetCrmRolePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmRolePermissionHeaders headers = new GetCrmRolePermissionHeaders();
            return GetCrmRolePermissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取CRM表单权限配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCrmRolePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCrmRolePermissionResponse
        /// </returns>
        public async Task<GetCrmRolePermissionResponse> GetCrmRolePermissionAsync(GetCrmRolePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCrmRolePermissionHeaders headers = new GetCrmRolePermissionHeaders();
            return await GetCrmRolePermissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取某个客户的客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerTracksByRelationIdRequest
        /// </param>
        /// <param name="headers">
        /// GetCustomerTracksByRelationIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerTracksByRelationIdResponse
        /// </returns>
        public GetCustomerTracksByRelationIdResponse GetCustomerTracksByRelationIdWithOptions(GetCustomerTracksByRelationIdRequest request, GetCustomerTracksByRelationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["relationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeGroup))
            {
                query["typeGroup"] = request.TypeGroup;
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
                Action = "GetCustomerTracksByRelationId",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerTracks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerTracksByRelationIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取某个客户的客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerTracksByRelationIdRequest
        /// </param>
        /// <param name="headers">
        /// GetCustomerTracksByRelationIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerTracksByRelationIdResponse
        /// </returns>
        public async Task<GetCustomerTracksByRelationIdResponse> GetCustomerTracksByRelationIdWithOptionsAsync(GetCustomerTracksByRelationIdRequest request, GetCustomerTracksByRelationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["relationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeGroup))
            {
                query["typeGroup"] = request.TypeGroup;
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
                Action = "GetCustomerTracksByRelationId",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerTracks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerTracksByRelationIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取某个客户的客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerTracksByRelationIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerTracksByRelationIdResponse
        /// </returns>
        public GetCustomerTracksByRelationIdResponse GetCustomerTracksByRelationId(GetCustomerTracksByRelationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomerTracksByRelationIdHeaders headers = new GetCustomerTracksByRelationIdHeaders();
            return GetCustomerTracksByRelationIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取某个客户的客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerTracksByRelationIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerTracksByRelationIdResponse
        /// </returns>
        public async Task<GetCustomerTracksByRelationIdResponse> GetCustomerTracksByRelationIdAsync(GetCustomerTracksByRelationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomerTracksByRelationIdHeaders headers = new GetCustomerTracksByRelationIdHeaders();
            return await GetCustomerTracksByRelationIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupSetResponse
        /// </returns>
        public GetGroupSetResponse GetGroupSetWithOptions(GetGroupSetRequest request, GetGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                query["openGroupSetId"] = request.OpenGroupSetId;
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
                Action = "GetGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupSetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupSetResponse
        /// </returns>
        public async Task<GetGroupSetResponse> GetGroupSetWithOptionsAsync(GetGroupSetRequest request, GetGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                query["openGroupSetId"] = request.OpenGroupSetId;
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
                Action = "GetGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupSetResponse
        /// </returns>
        public GetGroupSetResponse GetGroupSet(GetGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupSetHeaders headers = new GetGroupSetHeaders();
            return GetGroupSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupSetResponse
        /// </returns>
        public async Task<GetGroupSetResponse> GetGroupSetAsync(GetGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupSetHeaders headers = new GetGroupSetHeaders();
            return await GetGroupSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppPurchaseGoodsRequest
        /// </param>
        /// <param name="headers">
        /// GetInAppPurchaseGoodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInAppPurchaseGoodsResponse
        /// </returns>
        public GetInAppPurchaseGoodsResponse GetInAppPurchaseGoodsWithOptions(GetInAppPurchaseGoodsRequest request, GetInAppPurchaseGoodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetInAppPurchaseGoods",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/inAppPurchaseGoods/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInAppPurchaseGoodsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppPurchaseGoodsRequest
        /// </param>
        /// <param name="headers">
        /// GetInAppPurchaseGoodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInAppPurchaseGoodsResponse
        /// </returns>
        public async Task<GetInAppPurchaseGoodsResponse> GetInAppPurchaseGoodsWithOptionsAsync(GetInAppPurchaseGoodsRequest request, GetInAppPurchaseGoodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetInAppPurchaseGoods",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/inAppPurchaseGoods/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInAppPurchaseGoodsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppPurchaseGoodsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInAppPurchaseGoodsResponse
        /// </returns>
        public GetInAppPurchaseGoodsResponse GetInAppPurchaseGoods(GetInAppPurchaseGoodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInAppPurchaseGoodsHeaders headers = new GetInAppPurchaseGoodsHeaders();
            return GetInAppPurchaseGoodsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppPurchaseGoodsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInAppPurchaseGoodsResponse
        /// </returns>
        public async Task<GetInAppPurchaseGoodsResponse> GetInAppPurchaseGoodsAsync(GetInAppPurchaseGoodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInAppPurchaseGoodsHeaders headers = new GetInAppPurchaseGoodsHeaders();
            return await GetInAppPurchaseGoodsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义导航挂靠节点结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNavigationCatalogRequest
        /// </param>
        /// <param name="headers">
        /// GetNavigationCatalogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNavigationCatalogResponse
        /// </returns>
        public GetNavigationCatalogResponse GetNavigationCatalogWithOptions(GetNavigationCatalogRequest request, GetNavigationCatalogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceId))
            {
                query["bizTraceId"] = request.BizTraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                query["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
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
                Action = "GetNavigationCatalog",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/navigations/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNavigationCatalogResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义导航挂靠节点结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNavigationCatalogRequest
        /// </param>
        /// <param name="headers">
        /// GetNavigationCatalogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNavigationCatalogResponse
        /// </returns>
        public async Task<GetNavigationCatalogResponse> GetNavigationCatalogWithOptionsAsync(GetNavigationCatalogRequest request, GetNavigationCatalogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceId))
            {
                query["bizTraceId"] = request.BizTraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                query["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
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
                Action = "GetNavigationCatalog",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/navigations/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNavigationCatalogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义导航挂靠节点结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNavigationCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNavigationCatalogResponse
        /// </returns>
        public GetNavigationCatalogResponse GetNavigationCatalog(GetNavigationCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNavigationCatalogHeaders headers = new GetNavigationCatalogHeaders();
            return GetNavigationCatalogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义导航挂靠节点结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNavigationCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNavigationCatalogResponse
        /// </returns>
        public async Task<GetNavigationCatalogResponse> GetNavigationCatalogAsync(GetNavigationCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNavigationCatalogHeaders headers = new GetNavigationCatalogHeaders();
            return await GetNavigationCatalogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectDataRequest
        /// </param>
        /// <param name="headers">
        /// GetObjectDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetObjectDataResponse
        /// </returns>
        public GetObjectDataResponse GetObjectDataWithOptions(GetObjectDataRequest request, GetObjectDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                body["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                body["queryDsl"] = request.QueryDsl;
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
                Action = "GetObjectData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customObjects/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetObjectDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectDataRequest
        /// </param>
        /// <param name="headers">
        /// GetObjectDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetObjectDataResponse
        /// </returns>
        public async Task<GetObjectDataResponse> GetObjectDataWithOptionsAsync(GetObjectDataRequest request, GetObjectDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                body["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                body["queryDsl"] = request.QueryDsl;
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
                Action = "GetObjectData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customObjects/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetObjectDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetObjectDataResponse
        /// </returns>
        public GetObjectDataResponse GetObjectData(GetObjectDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectDataHeaders headers = new GetObjectDataHeaders();
            return GetObjectDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定条件查询自定义对象数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetObjectDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetObjectDataResponse
        /// </returns>
        public async Task<GetObjectDataResponse> GetObjectDataAsync(GetObjectDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectDataHeaders headers = new GetObjectDataHeaders();
            return await GetObjectDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetOfficialAccountContactInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountContactInfoResponse
        /// </returns>
        public GetOfficialAccountContactInfoResponse GetOfficialAccountContactInfoWithOptions(string userId, GetOfficialAccountContactInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficialAccountContactInfo",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/contacts/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountContactInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetOfficialAccountContactInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountContactInfoResponse
        /// </returns>
        public async Task<GetOfficialAccountContactInfoResponse> GetOfficialAccountContactInfoWithOptionsAsync(string userId, GetOfficialAccountContactInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficialAccountContactInfo",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/contacts/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountContactInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOfficialAccountContactInfoResponse
        /// </returns>
        public GetOfficialAccountContactInfoResponse GetOfficialAccountContactInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactInfoHeaders headers = new GetOfficialAccountContactInfoHeaders();
            return GetOfficialAccountContactInfoWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOfficialAccountContactInfoResponse
        /// </returns>
        public async Task<GetOfficialAccountContactInfoResponse> GetOfficialAccountContactInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactInfoHeaders headers = new GetOfficialAccountContactInfoHeaders();
            return await GetOfficialAccountContactInfoWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取服务窗联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountContactsRequest
        /// </param>
        /// <param name="headers">
        /// GetOfficialAccountContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountContactsResponse
        /// </returns>
        public GetOfficialAccountContactsResponse GetOfficialAccountContactsWithOptions(GetOfficialAccountContactsRequest request, GetOfficialAccountContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOfficialAccountContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/contacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountContactsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取服务窗联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountContactsRequest
        /// </param>
        /// <param name="headers">
        /// GetOfficialAccountContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountContactsResponse
        /// </returns>
        public async Task<GetOfficialAccountContactsResponse> GetOfficialAccountContactsWithOptionsAsync(GetOfficialAccountContactsRequest request, GetOfficialAccountContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOfficialAccountContacts",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/contacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountContactsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取服务窗联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountContactsResponse
        /// </returns>
        public GetOfficialAccountContactsResponse GetOfficialAccountContacts(GetOfficialAccountContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactsHeaders headers = new GetOfficialAccountContactsHeaders();
            return GetOfficialAccountContactsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取服务窗联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountContactsResponse
        /// </returns>
        public async Task<GetOfficialAccountContactsResponse> GetOfficialAccountContactsAsync(GetOfficialAccountContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactsHeaders headers = new GetOfficialAccountContactsHeaders();
            return await GetOfficialAccountContactsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗消息发送的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountOTOMessageResultRequest
        /// </param>
        /// <param name="headers">
        /// GetOfficialAccountOTOMessageResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountOTOMessageResultResponse
        /// </returns>
        public GetOfficialAccountOTOMessageResultResponse GetOfficialAccountOTOMessageResultWithOptions(GetOfficialAccountOTOMessageResultRequest request, GetOfficialAccountOTOMessageResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPushId))
            {
                query["openPushId"] = request.OpenPushId;
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
                Action = "GetOfficialAccountOTOMessageResult",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/sendResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountOTOMessageResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗消息发送的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountOTOMessageResultRequest
        /// </param>
        /// <param name="headers">
        /// GetOfficialAccountOTOMessageResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountOTOMessageResultResponse
        /// </returns>
        public async Task<GetOfficialAccountOTOMessageResultResponse> GetOfficialAccountOTOMessageResultWithOptionsAsync(GetOfficialAccountOTOMessageResultRequest request, GetOfficialAccountOTOMessageResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPushId))
            {
                query["openPushId"] = request.OpenPushId;
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
                Action = "GetOfficialAccountOTOMessageResult",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/sendResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountOTOMessageResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗消息发送的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountOTOMessageResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountOTOMessageResultResponse
        /// </returns>
        public GetOfficialAccountOTOMessageResultResponse GetOfficialAccountOTOMessageResult(GetOfficialAccountOTOMessageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountOTOMessageResultHeaders headers = new GetOfficialAccountOTOMessageResultHeaders();
            return GetOfficialAccountOTOMessageResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗消息发送的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountOTOMessageResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountOTOMessageResultResponse
        /// </returns>
        public async Task<GetOfficialAccountOTOMessageResultResponse> GetOfficialAccountOTOMessageResultAsync(GetOfficialAccountOTOMessageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountOTOMessageResultHeaders headers = new GetOfficialAccountOTOMessageResultHeaders();
            return await GetOfficialAccountOTOMessageResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个和oa关联的表单的具体数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabDataRequest
        /// </param>
        /// <param name="headers">
        /// GetRelatedViewTabDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabDataResponse
        /// </returns>
        public GetRelatedViewTabDataResponse GetRelatedViewTabDataWithOptions(GetRelatedViewTabDataRequest request, GetRelatedViewTabDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedField))
            {
                body["relatedField"] = request.RelatedField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedInstId))
            {
                body["relatedInstId"] = request.RelatedInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewUserId))
            {
                body["viewUserId"] = request.ViewUserId;
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
                Action = "GetRelatedViewTabData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/formRelatedTabs/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelatedViewTabDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个和oa关联的表单的具体数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabDataRequest
        /// </param>
        /// <param name="headers">
        /// GetRelatedViewTabDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabDataResponse
        /// </returns>
        public async Task<GetRelatedViewTabDataResponse> GetRelatedViewTabDataWithOptionsAsync(GetRelatedViewTabDataRequest request, GetRelatedViewTabDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedField))
            {
                body["relatedField"] = request.RelatedField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedInstId))
            {
                body["relatedInstId"] = request.RelatedInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewUserId))
            {
                body["viewUserId"] = request.ViewUserId;
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
                Action = "GetRelatedViewTabData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/formRelatedTabs/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelatedViewTabDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个和oa关联的表单的具体数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabDataResponse
        /// </returns>
        public GetRelatedViewTabDataResponse GetRelatedViewTabData(GetRelatedViewTabDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedViewTabDataHeaders headers = new GetRelatedViewTabDataHeaders();
            return GetRelatedViewTabDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个和oa关联的表单的具体数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabDataResponse
        /// </returns>
        public async Task<GetRelatedViewTabDataResponse> GetRelatedViewTabDataAsync(GetRelatedViewTabDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedViewTabDataHeaders headers = new GetRelatedViewTabDataHeaders();
            return await GetRelatedViewTabDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取和oa关联的表单tab信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabMetaRequest
        /// </param>
        /// <param name="headers">
        /// GetRelatedViewTabMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabMetaResponse
        /// </returns>
        public GetRelatedViewTabMetaResponse GetRelatedViewTabMetaWithOptions(GetRelatedViewTabMetaRequest request, GetRelatedViewTabMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewUserId))
            {
                body["viewUserId"] = request.ViewUserId;
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
                Action = "GetRelatedViewTabMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/formRelatedTabs/meta/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelatedViewTabMetaResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取和oa关联的表单tab信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabMetaRequest
        /// </param>
        /// <param name="headers">
        /// GetRelatedViewTabMetaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabMetaResponse
        /// </returns>
        public async Task<GetRelatedViewTabMetaResponse> GetRelatedViewTabMetaWithOptionsAsync(GetRelatedViewTabMetaRequest request, GetRelatedViewTabMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewUserId))
            {
                body["viewUserId"] = request.ViewUserId;
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
                Action = "GetRelatedViewTabMeta",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/formRelatedTabs/meta/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelatedViewTabMetaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取和oa关联的表单tab信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabMetaResponse
        /// </returns>
        public GetRelatedViewTabMetaResponse GetRelatedViewTabMeta(GetRelatedViewTabMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedViewTabMetaHeaders headers = new GetRelatedViewTabMetaHeaders();
            return GetRelatedViewTabMetaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取和oa关联的表单tab信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedViewTabMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedViewTabMetaResponse
        /// </returns>
        public async Task<GetRelatedViewTabMetaResponse> GetRelatedViewTabMetaAsync(GetRelatedViewTabMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedViewTabMetaHeaders headers = new GetRelatedViewTabMetaHeaders();
            return await GetRelatedViewTabMetaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetRelationUkSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public GetRelationUkSettingResponse GetRelationUkSettingWithOptions(GetRelationUkSettingRequest request, GetRelationUkSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "GetRelationUkSetting",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relationUkSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationUkSettingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetRelationUkSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public async Task<GetRelationUkSettingResponse> GetRelationUkSettingWithOptionsAsync(GetRelationUkSettingRequest request, GetRelationUkSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "GetRelationUkSetting",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relationUkSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationUkSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public GetRelationUkSettingResponse GetRelationUkSetting(GetRelationUkSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationUkSettingHeaders headers = new GetRelationUkSettingHeaders();
            return GetRelationUkSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public async Task<GetRelationUkSettingResponse> GetRelationUkSettingAsync(GetRelationUkSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationUkSettingHeaders headers = new GetRelationUkSettingHeaders();
            return await GetRelationUkSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>加入群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JoinGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// JoinGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JoinGroupSetResponse
        /// </returns>
        public JoinGroupSetResponse JoinGroupSetWithOptions(JoinGroupSetRequest request, JoinGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDataList))
            {
                body["bizDataList"] = request.BizDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "JoinGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets/join",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinGroupSetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>加入群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JoinGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// JoinGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JoinGroupSetResponse
        /// </returns>
        public async Task<JoinGroupSetResponse> JoinGroupSetWithOptionsAsync(JoinGroupSetRequest request, JoinGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDataList))
            {
                body["bizDataList"] = request.BizDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "JoinGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets/join",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>加入群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JoinGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// JoinGroupSetResponse
        /// </returns>
        public JoinGroupSetResponse JoinGroupSet(JoinGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            JoinGroupSetHeaders headers = new JoinGroupSetHeaders();
            return JoinGroupSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>加入群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JoinGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// JoinGroupSetResponse
        /// </returns>
        public async Task<JoinGroupSetResponse> JoinGroupSetAsync(JoinGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            JoinGroupSetHeaders headers = new JoinGroupSetHeaders();
            return await JoinGroupSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询可用权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableBenefitRequest
        /// </param>
        /// <param name="headers">
        /// ListAvailableBenefitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableBenefitResponse
        /// </returns>
        public ListAvailableBenefitResponse ListAvailableBenefitWithOptions(ListAvailableBenefitRequest request, ListAvailableBenefitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCodeList))
            {
                body["benefitCodeList"] = request.BenefitCodeList;
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
                Action = "ListAvailableBenefit",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefits/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableBenefitResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询可用权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableBenefitRequest
        /// </param>
        /// <param name="headers">
        /// ListAvailableBenefitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableBenefitResponse
        /// </returns>
        public async Task<ListAvailableBenefitResponse> ListAvailableBenefitWithOptionsAsync(ListAvailableBenefitRequest request, ListAvailableBenefitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCodeList))
            {
                body["benefitCodeList"] = request.BenefitCodeList;
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
                Action = "ListAvailableBenefit",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefits/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableBenefitResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询可用权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableBenefitRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableBenefitResponse
        /// </returns>
        public ListAvailableBenefitResponse ListAvailableBenefit(ListAvailableBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAvailableBenefitHeaders headers = new ListAvailableBenefitHeaders();
            return ListAvailableBenefitWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询可用权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableBenefitRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableBenefitResponse
        /// </returns>
        public async Task<ListAvailableBenefitResponse> ListAvailableBenefitAsync(ListAvailableBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAvailableBenefitHeaders headers = new ListAvailableBenefitHeaders();
            return await ListAvailableBenefitWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenefitLicenseRequest
        /// </param>
        /// <param name="headers">
        /// ListBenefitLicenseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBenefitLicenseResponse
        /// </returns>
        public ListBenefitLicenseResponse ListBenefitLicenseWithOptions(ListBenefitLicenseRequest request, ListBenefitLicenseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                body["domains"] = request.Domains;
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
                Action = "ListBenefitLicense",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitLicenses/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBenefitLicenseResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenefitLicenseRequest
        /// </param>
        /// <param name="headers">
        /// ListBenefitLicenseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBenefitLicenseResponse
        /// </returns>
        public async Task<ListBenefitLicenseResponse> ListBenefitLicenseWithOptionsAsync(ListBenefitLicenseRequest request, ListBenefitLicenseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                body["domains"] = request.Domains;
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
                Action = "ListBenefitLicense",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitLicenses/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBenefitLicenseResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenefitLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBenefitLicenseResponse
        /// </returns>
        public ListBenefitLicenseResponse ListBenefitLicense(ListBenefitLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListBenefitLicenseHeaders headers = new ListBenefitLicenseHeaders();
            return ListBenefitLicenseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenefitLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBenefitLicenseResponse
        /// </returns>
        public async Task<ListBenefitLicenseResponse> ListBenefitLicenseAsync(ListBenefitLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListBenefitLicenseHeaders headers = new ListBenefitLicenseHeaders();
            return await ListBenefitLicenseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取线索标签列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListClueTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClueTagResponse
        /// </returns>
        public ListClueTagResponse ListClueTagWithOptions(ListClueTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClueTag",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/clues/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClueTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取线索标签列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListClueTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClueTagResponse
        /// </returns>
        public async Task<ListClueTagResponse> ListClueTagWithOptionsAsync(ListClueTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClueTag",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/clues/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClueTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取线索标签列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListClueTagResponse
        /// </returns>
        public ListClueTagResponse ListClueTag()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListClueTagHeaders headers = new ListClueTagHeaders();
            return ListClueTagWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取线索标签列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListClueTagResponse
        /// </returns>
        public async Task<ListClueTagResponse> ListClueTagAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListClueTagHeaders headers = new ListClueTagHeaders();
            return await ListClueTagWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取crm个人客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrmPersonalCustomersRequest
        /// </param>
        /// <param name="headers">
        /// ListCrmPersonalCustomersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCrmPersonalCustomersResponse
        /// </returns>
        public ListCrmPersonalCustomersResponse ListCrmPersonalCustomersWithOptions(ListCrmPersonalCustomersRequest request, ListCrmPersonalCustomersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCrmPersonalCustomers",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrmPersonalCustomersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取crm个人客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrmPersonalCustomersRequest
        /// </param>
        /// <param name="headers">
        /// ListCrmPersonalCustomersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCrmPersonalCustomersResponse
        /// </returns>
        public async Task<ListCrmPersonalCustomersResponse> ListCrmPersonalCustomersWithOptionsAsync(ListCrmPersonalCustomersRequest request, ListCrmPersonalCustomersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCrmPersonalCustomers",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrmPersonalCustomersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取crm个人客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrmPersonalCustomersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCrmPersonalCustomersResponse
        /// </returns>
        public ListCrmPersonalCustomersResponse ListCrmPersonalCustomers(ListCrmPersonalCustomersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCrmPersonalCustomersHeaders headers = new ListCrmPersonalCustomersHeaders();
            return ListCrmPersonalCustomersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取crm个人客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrmPersonalCustomersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCrmPersonalCustomersResponse
        /// </returns>
        public async Task<ListCrmPersonalCustomersResponse> ListCrmPersonalCustomersAsync(ListCrmPersonalCustomersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCrmPersonalCustomersHeaders headers = new ListCrmPersonalCustomersHeaders();
            return await ListCrmPersonalCustomersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupSetResponse
        /// </returns>
        public ListGroupSetResponse ListGroupSetWithOptions(ListGroupSetRequest request, ListGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "ListGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupSetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupSetResponse
        /// </returns>
        public async Task<ListGroupSetResponse> ListGroupSetWithOptionsAsync(ListGroupSetRequest request, ListGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "ListGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupSetResponse
        /// </returns>
        public ListGroupSetResponse ListGroupSet(ListGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupSetHeaders headers = new ListGroupSetHeaders();
            return ListGroupSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupSetResponse
        /// </returns>
        public async Task<ListGroupSetResponse> ListGroupSetAsync(ListGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupSetHeaders headers = new ListGroupSetHeaders();
            return await ListGroupSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆盖更新客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OverrideUpdateCustomerDataAuthRequest
        /// </param>
        /// <param name="headers">
        /// OverrideUpdateCustomerDataAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OverrideUpdateCustomerDataAuthResponse
        /// </returns>
        public OverrideUpdateCustomerDataAuthResponse OverrideUpdateCustomerDataAuthWithOptions(OverrideUpdateCustomerDataAuthRequest request, OverrideUpdateCustomerDataAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerIds))
            {
                body["customerIds"] = request.CustomerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAuthUserIds))
            {
                body["dataAuthUserIds"] = request.DataAuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["roleType"] = request.RoleType;
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
                Action = "OverrideUpdateCustomerDataAuth",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/dataAuth/overrideUpdate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OverrideUpdateCustomerDataAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆盖更新客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OverrideUpdateCustomerDataAuthRequest
        /// </param>
        /// <param name="headers">
        /// OverrideUpdateCustomerDataAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OverrideUpdateCustomerDataAuthResponse
        /// </returns>
        public async Task<OverrideUpdateCustomerDataAuthResponse> OverrideUpdateCustomerDataAuthWithOptionsAsync(OverrideUpdateCustomerDataAuthRequest request, OverrideUpdateCustomerDataAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerIds))
            {
                body["customerIds"] = request.CustomerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAuthUserIds))
            {
                body["dataAuthUserIds"] = request.DataAuthUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["roleType"] = request.RoleType;
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
                Action = "OverrideUpdateCustomerDataAuth",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/dataAuth/overrideUpdate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OverrideUpdateCustomerDataAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆盖更新客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OverrideUpdateCustomerDataAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// OverrideUpdateCustomerDataAuthResponse
        /// </returns>
        public OverrideUpdateCustomerDataAuthResponse OverrideUpdateCustomerDataAuth(OverrideUpdateCustomerDataAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OverrideUpdateCustomerDataAuthHeaders headers = new OverrideUpdateCustomerDataAuthHeaders();
            return OverrideUpdateCustomerDataAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆盖更新客户数据权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OverrideUpdateCustomerDataAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// OverrideUpdateCustomerDataAuthResponse
        /// </returns>
        public async Task<OverrideUpdateCustomerDataAuthResponse> OverrideUpdateCustomerDataAuthAsync(OverrideUpdateCustomerDataAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OverrideUpdateCustomerDataAuthHeaders headers = new OverrideUpdateCustomerDataAuthHeaders();
            return await OverrideUpdateCustomerDataAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllCustomerRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllCustomerResponse
        /// </returns>
        public QueryAllCustomerResponse QueryAllCustomerWithOptions(QueryAllCustomerRequest request, QueryAllCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryAllCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllCustomerRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllCustomerResponse
        /// </returns>
        public async Task<QueryAllCustomerResponse> QueryAllCustomerWithOptionsAsync(QueryAllCustomerRequest request, QueryAllCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryAllCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customerInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllCustomerResponse
        /// </returns>
        public QueryAllCustomerResponse QueryAllCustomer(QueryAllCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllCustomerHeaders headers = new QueryAllCustomerHeaders();
            return QueryAllCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllCustomerResponse
        /// </returns>
        public async Task<QueryAllCustomerResponse> QueryAllCustomerAsync(QueryAllCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllCustomerHeaders headers = new QueryAllCustomerHeaders();
            return await QueryAllCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询企业客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTracksRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllTracksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTracksResponse
        /// </returns>
        public QueryAllTracksResponse QueryAllTracksWithOptions(QueryAllTracksRequest request, QueryAllTracksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
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
                Action = "QueryAllTracks",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/tracks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllTracksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询企业客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTracksRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllTracksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTracksResponse
        /// </returns>
        public async Task<QueryAllTracksResponse> QueryAllTracksWithOptionsAsync(QueryAllTracksRequest request, QueryAllTracksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
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
                Action = "QueryAllTracks",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/customers/tracks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllTracksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询企业客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTracksRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTracksResponse
        /// </returns>
        public QueryAllTracksResponse QueryAllTracks(QueryAllTracksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllTracksHeaders headers = new QueryAllTracksHeaders();
            return QueryAllTracksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询企业客户动态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTracksRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTracksResponse
        /// </returns>
        public async Task<QueryAllTracksResponse> QueryAllTracksAsync(QueryAllTracksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllTracksHeaders headers = new QueryAllTracksHeaders();
            return await QueryAllTracksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户管理应用管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppManagerRequest
        /// </param>
        /// <param name="headers">
        /// QueryAppManagerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAppManagerResponse
        /// </returns>
        public QueryAppManagerResponse QueryAppManagerWithOptions(QueryAppManagerRequest request, QueryAppManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryAppManager",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/apps/managers/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppManagerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户管理应用管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppManagerRequest
        /// </param>
        /// <param name="headers">
        /// QueryAppManagerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAppManagerResponse
        /// </returns>
        public async Task<QueryAppManagerResponse> QueryAppManagerWithOptionsAsync(QueryAppManagerRequest request, QueryAppManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryAppManager",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/apps/managers/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户管理应用管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppManagerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAppManagerResponse
        /// </returns>
        public QueryAppManagerResponse QueryAppManager(QueryAppManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAppManagerHeaders headers = new QueryAppManagerHeaders();
            return QueryAppManagerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户管理应用管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAppManagerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAppManagerResponse
        /// </returns>
        public async Task<QueryAppManagerResponse> QueryAppManagerAsync(QueryAppManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAppManagerHeaders headers = new QueryAppManagerHeaders();
            return await QueryAppManagerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitInventoryRequest
        /// </param>
        /// <param name="headers">
        /// QueryBenefitInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitInventoryResponse
        /// </returns>
        public QueryBenefitInventoryResponse QueryBenefitInventoryWithOptions(QueryBenefitInventoryRequest request, QueryBenefitInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
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
                Action = "QueryBenefitInventory",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitInventories/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBenefitInventoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitInventoryRequest
        /// </param>
        /// <param name="headers">
        /// QueryBenefitInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitInventoryResponse
        /// </returns>
        public async Task<QueryBenefitInventoryResponse> QueryBenefitInventoryWithOptionsAsync(QueryBenefitInventoryRequest request, QueryBenefitInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
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
                Action = "QueryBenefitInventory",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitInventories/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBenefitInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitInventoryResponse
        /// </returns>
        public QueryBenefitInventoryResponse QueryBenefitInventory(QueryBenefitInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBenefitInventoryHeaders headers = new QueryBenefitInventoryHeaders();
            return QueryBenefitInventoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询权益库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitInventoryResponse
        /// </returns>
        public async Task<QueryBenefitInventoryResponse> QueryBenefitInventoryAsync(QueryBenefitInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBenefitInventoryHeaders headers = new QueryBenefitInventoryHeaders();
            return await QueryBenefitInventoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询线索跟进状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryClueFollowStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryClueFollowStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryClueFollowStatusResponse
        /// </returns>
        public QueryClueFollowStatusResponse QueryClueFollowStatusWithOptions(QueryClueFollowStatusRequest request, QueryClueFollowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClueId))
            {
                query["clueId"] = request.ClueId;
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
                Action = "QueryClueFollowStatus",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/clues/followStatuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryClueFollowStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询线索跟进状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryClueFollowStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryClueFollowStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryClueFollowStatusResponse
        /// </returns>
        public async Task<QueryClueFollowStatusResponse> QueryClueFollowStatusWithOptionsAsync(QueryClueFollowStatusRequest request, QueryClueFollowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClueId))
            {
                query["clueId"] = request.ClueId;
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
                Action = "QueryClueFollowStatus",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/clues/followStatuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryClueFollowStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询线索跟进状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryClueFollowStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryClueFollowStatusResponse
        /// </returns>
        public QueryClueFollowStatusResponse QueryClueFollowStatus(QueryClueFollowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClueFollowStatusHeaders headers = new QueryClueFollowStatusHeaders();
            return QueryClueFollowStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询线索跟进状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryClueFollowStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryClueFollowStatusResponse
        /// </returns>
        public async Task<QueryClueFollowStatusResponse> QueryClueFollowStatusAsync(QueryClueFollowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryClueFollowStatusHeaders headers = new QueryClueFollowStatusHeaders();
            return await QueryClueFollowStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmGroupChatsRequest
        /// </param>
        /// <param name="headers">
        /// QueryCrmGroupChatsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmGroupChatsResponse
        /// </returns>
        public QueryCrmGroupChatsResponse QueryCrmGroupChatsWithOptions(QueryCrmGroupChatsRequest request, QueryCrmGroupChatsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "QueryCrmGroupChats",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCrmGroupChatsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmGroupChatsRequest
        /// </param>
        /// <param name="headers">
        /// QueryCrmGroupChatsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmGroupChatsResponse
        /// </returns>
        public async Task<QueryCrmGroupChatsResponse> QueryCrmGroupChatsWithOptionsAsync(QueryCrmGroupChatsRequest request, QueryCrmGroupChatsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "QueryCrmGroupChats",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/crmGroupChats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCrmGroupChatsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmGroupChatsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmGroupChatsResponse
        /// </returns>
        public QueryCrmGroupChatsResponse QueryCrmGroupChats(QueryCrmGroupChatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmGroupChatsHeaders headers = new QueryCrmGroupChatsHeaders();
            return QueryCrmGroupChatsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmGroupChatsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmGroupChatsResponse
        /// </returns>
        public async Task<QueryCrmGroupChatsResponse> QueryCrmGroupChatsAsync(QueryCrmGroupChatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmGroupChatsHeaders headers = new QueryCrmGroupChatsHeaders();
            return await QueryCrmGroupChatsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定查询条件批量获取客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// QueryCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmPersonalCustomerResponse
        /// </returns>
        public QueryCrmPersonalCustomerResponse QueryCrmPersonalCustomerWithOptions(QueryCrmPersonalCustomerRequest request, QueryCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "QueryCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCrmPersonalCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定查询条件批量获取客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// QueryCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmPersonalCustomerResponse
        /// </returns>
        public async Task<QueryCrmPersonalCustomerResponse> QueryCrmPersonalCustomerWithOptionsAsync(QueryCrmPersonalCustomerRequest request, QueryCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "QueryCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCrmPersonalCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定查询条件批量获取客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmPersonalCustomerResponse
        /// </returns>
        public QueryCrmPersonalCustomerResponse QueryCrmPersonalCustomer(QueryCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmPersonalCustomerHeaders headers = new QueryCrmPersonalCustomerHeaders();
            return QueryCrmPersonalCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据指定查询条件批量获取客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCrmPersonalCustomerResponse
        /// </returns>
        public async Task<QueryCrmPersonalCustomerResponse> QueryCrmPersonalCustomerAsync(QueryCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmPersonalCustomerHeaders headers = new QueryCrmPersonalCustomerHeaders();
            return await QueryCrmPersonalCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户模板启用类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// QueryCustomerBizTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerBizTypeResponse
        /// </returns>
        public QueryCustomerBizTypeResponse QueryCustomerBizTypeWithOptions(QueryCustomerBizTypeRequest request, QueryCustomerBizTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryCustomerBizType",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/orgSettings/templates/customerBizTypes/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerBizTypeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户模板启用类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// QueryCustomerBizTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerBizTypeResponse
        /// </returns>
        public async Task<QueryCustomerBizTypeResponse> QueryCustomerBizTypeWithOptionsAsync(QueryCustomerBizTypeRequest request, QueryCustomerBizTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryCustomerBizType",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/orgSettings/templates/customerBizTypes/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerBizTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户模板启用类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerBizTypeResponse
        /// </returns>
        public QueryCustomerBizTypeResponse QueryCustomerBizType(QueryCustomerBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerBizTypeHeaders headers = new QueryCustomerBizTypeHeaders();
            return QueryCustomerBizTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户模板启用类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerBizTypeResponse
        /// </returns>
        public async Task<QueryCustomerBizTypeResponse> QueryCustomerBizTypeAsync(QueryCustomerBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerBizTypeHeaders headers = new QueryCustomerBizTypeHeaders();
            return await QueryCustomerBizTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销服融合三方全局信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGlobalInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryGlobalInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGlobalInfoResponse
        /// </returns>
        public QueryGlobalInfoResponse QueryGlobalInfoWithOptions(QueryGlobalInfoRequest request, QueryGlobalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "QueryGlobalInfo",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/globalInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGlobalInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销服融合三方全局信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGlobalInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryGlobalInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGlobalInfoResponse
        /// </returns>
        public async Task<QueryGlobalInfoResponse> QueryGlobalInfoWithOptionsAsync(QueryGlobalInfoRequest request, QueryGlobalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "QueryGlobalInfo",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/globalInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGlobalInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销服融合三方全局信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGlobalInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGlobalInfoResponse
        /// </returns>
        public QueryGlobalInfoResponse QueryGlobalInfo(QueryGlobalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGlobalInfoHeaders headers = new QueryGlobalInfoHeaders();
            return QueryGlobalInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销服融合三方全局信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGlobalInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGlobalInfoResponse
        /// </returns>
        public async Task<QueryGlobalInfoResponse> QueryGlobalInfoAsync(QueryGlobalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGlobalInfoHeaders headers = new QueryGlobalInfoHeaders();
            return await QueryGlobalInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否有应用管理员权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHasAppPermissionRequest
        /// </param>
        /// <param name="headers">
        /// QueryHasAppPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHasAppPermissionResponse
        /// </returns>
        public QueryHasAppPermissionResponse QueryHasAppPermissionWithOptions(QueryHasAppPermissionRequest request, QueryHasAppPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryHasAppPermission",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/apps/adminPermissions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHasAppPermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否有应用管理员权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHasAppPermissionRequest
        /// </param>
        /// <param name="headers">
        /// QueryHasAppPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHasAppPermissionResponse
        /// </returns>
        public async Task<QueryHasAppPermissionResponse> QueryHasAppPermissionWithOptionsAsync(QueryHasAppPermissionRequest request, QueryHasAppPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "QueryHasAppPermission",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/apps/adminPermissions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHasAppPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否有应用管理员权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHasAppPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHasAppPermissionResponse
        /// </returns>
        public QueryHasAppPermissionResponse QueryHasAppPermission(QueryHasAppPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHasAppPermissionHeaders headers = new QueryHasAppPermissionHeaders();
            return QueryHasAppPermissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否有应用管理员权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHasAppPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHasAppPermissionResponse
        /// </returns>
        public async Task<QueryHasAppPermissionResponse> QueryHasAppPermissionAsync(QueryHasAppPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHasAppPermissionHeaders headers = new QueryHasAppPermissionHeaders();
            return await QueryHasAppPermissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务窗用户基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialAccountUserBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialAccountUserBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialAccountUserBasicInfoResponse
        /// </returns>
        public QueryOfficialAccountUserBasicInfoResponse QueryOfficialAccountUserBasicInfoWithOptions(QueryOfficialAccountUserBasicInfoRequest request, QueryOfficialAccountUserBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingToken))
            {
                query["bindingToken"] = request.BindingToken;
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
                Action = "QueryOfficialAccountUserBasicInfo",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/basics/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialAccountUserBasicInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务窗用户基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialAccountUserBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialAccountUserBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialAccountUserBasicInfoResponse
        /// </returns>
        public async Task<QueryOfficialAccountUserBasicInfoResponse> QueryOfficialAccountUserBasicInfoWithOptionsAsync(QueryOfficialAccountUserBasicInfoRequest request, QueryOfficialAccountUserBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingToken))
            {
                query["bindingToken"] = request.BindingToken;
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
                Action = "QueryOfficialAccountUserBasicInfo",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/basics/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialAccountUserBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务窗用户基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialAccountUserBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialAccountUserBasicInfoResponse
        /// </returns>
        public QueryOfficialAccountUserBasicInfoResponse QueryOfficialAccountUserBasicInfo(QueryOfficialAccountUserBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialAccountUserBasicInfoHeaders headers = new QueryOfficialAccountUserBasicInfoHeaders();
            return QueryOfficialAccountUserBasicInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务窗用户基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialAccountUserBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialAccountUserBasicInfoResponse
        /// </returns>
        public async Task<QueryOfficialAccountUserBasicInfoResponse> QueryOfficialAccountUserBasicInfoAsync(QueryOfficialAccountUserBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialAccountUserBasicInfoHeaders headers = new QueryOfficialAccountUserBasicInfoHeaders();
            return await QueryOfficialAccountUserBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据targetId查询关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationDatasByTargetIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryRelationDatasByTargetIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationDatasByTargetIdResponse
        /// </returns>
        public QueryRelationDatasByTargetIdResponse QueryRelationDatasByTargetIdWithOptions(string targetId, QueryRelationDatasByTargetIdRequest request, QueryRelationDatasByTargetIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "QueryRelationDatasByTargetId",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/datas/targets/" + targetId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRelationDatasByTargetIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据targetId查询关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationDatasByTargetIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryRelationDatasByTargetIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationDatasByTargetIdResponse
        /// </returns>
        public async Task<QueryRelationDatasByTargetIdResponse> QueryRelationDatasByTargetIdWithOptionsAsync(string targetId, QueryRelationDatasByTargetIdRequest request, QueryRelationDatasByTargetIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "QueryRelationDatasByTargetId",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/datas/targets/" + targetId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRelationDatasByTargetIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据targetId查询关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationDatasByTargetIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationDatasByTargetIdResponse
        /// </returns>
        public QueryRelationDatasByTargetIdResponse QueryRelationDatasByTargetId(string targetId, QueryRelationDatasByTargetIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRelationDatasByTargetIdHeaders headers = new QueryRelationDatasByTargetIdHeaders();
            return QueryRelationDatasByTargetIdWithOptions(targetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据targetId查询关系数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationDatasByTargetIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationDatasByTargetIdResponse
        /// </returns>
        public async Task<QueryRelationDatasByTargetIdResponse> QueryRelationDatasByTargetIdAsync(string targetId, QueryRelationDatasByTargetIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRelationDatasByTargetIdHeaders headers = new QueryRelationDatasByTargetIdHeaders();
            return await QueryRelationDatasByTargetIdWithOptionsAsync(targetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息撤回</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallOfficialAccountOTOMessageRequest
        /// </param>
        /// <param name="headers">
        /// RecallOfficialAccountOTOMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallOfficialAccountOTOMessageResponse
        /// </returns>
        public RecallOfficialAccountOTOMessageResponse RecallOfficialAccountOTOMessageWithOptions(RecallOfficialAccountOTOMessageRequest request, RecallOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPushId))
            {
                body["openPushId"] = request.OpenPushId;
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
                Action = "RecallOfficialAccountOTOMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallOfficialAccountOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息撤回</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallOfficialAccountOTOMessageRequest
        /// </param>
        /// <param name="headers">
        /// RecallOfficialAccountOTOMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallOfficialAccountOTOMessageResponse
        /// </returns>
        public async Task<RecallOfficialAccountOTOMessageResponse> RecallOfficialAccountOTOMessageWithOptionsAsync(RecallOfficialAccountOTOMessageRequest request, RecallOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPushId))
            {
                body["openPushId"] = request.OpenPushId;
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
                Action = "RecallOfficialAccountOTOMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallOfficialAccountOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息撤回</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallOfficialAccountOTOMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallOfficialAccountOTOMessageResponse
        /// </returns>
        public RecallOfficialAccountOTOMessageResponse RecallOfficialAccountOTOMessage(RecallOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallOfficialAccountOTOMessageHeaders headers = new RecallOfficialAccountOTOMessageHeaders();
            return RecallOfficialAccountOTOMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息撤回</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallOfficialAccountOTOMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallOfficialAccountOTOMessageResponse
        /// </returns>
        public async Task<RecallOfficialAccountOTOMessageResponse> RecallOfficialAccountOTOMessageAsync(RecallOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallOfficialAccountOTOMessageHeaders headers = new RecallOfficialAccountOTOMessageHeaders();
            return await RecallOfficialAccountOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBenefitLicenseRequest
        /// </param>
        /// <param name="headers">
        /// SaveBenefitLicenseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBenefitLicenseResponse
        /// </returns>
        public SaveBenefitLicenseResponse SaveBenefitLicenseWithOptions(SaveBenefitLicenseRequest request, SaveBenefitLicenseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Licenses))
            {
                body["licenses"] = request.Licenses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveUserId))
            {
                body["saveUserId"] = request.SaveUserId;
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
                Action = "SaveBenefitLicense",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitLicenses/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBenefitLicenseResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBenefitLicenseRequest
        /// </param>
        /// <param name="headers">
        /// SaveBenefitLicenseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBenefitLicenseResponse
        /// </returns>
        public async Task<SaveBenefitLicenseResponse> SaveBenefitLicenseWithOptionsAsync(SaveBenefitLicenseRequest request, SaveBenefitLicenseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Licenses))
            {
                body["licenses"] = request.Licenses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveUserId))
            {
                body["saveUserId"] = request.SaveUserId;
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
                Action = "SaveBenefitLicense",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitLicenses/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBenefitLicenseResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBenefitLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBenefitLicenseResponse
        /// </returns>
        public SaveBenefitLicenseResponse SaveBenefitLicense(SaveBenefitLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveBenefitLicenseHeaders headers = new SaveBenefitLicenseHeaders();
            return SaveBenefitLicenseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBenefitLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBenefitLicenseResponse
        /// </returns>
        public async Task<SaveBenefitLicenseResponse> SaveBenefitLicenseAsync(SaveBenefitLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveBenefitLicenseHeaders headers = new SaveBenefitLicenseHeaders();
            return await SaveBenefitLicenseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗单发接口，指定消息接收人发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountOTOMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendOfficialAccountOTOMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountOTOMessageResponse
        /// </returns>
        public SendOfficialAccountOTOMessageResponse SendOfficialAccountOTOMessageWithOptions(SendOfficialAccountOTOMessageRequest request, SendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendOfficialAccountOTOMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOfficialAccountOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗单发接口，指定消息接收人发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountOTOMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendOfficialAccountOTOMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountOTOMessageResponse
        /// </returns>
        public async Task<SendOfficialAccountOTOMessageResponse> SendOfficialAccountOTOMessageWithOptionsAsync(SendOfficialAccountOTOMessageRequest request, SendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendOfficialAccountOTOMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOfficialAccountOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗单发接口，指定消息接收人发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountOTOMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountOTOMessageResponse
        /// </returns>
        public SendOfficialAccountOTOMessageResponse SendOfficialAccountOTOMessage(SendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOfficialAccountOTOMessageHeaders headers = new SendOfficialAccountOTOMessageHeaders();
            return SendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗单发接口，指定消息接收人发送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountOTOMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountOTOMessageResponse
        /// </returns>
        public async Task<SendOfficialAccountOTOMessageResponse> SendOfficialAccountOTOMessageAsync(SendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOfficialAccountOTOMessageHeaders headers = new SendOfficialAccountOTOMessageHeaders();
            return await SendOfficialAccountOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个人应用发送服务窗消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountSNSMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendOfficialAccountSNSMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountSNSMessageResponse
        /// </returns>
        public SendOfficialAccountSNSMessageResponse SendOfficialAccountSNSMessageWithOptions(SendOfficialAccountSNSMessageRequest request, SendOfficialAccountSNSMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingToken))
            {
                body["bindingToken"] = request.BindingToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendOfficialAccountSNSMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/snsMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOfficialAccountSNSMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个人应用发送服务窗消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountSNSMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendOfficialAccountSNSMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountSNSMessageResponse
        /// </returns>
        public async Task<SendOfficialAccountSNSMessageResponse> SendOfficialAccountSNSMessageWithOptionsAsync(SendOfficialAccountSNSMessageRequest request, SendOfficialAccountSNSMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingToken))
            {
                body["bindingToken"] = request.BindingToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendOfficialAccountSNSMessage",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/officialAccounts/snsMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOfficialAccountSNSMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个人应用发送服务窗消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountSNSMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountSNSMessageResponse
        /// </returns>
        public SendOfficialAccountSNSMessageResponse SendOfficialAccountSNSMessage(SendOfficialAccountSNSMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOfficialAccountSNSMessageHeaders headers = new SendOfficialAccountSNSMessageHeaders();
            return SendOfficialAccountSNSMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个人应用发送服务窗消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOfficialAccountSNSMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOfficialAccountSNSMessageResponse
        /// </returns>
        public async Task<SendOfficialAccountSNSMessageResponse> SendOfficialAccountSNSMessageAsync(SendOfficialAccountSNSMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOfficialAccountSNSMessageHeaders headers = new SendOfficialAccountSNSMessageHeaders();
            return await SendOfficialAccountSNSMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ServiceWindowMessageBatchPushRequest
        /// </param>
        /// <param name="headers">
        /// ServiceWindowMessageBatchPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ServiceWindowMessageBatchPushResponse
        /// </returns>
        public ServiceWindowMessageBatchPushResponse ServiceWindowMessageBatchPushWithOptions(ServiceWindowMessageBatchPushRequest request, ServiceWindowMessageBatchPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "ServiceWindowMessageBatchPush",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/messages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ServiceWindowMessageBatchPushResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ServiceWindowMessageBatchPushRequest
        /// </param>
        /// <param name="headers">
        /// ServiceWindowMessageBatchPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ServiceWindowMessageBatchPushResponse
        /// </returns>
        public async Task<ServiceWindowMessageBatchPushResponse> ServiceWindowMessageBatchPushWithOptionsAsync(ServiceWindowMessageBatchPushRequest request, ServiceWindowMessageBatchPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "ServiceWindowMessageBatchPush",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/messages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ServiceWindowMessageBatchPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ServiceWindowMessageBatchPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ServiceWindowMessageBatchPushResponse
        /// </returns>
        public ServiceWindowMessageBatchPushResponse ServiceWindowMessageBatchPush(ServiceWindowMessageBatchPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ServiceWindowMessageBatchPushHeaders headers = new ServiceWindowMessageBatchPushHeaders();
            return ServiceWindowMessageBatchPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务窗消息群发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ServiceWindowMessageBatchPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ServiceWindowMessageBatchPushResponse
        /// </returns>
        public async Task<ServiceWindowMessageBatchPushResponse> ServiceWindowMessageBatchPushAsync(ServiceWindowMessageBatchPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ServiceWindowMessageBatchPushHeaders headers = new ServiceWindowMessageBatchPushHeaders();
            return await ServiceWindowMessageBatchPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户版本为免费版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserVersionToFreeRequest
        /// </param>
        /// <param name="headers">
        /// SetUserVersionToFreeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserVersionToFreeResponse
        /// </returns>
        public SetUserVersionToFreeResponse SetUserVersionToFreeWithOptions(SetUserVersionToFreeRequest request, SetUserVersionToFreeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
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
                Action = "SetUserVersionToFree",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/versions/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserVersionToFreeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户版本为免费版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserVersionToFreeRequest
        /// </param>
        /// <param name="headers">
        /// SetUserVersionToFreeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserVersionToFreeResponse
        /// </returns>
        public async Task<SetUserVersionToFreeResponse> SetUserVersionToFreeWithOptionsAsync(SetUserVersionToFreeRequest request, SetUserVersionToFreeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
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
                Action = "SetUserVersionToFree",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/versions/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserVersionToFreeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户版本为免费版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserVersionToFreeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserVersionToFreeResponse
        /// </returns>
        public SetUserVersionToFreeResponse SetUserVersionToFree(SetUserVersionToFreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetUserVersionToFreeHeaders headers = new SetUserVersionToFreeHeaders();
            return SetUserVersionToFreeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户版本为免费版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserVersionToFreeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserVersionToFreeResponse
        /// </returns>
        public async Task<SetUserVersionToFreeResponse> SetUserVersionToFreeAsync(SetUserVersionToFreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetUserVersionToFreeHeaders headers = new SetUserVersionToFreeHeaders();
            return await SetUserVersionToFreeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二阶段提交权益库存结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TwoPhaseCommitInventoryRequest
        /// </param>
        /// <param name="headers">
        /// TwoPhaseCommitInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TwoPhaseCommitInventoryResponse
        /// </returns>
        public TwoPhaseCommitInventoryResponse TwoPhaseCommitInventoryWithOptions(TwoPhaseCommitInventoryRequest request, TwoPhaseCommitInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteResult))
            {
                body["executeResult"] = request.ExecuteResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
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
                Action = "TwoPhaseCommitInventory",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitInventories/twoPhases/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TwoPhaseCommitInventoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二阶段提交权益库存结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TwoPhaseCommitInventoryRequest
        /// </param>
        /// <param name="headers">
        /// TwoPhaseCommitInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TwoPhaseCommitInventoryResponse
        /// </returns>
        public async Task<TwoPhaseCommitInventoryResponse> TwoPhaseCommitInventoryWithOptionsAsync(TwoPhaseCommitInventoryRequest request, TwoPhaseCommitInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteResult))
            {
                body["executeResult"] = request.ExecuteResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
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
                Action = "TwoPhaseCommitInventory",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/benefitInventories/twoPhases/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TwoPhaseCommitInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二阶段提交权益库存结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TwoPhaseCommitInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// TwoPhaseCommitInventoryResponse
        /// </returns>
        public TwoPhaseCommitInventoryResponse TwoPhaseCommitInventory(TwoPhaseCommitInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TwoPhaseCommitInventoryHeaders headers = new TwoPhaseCommitInventoryHeaders();
            return TwoPhaseCommitInventoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二阶段提交权益库存结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TwoPhaseCommitInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// TwoPhaseCommitInventoryResponse
        /// </returns>
        public async Task<TwoPhaseCommitInventoryResponse> TwoPhaseCommitInventoryAsync(TwoPhaseCommitInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TwoPhaseCommitInventoryHeaders headers = new TwoPhaseCommitInventoryHeaders();
            return await TwoPhaseCommitInventoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrmPersonalCustomerResponse
        /// </returns>
        public UpdateCrmPersonalCustomerResponse UpdateCrmPersonalCustomerWithOptions(UpdateCrmPersonalCustomerRequest request, UpdateCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierNick))
            {
                body["modifierNick"] = request.ModifierNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierUserId))
            {
                body["modifierUserId"] = request.ModifierUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "UpdateCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCrmPersonalCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrmPersonalCustomerRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCrmPersonalCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrmPersonalCustomerResponse
        /// </returns>
        public async Task<UpdateCrmPersonalCustomerResponse> UpdateCrmPersonalCustomerWithOptionsAsync(UpdateCrmPersonalCustomerRequest request, UpdateCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierNick))
            {
                body["modifierNick"] = request.ModifierNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierUserId))
            {
                body["modifierUserId"] = request.ModifierUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDuplicateCheck))
            {
                body["skipDuplicateCheck"] = request.SkipDuplicateCheck;
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
                Action = "UpdateCrmPersonalCustomer",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/personalCustomers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCrmPersonalCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrmPersonalCustomerResponse
        /// </returns>
        public UpdateCrmPersonalCustomerResponse UpdateCrmPersonalCustomer(UpdateCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCrmPersonalCustomerHeaders headers = new UpdateCrmPersonalCustomerHeaders();
            return UpdateCrmPersonalCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新crm个人客户（或企业客户）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrmPersonalCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrmPersonalCustomerResponse
        /// </returns>
        public async Task<UpdateCrmPersonalCustomerResponse> UpdateCrmPersonalCustomerAsync(UpdateCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCrmPersonalCustomerHeaders headers = new UpdateCrmPersonalCustomerHeaders();
            return await UpdateCrmPersonalCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新客户模板类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomerBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCustomerBizTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerBizTypeResponse
        /// </returns>
        public UpdateCustomerBizTypeResponse UpdateCustomerBizTypeWithOptions(UpdateCustomerBizTypeRequest request, UpdateCustomerBizTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerBizType))
            {
                body["customerBizType"] = request.CustomerBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "UpdateCustomerBizType",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/orgSettings/templates/customerBizTypes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomerBizTypeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新客户模板类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomerBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCustomerBizTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerBizTypeResponse
        /// </returns>
        public async Task<UpdateCustomerBizTypeResponse> UpdateCustomerBizTypeWithOptionsAsync(UpdateCustomerBizTypeRequest request, UpdateCustomerBizTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerBizType))
            {
                body["customerBizType"] = request.CustomerBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "UpdateCustomerBizType",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/orgSettings/templates/customerBizTypes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomerBizTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新客户模板类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomerBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerBizTypeResponse
        /// </returns>
        public UpdateCustomerBizTypeResponse UpdateCustomerBizType(UpdateCustomerBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomerBizTypeHeaders headers = new UpdateCustomerBizTypeHeaders();
            return UpdateCustomerBizTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新客户模板类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomerBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerBizTypeResponse
        /// </returns>
        public async Task<UpdateCustomerBizTypeResponse> UpdateCustomerBizTypeAsync(UpdateCustomerBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomerBizTypeHeaders headers = new UpdateCustomerBizTypeHeaders();
            return await UpdateCustomerBizTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSetResponse
        /// </returns>
        public UpdateGroupSetResponse UpdateGroupSetWithOptions(UpdateGroupSetRequest request, UpdateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserIds))
            {
                body["managerUserIds"] = request.ManagerUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberQuota))
            {
                body["memberQuota"] = request.MemberQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notice))
            {
                body["notice"] = request.Notice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeToped))
            {
                body["noticeToped"] = request.NoticeToped;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Welcome))
            {
                body["welcome"] = request.Welcome;
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
                Action = "UpdateGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets/set",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UpdateGroupSetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSetResponse
        /// </returns>
        public async Task<UpdateGroupSetResponse> UpdateGroupSetWithOptionsAsync(UpdateGroupSetRequest request, UpdateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserIds))
            {
                body["managerUserIds"] = request.ManagerUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberQuota))
            {
                body["memberQuota"] = request.MemberQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notice))
            {
                body["notice"] = request.Notice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeToped))
            {
                body["noticeToped"] = request.NoticeToped;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Welcome))
            {
                body["welcome"] = request.Welcome;
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
                Action = "UpdateGroupSet",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/groupSets/set",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UpdateGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSetResponse
        /// </returns>
        public UpdateGroupSetResponse UpdateGroupSet(UpdateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
            return UpdateGroupSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSetResponse
        /// </returns>
        public async Task<UpdateGroupSetResponse> UpdateGroupSetAsync(UpdateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
            return await UpdateGroupSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增量同步导航数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMenuDataRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMenuDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMenuDataResponse
        /// </returns>
        public UpdateMenuDataResponse UpdateMenuDataWithOptions(UpdateMenuDataRequest request, UpdateMenuDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attr))
            {
                body["attr"] = request.Attr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceId))
            {
                body["bizTraceId"] = request.BizTraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NavData))
            {
                body["navData"] = request.NavData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "UpdateMenuData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/navigations/menus/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMenuDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增量同步导航数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMenuDataRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMenuDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMenuDataResponse
        /// </returns>
        public async Task<UpdateMenuDataResponse> UpdateMenuDataWithOptionsAsync(UpdateMenuDataRequest request, UpdateMenuDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attr))
            {
                body["attr"] = request.Attr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTraceId))
            {
                body["bizTraceId"] = request.BizTraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NavData))
            {
                body["navData"] = request.NavData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
                Action = "UpdateMenuData",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/navigations/menus/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMenuDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增量同步导航数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMenuDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMenuDataResponse
        /// </returns>
        public UpdateMenuDataResponse UpdateMenuData(UpdateMenuDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMenuDataHeaders headers = new UpdateMenuDataHeaders();
            return UpdateMenuDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增量同步导航数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMenuDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMenuDataResponse
        /// </returns>
        public async Task<UpdateMenuDataResponse> UpdateMenuDataAsync(UpdateMenuDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMenuDataHeaders headers = new UpdateMenuDataHeaders();
            return await UpdateMenuDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMetaModelFieldRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMetaModelFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMetaModelFieldResponse
        /// </returns>
        public UpdateMetaModelFieldResponse UpdateMetaModelFieldWithOptions(UpdateMetaModelFieldRequest request, UpdateMetaModelFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "UpdateMetaModelField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/metas/models/fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMetaModelFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMetaModelFieldRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMetaModelFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMetaModelFieldResponse
        /// </returns>
        public async Task<UpdateMetaModelFieldResponse> UpdateMetaModelFieldWithOptionsAsync(UpdateMetaModelFieldRequest request, UpdateMetaModelFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "UpdateMetaModelField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/metas/models/fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMetaModelFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMetaModelFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMetaModelFieldResponse
        /// </returns>
        public UpdateMetaModelFieldResponse UpdateMetaModelField(UpdateMetaModelFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMetaModelFieldHeaders headers = new UpdateMetaModelFieldHeaders();
            return UpdateMetaModelFieldWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMetaModelFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMetaModelFieldResponse
        /// </returns>
        public async Task<UpdateMetaModelFieldResponse> UpdateMetaModelFieldAsync(UpdateMetaModelFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMetaModelFieldHeaders headers = new UpdateMetaModelFieldHeaders();
            return await UpdateMetaModelFieldWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRelationMetaFieldRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRelationMetaFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRelationMetaFieldResponse
        /// </returns>
        public UpdateRelationMetaFieldResponse UpdateRelationMetaFieldWithOptions(UpdateRelationMetaFieldRequest request, UpdateRelationMetaFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "UpdateRelationMetaField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRelationMetaFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRelationMetaFieldRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRelationMetaFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRelationMetaFieldResponse
        /// </returns>
        public async Task<UpdateRelationMetaFieldResponse> UpdateRelationMetaFieldWithOptionsAsync(UpdateRelationMetaFieldRequest request, UpdateRelationMetaFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldDTOList))
            {
                body["fieldDTOList"] = request.FieldDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                body["relationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["tenant"] = request.Tenant;
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
                Action = "UpdateRelationMetaField",
                Version = "crm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/crm/relations/metas/fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRelationMetaFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRelationMetaFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRelationMetaFieldResponse
        /// </returns>
        public UpdateRelationMetaFieldResponse UpdateRelationMetaField(UpdateRelationMetaFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRelationMetaFieldHeaders headers = new UpdateRelationMetaFieldHeaders();
            return UpdateRelationMetaFieldWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关系模型表结构更新字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRelationMetaFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRelationMetaFieldResponse
        /// </returns>
        public async Task<UpdateRelationMetaFieldResponse> UpdateRelationMetaFieldAsync(UpdateRelationMetaFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRelationMetaFieldHeaders headers = new UpdateRelationMetaFieldHeaders();
            return await UpdateRelationMetaFieldWithOptionsAsync(request, headers, runtime);
        }

    }
}
