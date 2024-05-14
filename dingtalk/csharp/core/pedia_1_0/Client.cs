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
         * @summary 企业百科增加当前企业词条信息
         *
         * @param request PediaWordsAddRequest
         * @param headers PediaWordsAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsAddResponse
         */
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

        /**
         * @summary 企业百科增加当前企业词条信息
         *
         * @param request PediaWordsAddRequest
         * @param headers PediaWordsAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsAddResponse
         */
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

        /**
         * @summary 企业百科增加当前企业词条信息
         *
         * @param request PediaWordsAddRequest
         * @return PediaWordsAddResponse
         */
        public PediaWordsAddResponse PediaWordsAdd(PediaWordsAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
            return PediaWordsAddWithOptions(request, headers, runtime);
        }

        /**
         * @summary 企业百科增加当前企业词条信息
         *
         * @param request PediaWordsAddRequest
         * @return PediaWordsAddResponse
         */
        public async Task<PediaWordsAddResponse> PediaWordsAddAsync(PediaWordsAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
            return await PediaWordsAddWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 企业百科针对待审核词条进行审核
         *
         * @param request PediaWordsApproveRequest
         * @param headers PediaWordsApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsApproveResponse
         */
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

        /**
         * @summary 企业百科针对待审核词条进行审核
         *
         * @param request PediaWordsApproveRequest
         * @param headers PediaWordsApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsApproveResponse
         */
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

        /**
         * @summary 企业百科针对待审核词条进行审核
         *
         * @param request PediaWordsApproveRequest
         * @return PediaWordsApproveResponse
         */
        public PediaWordsApproveResponse PediaWordsApprove(PediaWordsApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
            return PediaWordsApproveWithOptions(request, headers, runtime);
        }

        /**
         * @summary 企业百科针对待审核词条进行审核
         *
         * @param request PediaWordsApproveRequest
         * @return PediaWordsApproveResponse
         */
        public async Task<PediaWordsApproveResponse> PediaWordsApproveAsync(PediaWordsApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
            return await PediaWordsApproveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 企业百科针对uuid删除当前词条
         *
         * @param request PediaWordsDeleteRequest
         * @param headers PediaWordsDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsDeleteResponse
         */
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

        /**
         * @summary 企业百科针对uuid删除当前词条
         *
         * @param request PediaWordsDeleteRequest
         * @param headers PediaWordsDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsDeleteResponse
         */
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

        /**
         * @summary 企业百科针对uuid删除当前词条
         *
         * @param request PediaWordsDeleteRequest
         * @return PediaWordsDeleteResponse
         */
        public PediaWordsDeleteResponse PediaWordsDelete(PediaWordsDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
            return PediaWordsDeleteWithOptions(request, headers, runtime);
        }

        /**
         * @summary 企业百科针对uuid删除当前词条
         *
         * @param request PediaWordsDeleteRequest
         * @return PediaWordsDeleteResponse
         */
        public async Task<PediaWordsDeleteResponse> PediaWordsDeleteAsync(PediaWordsDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
            return await PediaWordsDeleteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据词条主键ID查询当前词条详情
         *
         * @param request PediaWordsQueryRequest
         * @param headers PediaWordsQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsQueryResponse
         */
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

        /**
         * @summary 根据词条主键ID查询当前词条详情
         *
         * @param request PediaWordsQueryRequest
         * @param headers PediaWordsQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsQueryResponse
         */
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

        /**
         * @summary 根据词条主键ID查询当前词条详情
         *
         * @param request PediaWordsQueryRequest
         * @return PediaWordsQueryResponse
         */
        public PediaWordsQueryResponse PediaWordsQuery(PediaWordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
            return PediaWordsQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据词条主键ID查询当前词条详情
         *
         * @param request PediaWordsQueryRequest
         * @return PediaWordsQueryResponse
         */
        public async Task<PediaWordsQueryResponse> PediaWordsQueryAsync(PediaWordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
            return await PediaWordsQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页获取企业词条信息
         *
         * @param request PediaWordsSearchRequest
         * @param headers PediaWordsSearchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsSearchResponse
         */
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

        /**
         * @summary 分页获取企业词条信息
         *
         * @param request PediaWordsSearchRequest
         * @param headers PediaWordsSearchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsSearchResponse
         */
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

        /**
         * @summary 分页获取企业词条信息
         *
         * @param request PediaWordsSearchRequest
         * @return PediaWordsSearchResponse
         */
        public PediaWordsSearchResponse PediaWordsSearch(PediaWordsSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
            return PediaWordsSearchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页获取企业词条信息
         *
         * @param request PediaWordsSearchRequest
         * @return PediaWordsSearchResponse
         */
        public async Task<PediaWordsSearchResponse> PediaWordsSearchAsync(PediaWordsSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
            return await PediaWordsSearchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 企业百科对当前已经生效词条进行编辑
         *
         * @param request PediaWordsUpdateRequest
         * @param headers PediaWordsUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsUpdateResponse
         */
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

        /**
         * @summary 企业百科对当前已经生效词条进行编辑
         *
         * @param request PediaWordsUpdateRequest
         * @param headers PediaWordsUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PediaWordsUpdateResponse
         */
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

        /**
         * @summary 企业百科对当前已经生效词条进行编辑
         *
         * @param request PediaWordsUpdateRequest
         * @return PediaWordsUpdateResponse
         */
        public PediaWordsUpdateResponse PediaWordsUpdate(PediaWordsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
            return PediaWordsUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 企业百科对当前已经生效词条进行编辑
         *
         * @param request PediaWordsUpdateRequest
         * @return PediaWordsUpdateResponse
         */
        public async Task<PediaWordsUpdateResponse> PediaWordsUpdateAsync(PediaWordsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
            return await PediaWordsUpdateWithOptionsAsync(request, headers, runtime);
        }

    }
}
