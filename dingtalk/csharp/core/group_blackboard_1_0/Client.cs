// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkgroup_blackboard_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkgroup_blackboard_1_0
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
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardResponse
        /// </returns>
        public CreateGroupBlackboardResponse CreateGroupBlackboardWithOptions(CreateGroupBlackboardRequest request, CreateGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDing))
            {
                body["sendDing"] = request.SendDing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["uniqueId"] = request.UniqueId;
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
                Action = "CreateGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupBlackboardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardResponse
        /// </returns>
        public async Task<CreateGroupBlackboardResponse> CreateGroupBlackboardWithOptionsAsync(CreateGroupBlackboardRequest request, CreateGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDing))
            {
                body["sendDing"] = request.SendDing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["uniqueId"] = request.UniqueId;
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
                Action = "CreateGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardResponse
        /// </returns>
        public CreateGroupBlackboardResponse CreateGroupBlackboard(CreateGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupBlackboardHeaders headers = new CreateGroupBlackboardHeaders();
            return CreateGroupBlackboardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardResponse
        /// </returns>
        public async Task<CreateGroupBlackboardResponse> CreateGroupBlackboardAsync(CreateGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupBlackboardHeaders headers = new CreateGroupBlackboardHeaders();
            return await CreateGroupBlackboardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardNewRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupBlackboardNewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardNewResponse
        /// </returns>
        public CreateGroupBlackboardNewResponse CreateGroupBlackboardNewWithOptions(CreateGroupBlackboardNewRequest request, CreateGroupBlackboardNewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDing))
            {
                body["sendDing"] = request.SendDing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["uniqueId"] = request.UniqueId;
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
                Action = "CreateGroupBlackboardNew",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupBlackboardNewResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardNewRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupBlackboardNewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardNewResponse
        /// </returns>
        public async Task<CreateGroupBlackboardNewResponse> CreateGroupBlackboardNewWithOptionsAsync(CreateGroupBlackboardNewRequest request, CreateGroupBlackboardNewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDing))
            {
                body["sendDing"] = request.SendDing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["uniqueId"] = request.UniqueId;
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
                Action = "CreateGroupBlackboardNew",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupBlackboardNewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardNewRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardNewResponse
        /// </returns>
        public CreateGroupBlackboardNewResponse CreateGroupBlackboardNew(CreateGroupBlackboardNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupBlackboardNewHeaders headers = new CreateGroupBlackboardNewHeaders();
            return CreateGroupBlackboardNewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupBlackboardNewRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupBlackboardNewResponse
        /// </returns>
        public async Task<CreateGroupBlackboardNewResponse> CreateGroupBlackboardNewAsync(CreateGroupBlackboardNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupBlackboardNewHeaders headers = new CreateGroupBlackboardNewHeaders();
            return await CreateGroupBlackboardNewWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// DeleteGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardResponse
        /// </returns>
        public DeleteGroupBlackboardResponse DeleteGroupBlackboardWithOptions(DeleteGroupBlackboardRequest request, DeleteGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DeleteGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupBlackboardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// DeleteGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardResponse
        /// </returns>
        public async Task<DeleteGroupBlackboardResponse> DeleteGroupBlackboardWithOptionsAsync(DeleteGroupBlackboardRequest request, DeleteGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DeleteGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardResponse
        /// </returns>
        public DeleteGroupBlackboardResponse DeleteGroupBlackboard(DeleteGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupBlackboardHeaders headers = new DeleteGroupBlackboardHeaders();
            return DeleteGroupBlackboardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardResponse
        /// </returns>
        public async Task<DeleteGroupBlackboardResponse> DeleteGroupBlackboardAsync(DeleteGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupBlackboardHeaders headers = new DeleteGroupBlackboardHeaders();
            return await DeleteGroupBlackboardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardNewRequest
        /// </param>
        /// <param name="headers">
        /// DeleteGroupBlackboardNewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardNewResponse
        /// </returns>
        public DeleteGroupBlackboardNewResponse DeleteGroupBlackboardNewWithOptions(DeleteGroupBlackboardNewRequest request, DeleteGroupBlackboardNewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DeleteGroupBlackboardNew",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupBlackboardNewResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardNewRequest
        /// </param>
        /// <param name="headers">
        /// DeleteGroupBlackboardNewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardNewResponse
        /// </returns>
        public async Task<DeleteGroupBlackboardNewResponse> DeleteGroupBlackboardNewWithOptionsAsync(DeleteGroupBlackboardNewRequest request, DeleteGroupBlackboardNewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DeleteGroupBlackboardNew",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupBlackboardNewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardNewRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardNewResponse
        /// </returns>
        public DeleteGroupBlackboardNewResponse DeleteGroupBlackboardNew(DeleteGroupBlackboardNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupBlackboardNewHeaders headers = new DeleteGroupBlackboardNewHeaders();
            return DeleteGroupBlackboardNewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGroupBlackboardNewRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupBlackboardNewResponse
        /// </returns>
        public async Task<DeleteGroupBlackboardNewResponse> DeleteGroupBlackboardNewAsync(DeleteGroupBlackboardNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupBlackboardNewHeaders headers = new DeleteGroupBlackboardNewHeaders();
            return await DeleteGroupBlackboardNewWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// EditGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditGroupBlackboardResponse
        /// </returns>
        public EditGroupBlackboardResponse EditGroupBlackboardWithOptions(EditGroupBlackboardRequest request, EditGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
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
                Action = "EditGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditGroupBlackboardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// EditGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditGroupBlackboardResponse
        /// </returns>
        public async Task<EditGroupBlackboardResponse> EditGroupBlackboardWithOptionsAsync(EditGroupBlackboardRequest request, EditGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
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
                Action = "EditGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditGroupBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// EditGroupBlackboardResponse
        /// </returns>
        public EditGroupBlackboardResponse EditGroupBlackboard(EditGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditGroupBlackboardHeaders headers = new EditGroupBlackboardHeaders();
            return EditGroupBlackboardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑群公告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// EditGroupBlackboardResponse
        /// </returns>
        public async Task<EditGroupBlackboardResponse> EditGroupBlackboardAsync(EditGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditGroupBlackboardHeaders headers = new EditGroupBlackboardHeaders();
            return await EditGroupBlackboardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupBlackboardResponse
        /// </returns>
        public GetGroupBlackboardResponse GetGroupBlackboardWithOptions(GetGroupBlackboardRequest request, GetGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupBlackboardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupBlackboardResponse
        /// </returns>
        public async Task<GetGroupBlackboardResponse> GetGroupBlackboardWithOptionsAsync(GetGroupBlackboardRequest request, GetGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupBlackboardResponse
        /// </returns>
        public GetGroupBlackboardResponse GetGroupBlackboard(GetGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupBlackboardHeaders headers = new GetGroupBlackboardHeaders();
            return GetGroupBlackboardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupBlackboardResponse
        /// </returns>
        public async Task<GetGroupBlackboardResponse> GetGroupBlackboardAsync(GetGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupBlackboardHeaders headers = new GetGroupBlackboardHeaders();
            return await GetGroupBlackboardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupBlackboardResponse
        /// </returns>
        public ListGroupBlackboardResponse ListGroupBlackboardWithOptions(ListGroupBlackboardRequest request, ListGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageCursor))
            {
                body["nextPageCursor"] = request.NextPageCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ListGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupBlackboardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupBlackboardRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupBlackboardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupBlackboardResponse
        /// </returns>
        public async Task<ListGroupBlackboardResponse> ListGroupBlackboardWithOptionsAsync(ListGroupBlackboardRequest request, ListGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageCursor))
            {
                body["nextPageCursor"] = request.NextPageCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ListGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupBlackboardResponse
        /// </returns>
        public ListGroupBlackboardResponse ListGroupBlackboard(ListGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupBlackboardHeaders headers = new ListGroupBlackboardHeaders();
            return ListGroupBlackboardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群公告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupBlackboardRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupBlackboardResponse
        /// </returns>
        public async Task<ListGroupBlackboardResponse> ListGroupBlackboardAsync(ListGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupBlackboardHeaders headers = new ListGroupBlackboardHeaders();
            return await ListGroupBlackboardWithOptionsAsync(request, headers, runtime);
        }

    }
}
