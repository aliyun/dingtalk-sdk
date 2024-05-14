// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcontract_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0
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
         * @summary 合同权益核销
         *
         * @param request ContractBenefitConsumeRequest
         * @param headers ContractBenefitConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContractBenefitConsumeResponse
         */
        public ContractBenefitConsumeResponse ContractBenefitConsumeWithOptions(ContractBenefitConsumeRequest request, ContractBenefitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPoint))
            {
                body["benefitPoint"] = request.BenefitPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeQuota))
            {
                body["consumeQuota"] = request.ConsumeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                body["extParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCorpId))
            {
                body["isvCorpId"] = request.IsvCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUnionId))
            {
                body["optUnionId"] = request.OptUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ContractBenefitConsume",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/benefits/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractBenefitConsumeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 合同权益核销
         *
         * @param request ContractBenefitConsumeRequest
         * @param headers ContractBenefitConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContractBenefitConsumeResponse
         */
        public async Task<ContractBenefitConsumeResponse> ContractBenefitConsumeWithOptionsAsync(ContractBenefitConsumeRequest request, ContractBenefitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPoint))
            {
                body["benefitPoint"] = request.BenefitPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeQuota))
            {
                body["consumeQuota"] = request.ConsumeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                body["extParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCorpId))
            {
                body["isvCorpId"] = request.IsvCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUnionId))
            {
                body["optUnionId"] = request.OptUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ContractBenefitConsume",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/benefits/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractBenefitConsumeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 合同权益核销
         *
         * @param request ContractBenefitConsumeRequest
         * @return ContractBenefitConsumeResponse
         */
        public ContractBenefitConsumeResponse ContractBenefitConsume(ContractBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractBenefitConsumeHeaders headers = new ContractBenefitConsumeHeaders();
            return ContractBenefitConsumeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 合同权益核销
         *
         * @param request ContractBenefitConsumeRequest
         * @return ContractBenefitConsumeResponse
         */
        public async Task<ContractBenefitConsumeResponse> ContractBenefitConsumeAsync(ContractBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractBenefitConsumeHeaders headers = new ContractBenefitConsumeHeaders();
            return await ContractBenefitConsumeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 天谷侧查询审批单
         *
         * @param request EsignQueryApprovalInfoRequest
         * @param headers EsignQueryApprovalInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignQueryApprovalInfoResponse
         */
        public EsignQueryApprovalInfoResponse EsignQueryApprovalInfoWithOptions(EsignQueryApprovalInfoRequest request, EsignQueryApprovalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignFlowId))
            {
                body["esignFlowId"] = request.EsignFlowId;
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
                Action = "EsignQueryApprovalInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/approvalInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryApprovalInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 天谷侧查询审批单
         *
         * @param request EsignQueryApprovalInfoRequest
         * @param headers EsignQueryApprovalInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignQueryApprovalInfoResponse
         */
        public async Task<EsignQueryApprovalInfoResponse> EsignQueryApprovalInfoWithOptionsAsync(EsignQueryApprovalInfoRequest request, EsignQueryApprovalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignFlowId))
            {
                body["esignFlowId"] = request.EsignFlowId;
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
                Action = "EsignQueryApprovalInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/approvalInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryApprovalInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 天谷侧查询审批单
         *
         * @param request EsignQueryApprovalInfoRequest
         * @return EsignQueryApprovalInfoResponse
         */
        public EsignQueryApprovalInfoResponse EsignQueryApprovalInfo(EsignQueryApprovalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryApprovalInfoHeaders headers = new EsignQueryApprovalInfoHeaders();
            return EsignQueryApprovalInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 天谷侧查询审批单
         *
         * @param request EsignQueryApprovalInfoRequest
         * @return EsignQueryApprovalInfoResponse
         */
        public async Task<EsignQueryApprovalInfoResponse> EsignQueryApprovalInfoAsync(EsignQueryApprovalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryApprovalInfoHeaders headers = new EsignQueryApprovalInfoHeaders();
            return await EsignQueryApprovalInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 天谷侧查询授权信息接口
         *
         * @param request EsignQueryGrantInfoRequest
         * @param headers EsignQueryGrantInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignQueryGrantInfoResponse
         */
        public EsignQueryGrantInfoResponse EsignQueryGrantInfoWithOptions(EsignQueryGrantInfoRequest request, EsignQueryGrantInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
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
                Action = "EsignQueryGrantInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/anthInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryGrantInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 天谷侧查询授权信息接口
         *
         * @param request EsignQueryGrantInfoRequest
         * @param headers EsignQueryGrantInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignQueryGrantInfoResponse
         */
        public async Task<EsignQueryGrantInfoResponse> EsignQueryGrantInfoWithOptionsAsync(EsignQueryGrantInfoRequest request, EsignQueryGrantInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
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
                Action = "EsignQueryGrantInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/anthInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryGrantInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 天谷侧查询授权信息接口
         *
         * @param request EsignQueryGrantInfoRequest
         * @return EsignQueryGrantInfoResponse
         */
        public EsignQueryGrantInfoResponse EsignQueryGrantInfo(EsignQueryGrantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryGrantInfoHeaders headers = new EsignQueryGrantInfoHeaders();
            return EsignQueryGrantInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 天谷侧查询授权信息接口
         *
         * @param request EsignQueryGrantInfoRequest
         * @return EsignQueryGrantInfoResponse
         */
        public async Task<EsignQueryGrantInfoResponse> EsignQueryGrantInfoAsync(EsignQueryGrantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryGrantInfoHeaders headers = new EsignQueryGrantInfoHeaders();
            return await EsignQueryGrantInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 天谷侧查询获取免登信息
         *
         * @param request EsignQueryIdentityByTicketRequest
         * @param headers EsignQueryIdentityByTicketHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignQueryIdentityByTicketResponse
         */
        public EsignQueryIdentityByTicketResponse EsignQueryIdentityByTicketWithOptions(EsignQueryIdentityByTicketRequest request, EsignQueryIdentityByTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EsignQueryIdentityByTicket",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/tickets/identities/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryIdentityByTicketResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 天谷侧查询获取免登信息
         *
         * @param request EsignQueryIdentityByTicketRequest
         * @param headers EsignQueryIdentityByTicketHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignQueryIdentityByTicketResponse
         */
        public async Task<EsignQueryIdentityByTicketResponse> EsignQueryIdentityByTicketWithOptionsAsync(EsignQueryIdentityByTicketRequest request, EsignQueryIdentityByTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EsignQueryIdentityByTicket",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/tickets/identities/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryIdentityByTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 天谷侧查询获取免登信息
         *
         * @param request EsignQueryIdentityByTicketRequest
         * @return EsignQueryIdentityByTicketResponse
         */
        public EsignQueryIdentityByTicketResponse EsignQueryIdentityByTicket(EsignQueryIdentityByTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryIdentityByTicketHeaders headers = new EsignQueryIdentityByTicketHeaders();
            return EsignQueryIdentityByTicketWithOptions(request, headers, runtime);
        }

        /**
         * @summary 天谷侧查询获取免登信息
         *
         * @param request EsignQueryIdentityByTicketRequest
         * @return EsignQueryIdentityByTicketResponse
         */
        public async Task<EsignQueryIdentityByTicketResponse> EsignQueryIdentityByTicketAsync(EsignQueryIdentityByTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryIdentityByTicketHeaders headers = new EsignQueryIdentityByTicketHeaders();
            return await EsignQueryIdentityByTicketWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary e签宝电子签事件同步回传接口
         *
         * @param request EsignSyncEventRequest
         * @param headers EsignSyncEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignSyncEventResponse
         */
        public EsignSyncEventResponse EsignSyncEventWithOptions(EsignSyncEventRequest request, EsignSyncEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignData))
            {
                body["esignData"] = request.EsignData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
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
                Action = "EsignSyncEvent",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/events/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignSyncEventResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary e签宝电子签事件同步回传接口
         *
         * @param request EsignSyncEventRequest
         * @param headers EsignSyncEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EsignSyncEventResponse
         */
        public async Task<EsignSyncEventResponse> EsignSyncEventWithOptionsAsync(EsignSyncEventRequest request, EsignSyncEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignData))
            {
                body["esignData"] = request.EsignData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
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
                Action = "EsignSyncEvent",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/events/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignSyncEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary e签宝电子签事件同步回传接口
         *
         * @param request EsignSyncEventRequest
         * @return EsignSyncEventResponse
         */
        public EsignSyncEventResponse EsignSyncEvent(EsignSyncEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignSyncEventHeaders headers = new EsignSyncEventHeaders();
            return EsignSyncEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary e签宝电子签事件同步回传接口
         *
         * @param request EsignSyncEventRequest
         * @return EsignSyncEventResponse
         */
        public async Task<EsignSyncEventResponse> EsignSyncEventAsync(EsignSyncEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignSyncEventHeaders headers = new EsignSyncEventHeaders();
            return await EsignSyncEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary e签宝查询智能合同版本接口
         *
         * @param request QueryAdvancedContractVersionRequest
         * @param headers QueryAdvancedContractVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAdvancedContractVersionResponse
         */
        public QueryAdvancedContractVersionResponse QueryAdvancedContractVersionWithOptions(QueryAdvancedContractVersionRequest request, QueryAdvancedContractVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryAdvancedContractVersion",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/versions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvancedContractVersionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary e签宝查询智能合同版本接口
         *
         * @param request QueryAdvancedContractVersionRequest
         * @param headers QueryAdvancedContractVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAdvancedContractVersionResponse
         */
        public async Task<QueryAdvancedContractVersionResponse> QueryAdvancedContractVersionWithOptionsAsync(QueryAdvancedContractVersionRequest request, QueryAdvancedContractVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryAdvancedContractVersion",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/versions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvancedContractVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary e签宝查询智能合同版本接口
         *
         * @param request QueryAdvancedContractVersionRequest
         * @return QueryAdvancedContractVersionResponse
         */
        public QueryAdvancedContractVersionResponse QueryAdvancedContractVersion(QueryAdvancedContractVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAdvancedContractVersionHeaders headers = new QueryAdvancedContractVersionHeaders();
            return QueryAdvancedContractVersionWithOptions(request, headers, runtime);
        }

        /**
         * @summary e签宝查询智能合同版本接口
         *
         * @param request QueryAdvancedContractVersionRequest
         * @return QueryAdvancedContractVersionResponse
         */
        public async Task<QueryAdvancedContractVersionResponse> QueryAdvancedContractVersionAsync(QueryAdvancedContractVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAdvancedContractVersionHeaders headers = new QueryAdvancedContractVersionHeaders();
            return await QueryAdvancedContractVersionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送合同相关卡片
         *
         * @param request SendContractCardRequest
         * @param headers SendContractCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendContractCardResponse
         */
        public SendContractCardResponse SendContractCardWithOptions(SendContractCardRequest request, SendContractCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractInfo))
            {
                body["contractInfo"] = request.ContractInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveGroups))
            {
                body["receiveGroups"] = request.ReceiveGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receivers))
            {
                body["receivers"] = request.Receivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sender))
            {
                body["sender"] = request.Sender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncSingleChat))
            {
                body["syncSingleChat"] = request.SyncSingleChat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendContractCard",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendContractCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送合同相关卡片
         *
         * @param request SendContractCardRequest
         * @param headers SendContractCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendContractCardResponse
         */
        public async Task<SendContractCardResponse> SendContractCardWithOptionsAsync(SendContractCardRequest request, SendContractCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractInfo))
            {
                body["contractInfo"] = request.ContractInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveGroups))
            {
                body["receiveGroups"] = request.ReceiveGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receivers))
            {
                body["receivers"] = request.Receivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sender))
            {
                body["sender"] = request.Sender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncSingleChat))
            {
                body["syncSingleChat"] = request.SyncSingleChat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendContractCard",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendContractCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送合同相关卡片
         *
         * @param request SendContractCardRequest
         * @return SendContractCardResponse
         */
        public SendContractCardResponse SendContractCard(SendContractCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendContractCardHeaders headers = new SendContractCardHeaders();
            return SendContractCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送合同相关卡片
         *
         * @param request SendContractCardRequest
         * @return SendContractCardResponse
         */
        public async Task<SendContractCardResponse> SendContractCardAsync(SendContractCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendContractCardHeaders headers = new SendContractCardHeaders();
            return await SendContractCardWithOptionsAsync(request, headers, runtime);
        }

    }
}
