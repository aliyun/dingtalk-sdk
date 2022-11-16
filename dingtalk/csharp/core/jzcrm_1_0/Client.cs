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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
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

        public EditContactResponse EditContactWithOptions(EditContactRequest request, EditContactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditContactResponse>(DoROARequest("EditContact", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/contacts", "json", req, runtime));
        }

        public async Task<EditContactResponse> EditContactWithOptionsAsync(EditContactRequest request, EditContactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditContactResponse>(await DoROARequestAsync("EditContact", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/contacts", "json", req, runtime));
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

        public EditCustomerResponse EditCustomerWithOptions(EditCustomerRequest request, EditCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditCustomerResponse>(DoROARequest("EditCustomer", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/customers", "json", req, runtime));
        }

        public async Task<EditCustomerResponse> EditCustomerWithOptionsAsync(EditCustomerRequest request, EditCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditCustomerResponse>(await DoROARequestAsync("EditCustomer", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/customers", "json", req, runtime));
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

        public EditCustomerPoolResponse EditCustomerPoolWithOptions(EditCustomerPoolRequest request, EditCustomerPoolHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditCustomerPoolResponse>(DoROARequest("EditCustomerPool", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/customerPools", "json", req, runtime));
        }

        public async Task<EditCustomerPoolResponse> EditCustomerPoolWithOptionsAsync(EditCustomerPoolRequest request, EditCustomerPoolHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditCustomerPoolResponse>(await DoROARequestAsync("EditCustomerPool", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/customerPools", "json", req, runtime));
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

        public EditExchangeResponse EditExchangeWithOptions(EditExchangeRequest request, EditExchangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditExchangeResponse>(DoROARequest("EditExchange", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/exchanges", "json", req, runtime));
        }

        public async Task<EditExchangeResponse> EditExchangeWithOptionsAsync(EditExchangeRequest request, EditExchangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditExchangeResponse>(await DoROARequestAsync("EditExchange", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/exchanges", "json", req, runtime));
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

        public EditGoodsResponse EditGoodsWithOptions(EditGoodsRequest request, EditGoodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditGoodsResponse>(DoROARequest("EditGoods", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/goods", "json", req, runtime));
        }

        public async Task<EditGoodsResponse> EditGoodsWithOptionsAsync(EditGoodsRequest request, EditGoodsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditGoodsResponse>(await DoROARequestAsync("EditGoods", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/goods", "json", req, runtime));
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

        public EditIntostockResponse EditIntostockWithOptions(EditIntostockRequest request, EditIntostockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditIntostockResponse>(DoROARequest("EditIntostock", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/intostocks", "json", req, runtime));
        }

        public async Task<EditIntostockResponse> EditIntostockWithOptionsAsync(EditIntostockRequest request, EditIntostockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditIntostockResponse>(await DoROARequestAsync("EditIntostock", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/intostocks", "json", req, runtime));
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

        public EditInvoiceResponse EditInvoiceWithOptions(EditInvoiceRequest request, EditInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditInvoiceResponse>(DoROARequest("EditInvoice", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/invoices", "json", req, runtime));
        }

        public async Task<EditInvoiceResponse> EditInvoiceWithOptionsAsync(EditInvoiceRequest request, EditInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditInvoiceResponse>(await DoROARequestAsync("EditInvoice", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/invoices", "json", req, runtime));
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

        public EditOrderResponse EditOrderWithOptions(EditOrderRequest request, EditOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditOrderResponse>(DoROARequest("EditOrder", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/orders", "json", req, runtime));
        }

        public async Task<EditOrderResponse> EditOrderWithOptionsAsync(EditOrderRequest request, EditOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditOrderResponse>(await DoROARequestAsync("EditOrder", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/orders", "json", req, runtime));
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

        public EditOutstockResponse EditOutstockWithOptions(EditOutstockRequest request, EditOutstockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditOutstockResponse>(DoROARequest("EditOutstock", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/outstocks", "json", req, runtime));
        }

        public async Task<EditOutstockResponse> EditOutstockWithOptionsAsync(EditOutstockRequest request, EditOutstockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditOutstockResponse>(await DoROARequestAsync("EditOutstock", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/outstocks", "json", req, runtime));
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

        public EditProductionResponse EditProductionWithOptions(EditProductionRequest request, EditProductionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditProductionResponse>(DoROARequest("EditProduction", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/productions", "json", req, runtime));
        }

        public async Task<EditProductionResponse> EditProductionWithOptionsAsync(EditProductionRequest request, EditProductionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditProductionResponse>(await DoROARequestAsync("EditProduction", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/productions", "json", req, runtime));
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

        public EditPurchaseResponse EditPurchaseWithOptions(EditPurchaseRequest request, EditPurchaseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditPurchaseResponse>(DoROARequest("EditPurchase", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/purchases", "json", req, runtime));
        }

        public async Task<EditPurchaseResponse> EditPurchaseWithOptionsAsync(EditPurchaseRequest request, EditPurchaseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditPurchaseResponse>(await DoROARequestAsync("EditPurchase", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/purchases", "json", req, runtime));
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

        public EditQuotationRecordResponse EditQuotationRecordWithOptions(EditQuotationRecordRequest request, EditQuotationRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditQuotationRecordResponse>(DoROARequest("EditQuotationRecord", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/quotationRecords", "json", req, runtime));
        }

        public async Task<EditQuotationRecordResponse> EditQuotationRecordWithOptionsAsync(EditQuotationRecordRequest request, EditQuotationRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditQuotationRecordResponse>(await DoROARequestAsync("EditQuotationRecord", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/quotationRecords", "json", req, runtime));
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

        public EditSalesResponse EditSalesWithOptions(EditSalesRequest request, EditSalesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditSalesResponse>(DoROARequest("EditSales", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/sales", "json", req, runtime));
        }

        public async Task<EditSalesResponse> EditSalesWithOptionsAsync(EditSalesRequest request, EditSalesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data.ToMap()))
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
            return TeaModel.ToObject<EditSalesResponse>(await DoROARequestAsync("EditSales", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/sales", "json", req, runtime));
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
            return TeaModel.ToObject<GetDataListResponse>(DoROARequest("GetDataList", "jzcrm_1.0", "HTTP", "GET", "AK", "/v1.0/jzcrm/data", "json", req, runtime));
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
            return TeaModel.ToObject<GetDataListResponse>(await DoROARequestAsync("GetDataList", "jzcrm_1.0", "HTTP", "GET", "AK", "/v1.0/jzcrm/data", "json", req, runtime));
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
            return TeaModel.ToObject<GetDataViewResponse>(DoROARequest("GetDataView", "jzcrm_1.0", "HTTP", "GET", "AK", "/v1.0/jzcrm/dataView", "json", req, runtime));
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
            return TeaModel.ToObject<GetDataViewResponse>(await DoROARequestAsync("GetDataView", "jzcrm_1.0", "HTTP", "GET", "AK", "/v1.0/jzcrm/dataView", "json", req, runtime));
        }

    }
}
