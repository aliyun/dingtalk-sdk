// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkim_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkim_2_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopboxRequest
        /// </param>
        /// <param name="headers">
        /// CloseTopboxHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseTopboxResponse
        /// </returns>
        public CloseTopboxResponse CloseTopboxWithOptions(CloseTopboxRequest request, CloseTopboxHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnoinId))
            {
                body["unoinId"] = request.UnoinId;
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
                Action = "CloseTopbox",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/topBoxes/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTopboxResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopboxRequest
        /// </param>
        /// <param name="headers">
        /// CloseTopboxHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseTopboxResponse
        /// </returns>
        public async Task<CloseTopboxResponse> CloseTopboxWithOptionsAsync(CloseTopboxRequest request, CloseTopboxHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnoinId))
            {
                body["unoinId"] = request.UnoinId;
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
                Action = "CloseTopbox",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/topBoxes/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTopboxResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopboxRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseTopboxResponse
        /// </returns>
        public CloseTopboxResponse CloseTopbox(CloseTopboxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseTopboxHeaders headers = new CloseTopboxHeaders();
            return CloseTopboxWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopboxRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseTopboxResponse
        /// </returns>
        public async Task<CloseTopboxResponse> CloseTopboxAsync(CloseTopboxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseTopboxHeaders headers = new CloseTopboxHeaders();
            return await CloseTopboxWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateCoupleGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupResponse
        /// </returns>
        public CreateCoupleGroupResponse CreateCoupleGroupWithOptions(CreateCoupleGroupRequest request, CreateCoupleGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["users"] = request.Users;
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
                Action = "CreateCoupleGroup",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/interconnections/couples/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCoupleGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateCoupleGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupResponse
        /// </returns>
        public async Task<CreateCoupleGroupResponse> CreateCoupleGroupWithOptionsAsync(CreateCoupleGroupRequest request, CreateCoupleGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["users"] = request.Users;
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
                Action = "CreateCoupleGroup",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/interconnections/couples/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCoupleGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupResponse
        /// </returns>
        public CreateCoupleGroupResponse CreateCoupleGroup(CreateCoupleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCoupleGroupHeaders headers = new CreateCoupleGroupHeaders();
            return CreateCoupleGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupResponse
        /// </returns>
        public async Task<CreateCoupleGroupResponse> CreateCoupleGroupAsync(CreateCoupleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCoupleGroupHeaders headers = new CreateCoupleGroupHeaders();
            return await CreateCoupleGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建普通群</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["users"] = request.Users;
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
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/interconnections/groups",
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
        /// <para>创建普通群</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["users"] = request.Users;
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
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/interconnections/groups",
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
        /// <para>创建普通群</para>
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
        /// <para>创建普通群</para>
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
        /// <para>创建并开启互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTopboxRequest
        /// </param>
        /// <param name="headers">
        /// CreateTopboxHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTopboxResponse
        /// </returns>
        public CreateTopboxResponse CreateTopboxWithOptions(CreateTopboxRequest request, CreateTopboxHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardSettings))
            {
                body["cardSettings"] = request.CardSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                body["expiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                body["platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIdList))
            {
                body["receiverUnionIdList"] = request.ReceiverUnionIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdPrivateDataMap))
            {
                body["unionIdPrivateDataMap"] = request.UnionIdPrivateDataMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdPrivateDataMap))
            {
                body["userIdPrivateDataMap"] = request.UserIdPrivateDataMap;
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
                Action = "CreateTopbox",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/topBoxes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopboxResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并开启互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTopboxRequest
        /// </param>
        /// <param name="headers">
        /// CreateTopboxHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTopboxResponse
        /// </returns>
        public async Task<CreateTopboxResponse> CreateTopboxWithOptionsAsync(CreateTopboxRequest request, CreateTopboxHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardSettings))
            {
                body["cardSettings"] = request.CardSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                body["expiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                body["platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIdList))
            {
                body["receiverUnionIdList"] = request.ReceiverUnionIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdPrivateDataMap))
            {
                body["unionIdPrivateDataMap"] = request.UnionIdPrivateDataMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdPrivateDataMap))
            {
                body["userIdPrivateDataMap"] = request.UserIdPrivateDataMap;
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
                Action = "CreateTopbox",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/topBoxes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopboxResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并开启互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTopboxRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTopboxResponse
        /// </returns>
        public CreateTopboxResponse CreateTopbox(CreateTopboxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTopboxHeaders headers = new CreateTopboxHeaders();
            return CreateTopboxWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并开启互动卡片吊顶</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTopboxRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTopboxResponse
        /// </returns>
        public async Task<CreateTopboxResponse> CreateTopboxAsync(CreateTopboxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTopboxHeaders headers = new CreateTopboxHeaders();
            return await CreateTopboxWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群设备市场管理</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupManagerDeviceMarketResponse
        /// </returns>
        public GroupManagerDeviceMarketResponse GroupManagerDeviceMarketWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupManagerDeviceMarket",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/group/device/market/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupManagerDeviceMarketResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群设备市场管理</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupManagerDeviceMarketResponse
        /// </returns>
        public async Task<GroupManagerDeviceMarketResponse> GroupManagerDeviceMarketWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupManagerDeviceMarket",
                Version = "im_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/im/group/device/market/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupManagerDeviceMarketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群设备市场管理</para>
        /// </summary>
        /// 
        /// <returns>
        /// GroupManagerDeviceMarketResponse
        /// </returns>
        public GroupManagerDeviceMarketResponse GroupManagerDeviceMarket()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GroupManagerDeviceMarketWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群设备市场管理</para>
        /// </summary>
        /// 
        /// <returns>
        /// GroupManagerDeviceMarketResponse
        /// </returns>
        public async Task<GroupManagerDeviceMarketResponse> GroupManagerDeviceMarketAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GroupManagerDeviceMarketWithOptionsAsync(headers, runtime);
        }

    }
}
