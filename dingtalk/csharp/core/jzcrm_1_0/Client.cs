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

        public EditContactResponse EditContact(EditContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditContactHeaders headers = new EditContactHeaders();
            return EditContactWithOptions(request, headers, runtime);
        }

        public async Task<EditContactResponse> EditContactAsync(EditContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditContactHeaders headers = new EditContactHeaders();
            return await EditContactWithOptionsAsync(request, headers, runtime);
        }

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

        public EditCustomerResponse EditCustomer(EditCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerHeaders headers = new EditCustomerHeaders();
            return EditCustomerWithOptions(request, headers, runtime);
        }

        public async Task<EditCustomerResponse> EditCustomerAsync(EditCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerHeaders headers = new EditCustomerHeaders();
            return await EditCustomerWithOptionsAsync(request, headers, runtime);
        }

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

        public EditCustomerPoolResponse EditCustomerPool(EditCustomerPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerPoolHeaders headers = new EditCustomerPoolHeaders();
            return EditCustomerPoolWithOptions(request, headers, runtime);
        }

        public async Task<EditCustomerPoolResponse> EditCustomerPoolAsync(EditCustomerPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditCustomerPoolHeaders headers = new EditCustomerPoolHeaders();
            return await EditCustomerPoolWithOptionsAsync(request, headers, runtime);
        }

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

        public EditExchangeResponse EditExchange(EditExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditExchangeHeaders headers = new EditExchangeHeaders();
            return EditExchangeWithOptions(request, headers, runtime);
        }

        public async Task<EditExchangeResponse> EditExchangeAsync(EditExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditExchangeHeaders headers = new EditExchangeHeaders();
            return await EditExchangeWithOptionsAsync(request, headers, runtime);
        }

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

        public EditGoodsResponse EditGoods(EditGoodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditGoodsHeaders headers = new EditGoodsHeaders();
            return EditGoodsWithOptions(request, headers, runtime);
        }

        public async Task<EditGoodsResponse> EditGoodsAsync(EditGoodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditGoodsHeaders headers = new EditGoodsHeaders();
            return await EditGoodsWithOptionsAsync(request, headers, runtime);
        }

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

        public EditIntostockResponse EditIntostock(EditIntostockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditIntostockHeaders headers = new EditIntostockHeaders();
            return EditIntostockWithOptions(request, headers, runtime);
        }

        public async Task<EditIntostockResponse> EditIntostockAsync(EditIntostockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditIntostockHeaders headers = new EditIntostockHeaders();
            return await EditIntostockWithOptionsAsync(request, headers, runtime);
        }

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

        public EditInvoiceResponse EditInvoice(EditInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditInvoiceHeaders headers = new EditInvoiceHeaders();
            return EditInvoiceWithOptions(request, headers, runtime);
        }

        public async Task<EditInvoiceResponse> EditInvoiceAsync(EditInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditInvoiceHeaders headers = new EditInvoiceHeaders();
            return await EditInvoiceWithOptionsAsync(request, headers, runtime);
        }

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

        public EditOrderResponse EditOrder(EditOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOrderHeaders headers = new EditOrderHeaders();
            return EditOrderWithOptions(request, headers, runtime);
        }

        public async Task<EditOrderResponse> EditOrderAsync(EditOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOrderHeaders headers = new EditOrderHeaders();
            return await EditOrderWithOptionsAsync(request, headers, runtime);
        }

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

        public EditOutstockResponse EditOutstock(EditOutstockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOutstockHeaders headers = new EditOutstockHeaders();
            return EditOutstockWithOptions(request, headers, runtime);
        }

        public async Task<EditOutstockResponse> EditOutstockAsync(EditOutstockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditOutstockHeaders headers = new EditOutstockHeaders();
            return await EditOutstockWithOptionsAsync(request, headers, runtime);
        }

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

        public EditProductionResponse EditProduction(EditProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditProductionHeaders headers = new EditProductionHeaders();
            return EditProductionWithOptions(request, headers, runtime);
        }

        public async Task<EditProductionResponse> EditProductionAsync(EditProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditProductionHeaders headers = new EditProductionHeaders();
            return await EditProductionWithOptionsAsync(request, headers, runtime);
        }

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

        public EditPurchaseResponse EditPurchase(EditPurchaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditPurchaseHeaders headers = new EditPurchaseHeaders();
            return EditPurchaseWithOptions(request, headers, runtime);
        }

        public async Task<EditPurchaseResponse> EditPurchaseAsync(EditPurchaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditPurchaseHeaders headers = new EditPurchaseHeaders();
            return await EditPurchaseWithOptionsAsync(request, headers, runtime);
        }

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

        public EditQuotationRecordResponse EditQuotationRecord(EditQuotationRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditQuotationRecordHeaders headers = new EditQuotationRecordHeaders();
            return EditQuotationRecordWithOptions(request, headers, runtime);
        }

        public async Task<EditQuotationRecordResponse> EditQuotationRecordAsync(EditQuotationRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditQuotationRecordHeaders headers = new EditQuotationRecordHeaders();
            return await EditQuotationRecordWithOptionsAsync(request, headers, runtime);
        }

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

        public EditSalesResponse EditSales(EditSalesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditSalesHeaders headers = new EditSalesHeaders();
            return EditSalesWithOptions(request, headers, runtime);
        }

        public async Task<EditSalesResponse> EditSalesAsync(EditSalesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditSalesHeaders headers = new EditSalesHeaders();
            return await EditSalesWithOptionsAsync(request, headers, runtime);
        }

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

        public GetDataListResponse GetDataList(GetDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataListHeaders headers = new GetDataListHeaders();
            return GetDataListWithOptions(request, headers, runtime);
        }

        public async Task<GetDataListResponse> GetDataListAsync(GetDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataListHeaders headers = new GetDataListHeaders();
            return await GetDataListWithOptionsAsync(request, headers, runtime);
        }

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

        public GetDataViewResponse GetDataView(GetDataViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataViewHeaders headers = new GetDataViewHeaders();
            return GetDataViewWithOptions(request, headers, runtime);
        }

        public async Task<GetDataViewResponse> GetDataViewAsync(GetDataViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataViewHeaders headers = new GetDataViewHeaders();
            return await GetDataViewWithOptionsAsync(request, headers, runtime);
        }

    }
}
