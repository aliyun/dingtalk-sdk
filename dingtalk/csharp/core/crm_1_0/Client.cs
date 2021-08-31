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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public GetOfficialAccountContactsResponse GetOfficialAccountContacts(GetOfficialAccountContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactsHeaders headers = new GetOfficialAccountContactsHeaders();
            return GetOfficialAccountContactsWithOptions(request, headers, runtime);
        }

        public async Task<GetOfficialAccountContactsResponse> GetOfficialAccountContactsAsync(GetOfficialAccountContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactsHeaders headers = new GetOfficialAccountContactsHeaders();
            return await GetOfficialAccountContactsWithOptionsAsync(request, headers, runtime);
        }

        public GetOfficialAccountContactsResponse GetOfficialAccountContactsWithOptions(GetOfficialAccountContactsRequest request, GetOfficialAccountContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetOfficialAccountContactsResponse>(DoROARequest("GetOfficialAccountContacts", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/contacts", "json", req, runtime));
        }

        public async Task<GetOfficialAccountContactsResponse> GetOfficialAccountContactsWithOptionsAsync(GetOfficialAccountContactsRequest request, GetOfficialAccountContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetOfficialAccountContactsResponse>(await DoROARequestAsync("GetOfficialAccountContacts", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/contacts", "json", req, runtime));
        }

        public ServiceWindowMessageBatchPushResponse ServiceWindowMessageBatchPush(ServiceWindowMessageBatchPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ServiceWindowMessageBatchPushHeaders headers = new ServiceWindowMessageBatchPushHeaders();
            return ServiceWindowMessageBatchPushWithOptions(request, headers, runtime);
        }

        public async Task<ServiceWindowMessageBatchPushResponse> ServiceWindowMessageBatchPushAsync(ServiceWindowMessageBatchPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ServiceWindowMessageBatchPushHeaders headers = new ServiceWindowMessageBatchPushHeaders();
            return await ServiceWindowMessageBatchPushWithOptionsAsync(request, headers, runtime);
        }

        public ServiceWindowMessageBatchPushResponse ServiceWindowMessageBatchPushWithOptions(ServiceWindowMessageBatchPushRequest request, ServiceWindowMessageBatchPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail.ToMap()))
            {
                body["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ServiceWindowMessageBatchPushResponse>(DoROARequest("ServiceWindowMessageBatchPush", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/messages/batchSend", "json", req, runtime));
        }

        public async Task<ServiceWindowMessageBatchPushResponse> ServiceWindowMessageBatchPushWithOptionsAsync(ServiceWindowMessageBatchPushRequest request, ServiceWindowMessageBatchPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail.ToMap()))
            {
                body["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ServiceWindowMessageBatchPushResponse>(await DoROARequestAsync("ServiceWindowMessageBatchPush", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/messages/batchSend", "json", req, runtime));
        }

        public DeleteCrmFormInstanceResponse DeleteCrmFormInstance(string instanceId, DeleteCrmFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmFormInstanceHeaders headers = new DeleteCrmFormInstanceHeaders();
            return DeleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime);
        }

        public async Task<DeleteCrmFormInstanceResponse> DeleteCrmFormInstanceAsync(string instanceId, DeleteCrmFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmFormInstanceHeaders headers = new DeleteCrmFormInstanceHeaders();
            return await DeleteCrmFormInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteCrmFormInstanceResponse>(DoROARequest("DeleteCrmFormInstance", "crm_1.0", "HTTP", "DELETE", "AK", "/v1.0/crm/formInstances/" + instanceId, "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteCrmFormInstanceResponse>(await DoROARequestAsync("DeleteCrmFormInstance", "crm_1.0", "HTTP", "DELETE", "AK", "/v1.0/crm/formInstances/" + instanceId, "json", req, runtime));
        }

        public BatchSendOfficialAccountOTOMessageResponse BatchSendOfficialAccountOTOMessage(BatchSendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOfficialAccountOTOMessageHeaders headers = new BatchSendOfficialAccountOTOMessageHeaders();
            return BatchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
        }

        public async Task<BatchSendOfficialAccountOTOMessageResponse> BatchSendOfficialAccountOTOMessageAsync(BatchSendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOfficialAccountOTOMessageHeaders headers = new BatchSendOfficialAccountOTOMessageHeaders();
            return await BatchSendOfficialAccountOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        public BatchSendOfficialAccountOTOMessageResponse BatchSendOfficialAccountOTOMessageWithOptions(BatchSendOfficialAccountOTOMessageRequest request, BatchSendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail.ToMap()))
            {
                body["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<BatchSendOfficialAccountOTOMessageResponse>(DoROARequest("BatchSendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/batchSend", "json", req, runtime));
        }

        public async Task<BatchSendOfficialAccountOTOMessageResponse> BatchSendOfficialAccountOTOMessageWithOptionsAsync(BatchSendOfficialAccountOTOMessageRequest request, BatchSendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail.ToMap()))
            {
                body["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<BatchSendOfficialAccountOTOMessageResponse>(await DoROARequestAsync("BatchSendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/batchSend", "json", req, runtime));
        }

        public GetOfficialAccountContactInfoResponse GetOfficialAccountContactInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactInfoHeaders headers = new GetOfficialAccountContactInfoHeaders();
            return GetOfficialAccountContactInfoWithOptions(userId, headers, runtime);
        }

        public async Task<GetOfficialAccountContactInfoResponse> GetOfficialAccountContactInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountContactInfoHeaders headers = new GetOfficialAccountContactInfoHeaders();
            return await GetOfficialAccountContactInfoWithOptionsAsync(userId, headers, runtime);
        }

        public GetOfficialAccountContactInfoResponse GetOfficialAccountContactInfoWithOptions(string userId, GetOfficialAccountContactInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetOfficialAccountContactInfoResponse>(DoROARequest("GetOfficialAccountContactInfo", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/contacts/" + userId, "json", req, runtime));
        }

        public async Task<GetOfficialAccountContactInfoResponse> GetOfficialAccountContactInfoWithOptionsAsync(string userId, GetOfficialAccountContactInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetOfficialAccountContactInfoResponse>(await DoROARequestAsync("GetOfficialAccountContactInfo", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/contacts/" + userId, "json", req, runtime));
        }

        public QueryAllCustomerResponse QueryAllCustomer(QueryAllCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllCustomerHeaders headers = new QueryAllCustomerHeaders();
            return QueryAllCustomerWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllCustomerResponse> QueryAllCustomerAsync(QueryAllCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllCustomerHeaders headers = new QueryAllCustomerHeaders();
            return await QueryAllCustomerWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllCustomerResponse QueryAllCustomerWithOptions(QueryAllCustomerRequest request, QueryAllCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryAllCustomerResponse>(DoROARequest("QueryAllCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customerInstances", "json", req, runtime));
        }

        public async Task<QueryAllCustomerResponse> QueryAllCustomerWithOptionsAsync(QueryAllCustomerRequest request, QueryAllCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryAllCustomerResponse>(await DoROARequestAsync("QueryAllCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customerInstances", "json", req, runtime));
        }

        public SendOfficialAccountOTOMessageResponse SendOfficialAccountOTOMessage(SendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOfficialAccountOTOMessageHeaders headers = new SendOfficialAccountOTOMessageHeaders();
            return SendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
        }

        public async Task<SendOfficialAccountOTOMessageResponse> SendOfficialAccountOTOMessageAsync(SendOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOfficialAccountOTOMessageHeaders headers = new SendOfficialAccountOTOMessageHeaders();
            return await SendOfficialAccountOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        public SendOfficialAccountOTOMessageResponse SendOfficialAccountOTOMessageWithOptions(SendOfficialAccountOTOMessageRequest request, SendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail.ToMap()))
            {
                body["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SendOfficialAccountOTOMessageResponse>(DoROARequest("SendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/send", "json", req, runtime));
        }

        public async Task<SendOfficialAccountOTOMessageResponse> SendOfficialAccountOTOMessageWithOptionsAsync(SendOfficialAccountOTOMessageRequest request, SendOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail.ToMap()))
            {
                body["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SendOfficialAccountOTOMessageResponse>(await DoROARequestAsync("SendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/send", "json", req, runtime));
        }

        public GetOfficialAccountOTOMessageResultResponse GetOfficialAccountOTOMessageResult(GetOfficialAccountOTOMessageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountOTOMessageResultHeaders headers = new GetOfficialAccountOTOMessageResultHeaders();
            return GetOfficialAccountOTOMessageResultWithOptions(request, headers, runtime);
        }

        public async Task<GetOfficialAccountOTOMessageResultResponse> GetOfficialAccountOTOMessageResultAsync(GetOfficialAccountOTOMessageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountOTOMessageResultHeaders headers = new GetOfficialAccountOTOMessageResultHeaders();
            return await GetOfficialAccountOTOMessageResultWithOptionsAsync(request, headers, runtime);
        }

        public GetOfficialAccountOTOMessageResultResponse GetOfficialAccountOTOMessageResultWithOptions(GetOfficialAccountOTOMessageResultRequest request, GetOfficialAccountOTOMessageResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPushId))
            {
                query["openPushId"] = request.OpenPushId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetOfficialAccountOTOMessageResultResponse>(DoROARequest("GetOfficialAccountOTOMessageResult", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/oToMessages/sendResults", "json", req, runtime));
        }

        public async Task<GetOfficialAccountOTOMessageResultResponse> GetOfficialAccountOTOMessageResultWithOptionsAsync(GetOfficialAccountOTOMessageResultRequest request, GetOfficialAccountOTOMessageResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPushId))
            {
                query["openPushId"] = request.OpenPushId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetOfficialAccountOTOMessageResultResponse>(await DoROARequestAsync("GetOfficialAccountOTOMessageResult", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/officialAccounts/oToMessages/sendResults", "json", req, runtime));
        }

        public AddCrmPersonalCustomerResponse AddCrmPersonalCustomer(AddCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCrmPersonalCustomerHeaders headers = new AddCrmPersonalCustomerHeaders();
            return AddCrmPersonalCustomerWithOptions(request, headers, runtime);
        }

        public async Task<AddCrmPersonalCustomerResponse> AddCrmPersonalCustomerAsync(AddCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCrmPersonalCustomerHeaders headers = new AddCrmPersonalCustomerHeaders();
            return await AddCrmPersonalCustomerWithOptionsAsync(request, headers, runtime);
        }

        public AddCrmPersonalCustomerResponse AddCrmPersonalCustomerWithOptions(AddCrmPersonalCustomerRequest request, AddCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNick))
            {
                body["creatorNick"] = request.CreatorNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission.ToMap()))
            {
                body["permission"] = request.Permission;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddCrmPersonalCustomerResponse>(DoROARequest("AddCrmPersonalCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime));
        }

        public async Task<AddCrmPersonalCustomerResponse> AddCrmPersonalCustomerWithOptionsAsync(AddCrmPersonalCustomerRequest request, AddCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUserId))
            {
                body["creatorUserId"] = request.CreatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorNick))
            {
                body["creatorNick"] = request.CreatorNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission.ToMap()))
            {
                body["permission"] = request.Permission;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddCrmPersonalCustomerResponse>(await DoROARequestAsync("AddCrmPersonalCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime));
        }

        public RecallOfficialAccountOTOMessageResponse RecallOfficialAccountOTOMessage(RecallOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallOfficialAccountOTOMessageHeaders headers = new RecallOfficialAccountOTOMessageHeaders();
            return RecallOfficialAccountOTOMessageWithOptions(request, headers, runtime);
        }

        public async Task<RecallOfficialAccountOTOMessageResponse> RecallOfficialAccountOTOMessageAsync(RecallOfficialAccountOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallOfficialAccountOTOMessageHeaders headers = new RecallOfficialAccountOTOMessageHeaders();
            return await RecallOfficialAccountOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        public RecallOfficialAccountOTOMessageResponse RecallOfficialAccountOTOMessageWithOptions(RecallOfficialAccountOTOMessageRequest request, RecallOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RecallOfficialAccountOTOMessageResponse>(DoROARequest("RecallOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/recall", "json", req, runtime));
        }

        public async Task<RecallOfficialAccountOTOMessageResponse> RecallOfficialAccountOTOMessageWithOptionsAsync(RecallOfficialAccountOTOMessageRequest request, RecallOfficialAccountOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RecallOfficialAccountOTOMessageResponse>(await DoROARequestAsync("RecallOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/officialAccounts/oToMessages/recall", "json", req, runtime));
        }

        public DescribeCrmPersonalCustomerObjectMetaResponse DescribeCrmPersonalCustomerObjectMeta()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeCrmPersonalCustomerObjectMetaHeaders headers = new DescribeCrmPersonalCustomerObjectMetaHeaders();
            return DescribeCrmPersonalCustomerObjectMetaWithOptions(headers, runtime);
        }

        public async Task<DescribeCrmPersonalCustomerObjectMetaResponse> DescribeCrmPersonalCustomerObjectMetaAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DescribeCrmPersonalCustomerObjectMetaHeaders headers = new DescribeCrmPersonalCustomerObjectMetaHeaders();
            return await DescribeCrmPersonalCustomerObjectMetaWithOptionsAsync(headers, runtime);
        }

        public DescribeCrmPersonalCustomerObjectMetaResponse DescribeCrmPersonalCustomerObjectMetaWithOptions(DescribeCrmPersonalCustomerObjectMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DescribeCrmPersonalCustomerObjectMetaResponse>(DoROARequest("DescribeCrmPersonalCustomerObjectMeta", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/personalCustomers/objectMeta", "json", req, runtime));
        }

        public async Task<DescribeCrmPersonalCustomerObjectMetaResponse> DescribeCrmPersonalCustomerObjectMetaWithOptionsAsync(DescribeCrmPersonalCustomerObjectMetaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DescribeCrmPersonalCustomerObjectMetaResponse>(await DoROARequestAsync("DescribeCrmPersonalCustomerObjectMeta", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/personalCustomers/objectMeta", "json", req, runtime));
        }

        public DeleteCrmPersonalCustomerResponse DeleteCrmPersonalCustomer(string dataId, DeleteCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmPersonalCustomerHeaders headers = new DeleteCrmPersonalCustomerHeaders();
            return DeleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime);
        }

        public async Task<DeleteCrmPersonalCustomerResponse> DeleteCrmPersonalCustomerAsync(string dataId, DeleteCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCrmPersonalCustomerHeaders headers = new DeleteCrmPersonalCustomerHeaders();
            return await DeleteCrmPersonalCustomerWithOptionsAsync(dataId, request, headers, runtime);
        }

        public DeleteCrmPersonalCustomerResponse DeleteCrmPersonalCustomerWithOptions(string dataId, DeleteCrmPersonalCustomerRequest request, DeleteCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteCrmPersonalCustomerResponse>(DoROARequest("DeleteCrmPersonalCustomer", "crm_1.0", "HTTP", "DELETE", "AK", "/v1.0/crm/personalCustomers/" + dataId, "json", req, runtime));
        }

        public async Task<DeleteCrmPersonalCustomerResponse> DeleteCrmPersonalCustomerWithOptionsAsync(string dataId, DeleteCrmPersonalCustomerRequest request, DeleteCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteCrmPersonalCustomerResponse>(await DoROARequestAsync("DeleteCrmPersonalCustomer", "crm_1.0", "HTTP", "DELETE", "AK", "/v1.0/crm/personalCustomers/" + dataId, "json", req, runtime));
        }

        public UpdateCrmPersonalCustomerResponse UpdateCrmPersonalCustomer(UpdateCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCrmPersonalCustomerHeaders headers = new UpdateCrmPersonalCustomerHeaders();
            return UpdateCrmPersonalCustomerWithOptions(request, headers, runtime);
        }

        public async Task<UpdateCrmPersonalCustomerResponse> UpdateCrmPersonalCustomerAsync(UpdateCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCrmPersonalCustomerHeaders headers = new UpdateCrmPersonalCustomerHeaders();
            return await UpdateCrmPersonalCustomerWithOptionsAsync(request, headers, runtime);
        }

        public UpdateCrmPersonalCustomerResponse UpdateCrmPersonalCustomerWithOptions(UpdateCrmPersonalCustomerRequest request, UpdateCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierUserId))
            {
                body["modifierUserId"] = request.ModifierUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierNick))
            {
                body["modifierNick"] = request.ModifierNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission.ToMap()))
            {
                body["permission"] = request.Permission;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateCrmPersonalCustomerResponse>(DoROARequest("UpdateCrmPersonalCustomer", "crm_1.0", "HTTP", "PUT", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime));
        }

        public async Task<UpdateCrmPersonalCustomerResponse> UpdateCrmPersonalCustomerWithOptionsAsync(UpdateCrmPersonalCustomerRequest request, UpdateCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierUserId))
            {
                body["modifierUserId"] = request.ModifierUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifierNick))
            {
                body["modifierNick"] = request.ModifierNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission.ToMap()))
            {
                body["permission"] = request.Permission;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateCrmPersonalCustomerResponse>(await DoROARequestAsync("UpdateCrmPersonalCustomer", "crm_1.0", "HTTP", "PUT", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime));
        }

        public QueryCrmPersonalCustomerResponse QueryCrmPersonalCustomer(QueryCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmPersonalCustomerHeaders headers = new QueryCrmPersonalCustomerHeaders();
            return QueryCrmPersonalCustomerWithOptions(request, headers, runtime);
        }

        public async Task<QueryCrmPersonalCustomerResponse> QueryCrmPersonalCustomerAsync(QueryCrmPersonalCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmPersonalCustomerHeaders headers = new QueryCrmPersonalCustomerHeaders();
            return await QueryCrmPersonalCustomerWithOptionsAsync(request, headers, runtime);
        }

        public QueryCrmPersonalCustomerResponse QueryCrmPersonalCustomerWithOptions(QueryCrmPersonalCustomerRequest request, QueryCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCrmPersonalCustomerResponse>(DoROARequest("QueryCrmPersonalCustomer", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime));
        }

        public async Task<QueryCrmPersonalCustomerResponse> QueryCrmPersonalCustomerWithOptionsAsync(QueryCrmPersonalCustomerRequest request, QueryCrmPersonalCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDsl))
            {
                query["queryDsl"] = request.QueryDsl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCrmPersonalCustomerResponse>(await DoROARequestAsync("QueryCrmPersonalCustomer", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/personalCustomers", "json", req, runtime));
        }

        public ListCrmPersonalCustomersResponse ListCrmPersonalCustomers(ListCrmPersonalCustomersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCrmPersonalCustomersHeaders headers = new ListCrmPersonalCustomersHeaders();
            return ListCrmPersonalCustomersWithOptions(request, headers, runtime);
        }

        public async Task<ListCrmPersonalCustomersResponse> ListCrmPersonalCustomersAsync(ListCrmPersonalCustomersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCrmPersonalCustomersHeaders headers = new ListCrmPersonalCustomersHeaders();
            return await ListCrmPersonalCustomersWithOptionsAsync(request, headers, runtime);
        }

        public ListCrmPersonalCustomersResponse ListCrmPersonalCustomersWithOptions(ListCrmPersonalCustomersRequest request, ListCrmPersonalCustomersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            return TeaModel.ToObject<ListCrmPersonalCustomersResponse>(DoROARequest("ListCrmPersonalCustomers", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/personalCustomers/batchQuery", "json", req, runtime));
        }

        public async Task<ListCrmPersonalCustomersResponse> ListCrmPersonalCustomersWithOptionsAsync(ListCrmPersonalCustomersRequest request, ListCrmPersonalCustomersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentOperatorUserId))
            {
                query["currentOperatorUserId"] = request.CurrentOperatorUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            return TeaModel.ToObject<ListCrmPersonalCustomersResponse>(await DoROARequestAsync("ListCrmPersonalCustomers", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/personalCustomers/batchQuery", "json", req, runtime));
        }

        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return CreateCustomerWithOptions(request, headers, runtime);
        }

        public async Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return await CreateCustomerWithOptionsAsync(request, headers, runtime);
        }

        public CreateCustomerResponse CreateCustomerWithOptions(CreateCustomerRequest request, CreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contacts))
            {
                body["contacts"] = request.Contacts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission.ToMap()))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveOption.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomerResponse>(DoROARequest("CreateCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customers", "json", req, runtime));
        }

        public async Task<CreateCustomerResponse> CreateCustomerWithOptionsAsync(CreateCustomerRequest request, CreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contacts))
            {
                body["contacts"] = request.Contacts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission.ToMap()))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveOption.ToMap()))
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomerResponse>(await DoROARequestAsync("CreateCustomer", "crm_1.0", "HTTP", "POST", "AK", "/v1.0/crm/customers", "json", req, runtime));
        }

        public QueryAllTracksResponse QueryAllTracks(QueryAllTracksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllTracksHeaders headers = new QueryAllTracksHeaders();
            return QueryAllTracksWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllTracksResponse> QueryAllTracksAsync(QueryAllTracksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllTracksHeaders headers = new QueryAllTracksHeaders();
            return await QueryAllTracksWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllTracksResponse QueryAllTracksWithOptions(QueryAllTracksRequest request, QueryAllTracksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAllTracksResponse>(DoROARequest("QueryAllTracks", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/customers/tracks", "json", req, runtime));
        }

        public async Task<QueryAllTracksResponse> QueryAllTracksWithOptionsAsync(QueryAllTracksRequest request, QueryAllTracksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAllTracksResponse>(await DoROARequestAsync("QueryAllTracks", "crm_1.0", "HTTP", "GET", "AK", "/v1.0/crm/customers/tracks", "json", req, runtime));
        }

    }
}
