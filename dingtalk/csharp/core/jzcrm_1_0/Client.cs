// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0
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
        /// <para>编辑联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditContactRequest
        /// </param>
        /// <param name="headers">
        /// EditContactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditContactResponse
        /// </returns>
        public EditContactResponse EditContactWithOptions(EditContactRequest request, EditContactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditContact",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/contacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditContactResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditContactRequest
        /// </param>
        /// <param name="headers">
        /// EditContactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditContactResponse
        /// </returns>
        public async Task<EditContactResponse> EditContactWithOptionsAsync(EditContactRequest request, EditContactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditContact",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/contacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditContactResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditContactRequest
        /// </param>
        /// 
        /// <returns>
        /// EditContactResponse
        /// </returns>
        public EditContactResponse EditContact(EditContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditContactHeaders headers = new EditContactHeaders();
            return EditContactWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑联系人数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditContactRequest
        /// </param>
        /// 
        /// <returns>
        /// EditContactResponse
        /// </returns>
        public async Task<EditContactResponse> EditContactAsync(EditContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditContactHeaders headers = new EditContactHeaders();
            return await EditContactWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerRequest
        /// </param>
        /// <param name="headers">
        /// EditCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerResponse
        /// </returns>
        public EditCustomerResponse EditCustomerWithOptions(EditCustomerRequest request, EditCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditCustomer",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerRequest
        /// </param>
        /// <param name="headers">
        /// EditCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerResponse
        /// </returns>
        public async Task<EditCustomerResponse> EditCustomerWithOptionsAsync(EditCustomerRequest request, EditCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditCustomer",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerResponse
        /// </returns>
        public EditCustomerResponse EditCustomer(EditCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerHeaders headers = new EditCustomerHeaders();
            return EditCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerResponse
        /// </returns>
        public async Task<EditCustomerResponse> EditCustomerAsync(EditCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerHeaders headers = new EditCustomerHeaders();
            return await EditCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户公共池数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerPoolRequest
        /// </param>
        /// <param name="headers">
        /// EditCustomerPoolHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerPoolResponse
        /// </returns>
        public EditCustomerPoolResponse EditCustomerPoolWithOptions(EditCustomerPoolRequest request, EditCustomerPoolHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditCustomerPool",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/customerPools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditCustomerPoolResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户公共池数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerPoolRequest
        /// </param>
        /// <param name="headers">
        /// EditCustomerPoolHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerPoolResponse
        /// </returns>
        public async Task<EditCustomerPoolResponse> EditCustomerPoolWithOptionsAsync(EditCustomerPoolRequest request, EditCustomerPoolHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditCustomerPool",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/customerPools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditCustomerPoolResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户公共池数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerPoolResponse
        /// </returns>
        public EditCustomerPoolResponse EditCustomerPool(EditCustomerPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerPoolHeaders headers = new EditCustomerPoolHeaders();
            return EditCustomerPoolWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑客户公共池数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditCustomerPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// EditCustomerPoolResponse
        /// </returns>
        public async Task<EditCustomerPoolResponse> EditCustomerPoolAsync(EditCustomerPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerPoolHeaders headers = new EditCustomerPoolHeaders();
            return await EditCustomerPoolWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售换货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditExchangeRequest
        /// </param>
        /// <param name="headers">
        /// EditExchangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditExchangeResponse
        /// </returns>
        public EditExchangeResponse EditExchangeWithOptions(EditExchangeRequest request, EditExchangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditExchange",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/exchanges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditExchangeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售换货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditExchangeRequest
        /// </param>
        /// <param name="headers">
        /// EditExchangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditExchangeResponse
        /// </returns>
        public async Task<EditExchangeResponse> EditExchangeWithOptionsAsync(EditExchangeRequest request, EditExchangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditExchange",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/exchanges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditExchangeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售换货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditExchangeRequest
        /// </param>
        /// 
        /// <returns>
        /// EditExchangeResponse
        /// </returns>
        public EditExchangeResponse EditExchange(EditExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditExchangeHeaders headers = new EditExchangeHeaders();
            return EditExchangeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售换货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditExchangeRequest
        /// </param>
        /// 
        /// <returns>
        /// EditExchangeResponse
        /// </returns>
        public async Task<EditExchangeResponse> EditExchangeAsync(EditExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditExchangeHeaders headers = new EditExchangeHeaders();
            return await EditExchangeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑产品数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGoodsRequest
        /// </param>
        /// <param name="headers">
        /// EditGoodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditGoodsResponse
        /// </returns>
        public EditGoodsResponse EditGoodsWithOptions(EditGoodsRequest request, EditGoodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditGoods",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/goods",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditGoodsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑产品数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGoodsRequest
        /// </param>
        /// <param name="headers">
        /// EditGoodsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditGoodsResponse
        /// </returns>
        public async Task<EditGoodsResponse> EditGoodsWithOptionsAsync(EditGoodsRequest request, EditGoodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditGoods",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/goods",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditGoodsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑产品数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGoodsRequest
        /// </param>
        /// 
        /// <returns>
        /// EditGoodsResponse
        /// </returns>
        public EditGoodsResponse EditGoods(EditGoodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditGoodsHeaders headers = new EditGoodsHeaders();
            return EditGoodsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑产品数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditGoodsRequest
        /// </param>
        /// 
        /// <returns>
        /// EditGoodsResponse
        /// </returns>
        public async Task<EditGoodsResponse> EditGoodsAsync(EditGoodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditGoodsHeaders headers = new EditGoodsHeaders();
            return await EditGoodsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑入库单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditIntostockRequest
        /// </param>
        /// <param name="headers">
        /// EditIntostockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditIntostockResponse
        /// </returns>
        public EditIntostockResponse EditIntostockWithOptions(EditIntostockRequest request, EditIntostockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditIntostock",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/intostocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditIntostockResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑入库单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditIntostockRequest
        /// </param>
        /// <param name="headers">
        /// EditIntostockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditIntostockResponse
        /// </returns>
        public async Task<EditIntostockResponse> EditIntostockWithOptionsAsync(EditIntostockRequest request, EditIntostockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditIntostock",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/intostocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditIntostockResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑入库单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditIntostockRequest
        /// </param>
        /// 
        /// <returns>
        /// EditIntostockResponse
        /// </returns>
        public EditIntostockResponse EditIntostock(EditIntostockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditIntostockHeaders headers = new EditIntostockHeaders();
            return EditIntostockWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑入库单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditIntostockRequest
        /// </param>
        /// 
        /// <returns>
        /// EditIntostockResponse
        /// </returns>
        public async Task<EditIntostockResponse> EditIntostockAsync(EditIntostockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditIntostockHeaders headers = new EditIntostockHeaders();
            return await EditIntostockWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑发货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// EditInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditInvoiceResponse
        /// </returns>
        public EditInvoiceResponse EditInvoiceWithOptions(EditInvoiceRequest request, EditInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditInvoice",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/invoices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditInvoiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑发货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// EditInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditInvoiceResponse
        /// </returns>
        public async Task<EditInvoiceResponse> EditInvoiceWithOptionsAsync(EditInvoiceRequest request, EditInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditInvoice",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/invoices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditInvoiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑发货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// EditInvoiceResponse
        /// </returns>
        public EditInvoiceResponse EditInvoice(EditInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditInvoiceHeaders headers = new EditInvoiceHeaders();
            return EditInvoiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑发货单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// EditInvoiceResponse
        /// </returns>
        public async Task<EditInvoiceResponse> EditInvoiceAsync(EditInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditInvoiceHeaders headers = new EditInvoiceHeaders();
            return await EditInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑合同订单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOrderRequest
        /// </param>
        /// <param name="headers">
        /// EditOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditOrderResponse
        /// </returns>
        public EditOrderResponse EditOrderWithOptions(EditOrderRequest request, EditOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditOrder",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑合同订单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOrderRequest
        /// </param>
        /// <param name="headers">
        /// EditOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditOrderResponse
        /// </returns>
        public async Task<EditOrderResponse> EditOrderWithOptionsAsync(EditOrderRequest request, EditOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditOrder",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑合同订单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// EditOrderResponse
        /// </returns>
        public EditOrderResponse EditOrder(EditOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOrderHeaders headers = new EditOrderHeaders();
            return EditOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑合同订单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// EditOrderResponse
        /// </returns>
        public async Task<EditOrderResponse> EditOrderAsync(EditOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOrderHeaders headers = new EditOrderHeaders();
            return await EditOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑出库单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOutstockRequest
        /// </param>
        /// <param name="headers">
        /// EditOutstockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditOutstockResponse
        /// </returns>
        public EditOutstockResponse EditOutstockWithOptions(EditOutstockRequest request, EditOutstockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditOutstock",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/outstocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditOutstockResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑出库单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOutstockRequest
        /// </param>
        /// <param name="headers">
        /// EditOutstockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditOutstockResponse
        /// </returns>
        public async Task<EditOutstockResponse> EditOutstockWithOptionsAsync(EditOutstockRequest request, EditOutstockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditOutstock",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/outstocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditOutstockResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑出库单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOutstockRequest
        /// </param>
        /// 
        /// <returns>
        /// EditOutstockResponse
        /// </returns>
        public EditOutstockResponse EditOutstock(EditOutstockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOutstockHeaders headers = new EditOutstockHeaders();
            return EditOutstockWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑出库单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditOutstockRequest
        /// </param>
        /// 
        /// <returns>
        /// EditOutstockResponse
        /// </returns>
        public async Task<EditOutstockResponse> EditOutstockAsync(EditOutstockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOutstockHeaders headers = new EditOutstockHeaders();
            return await EditOutstockWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑生产单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditProductionRequest
        /// </param>
        /// <param name="headers">
        /// EditProductionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditProductionResponse
        /// </returns>
        public EditProductionResponse EditProductionWithOptions(EditProductionRequest request, EditProductionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditProduction",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/productions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditProductionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑生产单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditProductionRequest
        /// </param>
        /// <param name="headers">
        /// EditProductionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditProductionResponse
        /// </returns>
        public async Task<EditProductionResponse> EditProductionWithOptionsAsync(EditProductionRequest request, EditProductionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditProduction",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/productions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditProductionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑生产单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditProductionRequest
        /// </param>
        /// 
        /// <returns>
        /// EditProductionResponse
        /// </returns>
        public EditProductionResponse EditProduction(EditProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditProductionHeaders headers = new EditProductionHeaders();
            return EditProductionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑生产单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditProductionRequest
        /// </param>
        /// 
        /// <returns>
        /// EditProductionResponse
        /// </returns>
        public async Task<EditProductionResponse> EditProductionAsync(EditProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditProductionHeaders headers = new EditProductionHeaders();
            return await EditProductionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑采购单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditPurchaseRequest
        /// </param>
        /// <param name="headers">
        /// EditPurchaseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditPurchaseResponse
        /// </returns>
        public EditPurchaseResponse EditPurchaseWithOptions(EditPurchaseRequest request, EditPurchaseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditPurchase",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/purchases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditPurchaseResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑采购单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditPurchaseRequest
        /// </param>
        /// <param name="headers">
        /// EditPurchaseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditPurchaseResponse
        /// </returns>
        public async Task<EditPurchaseResponse> EditPurchaseWithOptionsAsync(EditPurchaseRequest request, EditPurchaseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditPurchase",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/purchases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditPurchaseResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑采购单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditPurchaseRequest
        /// </param>
        /// 
        /// <returns>
        /// EditPurchaseResponse
        /// </returns>
        public EditPurchaseResponse EditPurchase(EditPurchaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditPurchaseHeaders headers = new EditPurchaseHeaders();
            return EditPurchaseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑采购单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditPurchaseRequest
        /// </param>
        /// 
        /// <returns>
        /// EditPurchaseResponse
        /// </returns>
        public async Task<EditPurchaseResponse> EditPurchaseAsync(EditPurchaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditPurchaseHeaders headers = new EditPurchaseHeaders();
            return await EditPurchaseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑报价记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditQuotationRecordRequest
        /// </param>
        /// <param name="headers">
        /// EditQuotationRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQuotationRecordResponse
        /// </returns>
        public EditQuotationRecordResponse EditQuotationRecordWithOptions(EditQuotationRecordRequest request, EditQuotationRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditQuotationRecord",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/quotationRecords",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQuotationRecordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑报价记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditQuotationRecordRequest
        /// </param>
        /// <param name="headers">
        /// EditQuotationRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQuotationRecordResponse
        /// </returns>
        public async Task<EditQuotationRecordResponse> EditQuotationRecordWithOptionsAsync(EditQuotationRecordRequest request, EditQuotationRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditQuotationRecord",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/quotationRecords",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQuotationRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑报价记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditQuotationRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQuotationRecordResponse
        /// </returns>
        public EditQuotationRecordResponse EditQuotationRecord(EditQuotationRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditQuotationRecordHeaders headers = new EditQuotationRecordHeaders();
            return EditQuotationRecordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑报价记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditQuotationRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQuotationRecordResponse
        /// </returns>
        public async Task<EditQuotationRecordResponse> EditQuotationRecordAsync(EditQuotationRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditQuotationRecordHeaders headers = new EditQuotationRecordHeaders();
            return await EditQuotationRecordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售机会数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSalesRequest
        /// </param>
        /// <param name="headers">
        /// EditSalesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditSalesResponse
        /// </returns>
        public EditSalesResponse EditSalesWithOptions(EditSalesRequest request, EditSalesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditSales",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/sales",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditSalesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售机会数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSalesRequest
        /// </param>
        /// <param name="headers">
        /// EditSalesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditSalesResponse
        /// </returns>
        public async Task<EditSalesResponse> EditSalesWithOptionsAsync(EditSalesRequest request, EditSalesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                body["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                body["msgid"] = request.Msgid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stamp))
            {
                body["stamp"] = request.Stamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditSales",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/sales",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditSalesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售机会数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSalesRequest
        /// </param>
        /// 
        /// <returns>
        /// EditSalesResponse
        /// </returns>
        public EditSalesResponse EditSales(EditSalesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditSalesHeaders headers = new EditSalesHeaders();
            return EditSalesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑销售机会数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSalesRequest
        /// </param>
        /// 
        /// <returns>
        /// EditSalesResponse
        /// </returns>
        public async Task<EditSalesResponse> EditSalesAsync(EditSalesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditSalesHeaders headers = new EditSalesHeaders();
            return await EditSalesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataListRequest
        /// </param>
        /// <param name="headers">
        /// GetDataListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataListResponse
        /// </returns>
        public GetDataListResponse GetDataListWithOptions(GetDataListRequest request, GetDataListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                query["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pagesize))
            {
                query["pagesize"] = request.Pagesize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetDataList",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataListRequest
        /// </param>
        /// <param name="headers">
        /// GetDataListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataListResponse
        /// </returns>
        public async Task<GetDataListResponse> GetDataListWithOptionsAsync(GetDataListRequest request, GetDataListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                query["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pagesize))
            {
                query["pagesize"] = request.Pagesize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetDataList",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataListResponse
        /// </returns>
        public GetDataListResponse GetDataList(GetDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataListHeaders headers = new GetDataListHeaders();
            return GetDataListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataListResponse
        /// </returns>
        public async Task<GetDataListResponse> GetDataListAsync(GetDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataListHeaders headers = new GetDataListHeaders();
            return await GetDataListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataViewRequest
        /// </param>
        /// <param name="headers">
        /// GetDataViewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataViewResponse
        /// </returns>
        public GetDataViewResponse GetDataViewWithOptions(GetDataViewRequest request, GetDataViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                query["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                query["msgid"] = request.Msgid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetDataView",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/dataView",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataViewResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataViewRequest
        /// </param>
        /// <param name="headers">
        /// GetDataViewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataViewResponse
        /// </returns>
        public async Task<GetDataViewResponse> GetDataViewWithOptionsAsync(GetDataViewRequest request, GetDataViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datatype))
            {
                query["datatype"] = request.Datatype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgid))
            {
                query["msgid"] = request.Msgid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetDataView",
                Version = "jzcrm_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/jzcrm/dataView",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataViewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataViewResponse
        /// </returns>
        public GetDataViewResponse GetDataView(GetDataViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataViewHeaders headers = new GetDataViewHeaders();
            return GetDataViewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataViewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataViewResponse
        /// </returns>
        public async Task<GetDataViewResponse> GetDataViewAsync(GetDataViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataViewHeaders headers = new GetDataViewHeaders();
            return await GetDataViewWithOptionsAsync(request, headers, runtime);
        }

    }
}
