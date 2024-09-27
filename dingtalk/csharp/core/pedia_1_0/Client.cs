// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkpedia_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0
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
        /// <para>企业百科增加当前企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsAddRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsAddHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsAddResponse
        /// </returns>
        public PediaWordsAddResponse PediaWordsAddWithOptions(PediaWordsAddRequest request, PediaWordsAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Action = "PediaWordsAdd",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsAddResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科增加当前企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsAddRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsAddHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsAddResponse
        /// </returns>
        public async Task<PediaWordsAddResponse> PediaWordsAddWithOptionsAsync(PediaWordsAddRequest request, PediaWordsAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Action = "PediaWordsAdd",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsAddResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科增加当前企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsAddRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsAddResponse
        /// </returns>
        public PediaWordsAddResponse PediaWordsAdd(PediaWordsAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
            return PediaWordsAddWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科增加当前企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsAddRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsAddResponse
        /// </returns>
        public async Task<PediaWordsAddResponse> PediaWordsAddAsync(PediaWordsAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
            return await PediaWordsAddWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对待审核词条进行审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsApproveRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsApproveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsApproveResponse
        /// </returns>
        public PediaWordsApproveResponse PediaWordsApproveWithOptions(PediaWordsApproveRequest request, PediaWordsApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveReason))
            {
                body["approveReason"] = request.ApproveReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStatus))
            {
                body["approveStatus"] = request.ApproveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImHighLight))
            {
                body["imHighLight"] = request.ImHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimHighLight))
            {
                body["simHighLight"] = request.SimHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "PediaWordsApprove",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words/approve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsApproveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对待审核词条进行审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsApproveRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsApproveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsApproveResponse
        /// </returns>
        public async Task<PediaWordsApproveResponse> PediaWordsApproveWithOptionsAsync(PediaWordsApproveRequest request, PediaWordsApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveReason))
            {
                body["approveReason"] = request.ApproveReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStatus))
            {
                body["approveStatus"] = request.ApproveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImHighLight))
            {
                body["imHighLight"] = request.ImHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimHighLight))
            {
                body["simHighLight"] = request.SimHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "PediaWordsApprove",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words/approve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsApproveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对待审核词条进行审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsApproveRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsApproveResponse
        /// </returns>
        public PediaWordsApproveResponse PediaWordsApprove(PediaWordsApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
            return PediaWordsApproveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对待审核词条进行审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsApproveRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsApproveResponse
        /// </returns>
        public async Task<PediaWordsApproveResponse> PediaWordsApproveAsync(PediaWordsApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
            return await PediaWordsApproveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对uuid删除当前词条</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsDeleteRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsDeleteHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsDeleteResponse
        /// </returns>
        public PediaWordsDeleteResponse PediaWordsDeleteWithOptions(PediaWordsDeleteRequest request, PediaWordsDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
                Action = "PediaWordsDelete",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsDeleteResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对uuid删除当前词条</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsDeleteRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsDeleteHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsDeleteResponse
        /// </returns>
        public async Task<PediaWordsDeleteResponse> PediaWordsDeleteWithOptionsAsync(PediaWordsDeleteRequest request, PediaWordsDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
                Action = "PediaWordsDelete",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsDeleteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对uuid删除当前词条</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsDeleteResponse
        /// </returns>
        public PediaWordsDeleteResponse PediaWordsDelete(PediaWordsDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
            return PediaWordsDeleteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科针对uuid删除当前词条</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsDeleteResponse
        /// </returns>
        public async Task<PediaWordsDeleteResponse> PediaWordsDeleteAsync(PediaWordsDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
            return await PediaWordsDeleteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条主键ID查询当前词条详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsQueryRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsQueryResponse
        /// </returns>
        public PediaWordsQueryResponse PediaWordsQueryWithOptions(PediaWordsQueryRequest request, PediaWordsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
                Action = "PediaWordsQuery",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条主键ID查询当前词条详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsQueryRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsQueryResponse
        /// </returns>
        public async Task<PediaWordsQueryResponse> PediaWordsQueryWithOptionsAsync(PediaWordsQueryRequest request, PediaWordsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
                Action = "PediaWordsQuery",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条主键ID查询当前词条详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsQueryResponse
        /// </returns>
        public PediaWordsQueryResponse PediaWordsQuery(PediaWordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
            return PediaWordsQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条主键ID查询当前词条详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsQueryResponse
        /// </returns>
        public async Task<PediaWordsQueryResponse> PediaWordsQueryAsync(PediaWordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
            return await PediaWordsQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsSearchRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsSearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsSearchResponse
        /// </returns>
        public PediaWordsSearchResponse PediaWordsSearchWithOptions(PediaWordsSearchRequest request, PediaWordsSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
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
                Action = "PediaWordsSearch",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsSearchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsSearchRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsSearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsSearchResponse
        /// </returns>
        public async Task<PediaWordsSearchResponse> PediaWordsSearchWithOptionsAsync(PediaWordsSearchRequest request, PediaWordsSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
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
                Action = "PediaWordsSearch",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsSearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsSearchResponse
        /// </returns>
        public PediaWordsSearchResponse PediaWordsSearch(PediaWordsSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
            return PediaWordsSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业词条信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsSearchResponse
        /// </returns>
        public async Task<PediaWordsSearchResponse> PediaWordsSearchAsync(PediaWordsSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
            return await PediaWordsSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科对当前已经生效词条进行编辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsUpdateRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsUpdateResponse
        /// </returns>
        public PediaWordsUpdateResponse PediaWordsUpdateWithOptions(PediaWordsUpdateRequest request, PediaWordsUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppLink))
            {
                body["appLink"] = request.AppLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Action = "PediaWordsUpdate",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科对当前已经生效词条进行编辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsUpdateRequest
        /// </param>
        /// <param name="headers">
        /// PediaWordsUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsUpdateResponse
        /// </returns>
        public async Task<PediaWordsUpdateResponse> PediaWordsUpdateWithOptionsAsync(PediaWordsUpdateRequest request, PediaWordsUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppLink))
            {
                body["appLink"] = request.AppLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Action = "PediaWordsUpdate",
                Version = "pedia_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/pedia/words",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PediaWordsUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科对当前已经生效词条进行编辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsUpdateResponse
        /// </returns>
        public PediaWordsUpdateResponse PediaWordsUpdate(PediaWordsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
            return PediaWordsUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业百科对当前已经生效词条进行编辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PediaWordsUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// PediaWordsUpdateResponse
        /// </returns>
        public async Task<PediaWordsUpdateResponse> PediaWordsUpdateAsync(PediaWordsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
            return await PediaWordsUpdateWithOptionsAsync(request, headers, runtime);
        }

    }
}
