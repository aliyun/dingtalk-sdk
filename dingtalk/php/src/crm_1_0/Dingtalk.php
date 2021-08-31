<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param GetOfficialAccountContactsRequest $request
     *
     * @return GetOfficialAccountContactsResponse
     */
    public function getOfficialAccountContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountContactsHeaders([]);

        return $this->getOfficialAccountContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOfficialAccountContactsRequest $request
     * @param GetOfficialAccountContactsHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetOfficialAccountContactsResponse
     */
    public function getOfficialAccountContactsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetOfficialAccountContactsResponse::fromMap($this->doROARequest('GetOfficialAccountContacts', 'crm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/crm/officialAccounts/contacts', 'json', $req, $runtime));
    }

    /**
     * @param ServiceWindowMessageBatchPushRequest $request
     *
     * @return ServiceWindowMessageBatchPushResponse
     */
    public function serviceWindowMessageBatchPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ServiceWindowMessageBatchPushHeaders([]);

        return $this->serviceWindowMessageBatchPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ServiceWindowMessageBatchPushRequest $request
     * @param ServiceWindowMessageBatchPushHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return ServiceWindowMessageBatchPushResponse
     */
    public function serviceWindowMessageBatchPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            @$body['detail'] = $request->detail;
        }
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ServiceWindowMessageBatchPushResponse::fromMap($this->doROARequest('ServiceWindowMessageBatchPush', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/messages/batchSend', 'json', $req, $runtime));
    }

    /**
     * @param string                       $instanceId
     * @param DeleteCrmFormInstanceRequest $request
     *
     * @return DeleteCrmFormInstanceResponse
     */
    public function deleteCrmFormInstance($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmFormInstanceHeaders([]);

        return $this->deleteCrmFormInstanceWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $instanceId
     * @param DeleteCrmFormInstanceRequest $request
     * @param DeleteCrmFormInstanceHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DeleteCrmFormInstanceResponse
     */
    public function deleteCrmFormInstanceWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            @$query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteCrmFormInstanceResponse::fromMap($this->doROARequest('DeleteCrmFormInstance', 'crm_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/crm/formInstances/' . $instanceId . '', 'json', $req, $runtime));
    }

    /**
     * @param BatchSendOfficialAccountOTOMessageRequest $request
     *
     * @return BatchSendOfficialAccountOTOMessageResponse
     */
    public function batchSendOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSendOfficialAccountOTOMessageHeaders([]);

        return $this->batchSendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchSendOfficialAccountOTOMessageRequest $request
     * @param BatchSendOfficialAccountOTOMessageHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return BatchSendOfficialAccountOTOMessageResponse
     */
    public function batchSendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            @$body['detail'] = $request->detail;
        }
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->accountId)) {
            @$body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchSendOfficialAccountOTOMessageResponse::fromMap($this->doROARequest('BatchSendOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/officialAccounts/oToMessages/batchSend', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return GetOfficialAccountContactInfoResponse
     */
    public function getOfficialAccountContactInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountContactInfoHeaders([]);

        return $this->getOfficialAccountContactInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                               $userId
     * @param GetOfficialAccountContactInfoHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return GetOfficialAccountContactInfoResponse
     */
    public function getOfficialAccountContactInfoWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetOfficialAccountContactInfoResponse::fromMap($this->doROARequest('GetOfficialAccountContactInfo', 'crm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/crm/officialAccounts/contacts/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllCustomerRequest $request
     *
     * @return QueryAllCustomerResponse
     */
    public function queryAllCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllCustomerHeaders([]);

        return $this->queryAllCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllCustomerRequest $request
     * @param QueryAllCustomerHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryAllCustomerResponse
     */
    public function queryAllCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            @$body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->objectType)) {
            @$body['objectType'] = $request->objectType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryAllCustomerResponse::fromMap($this->doROARequest('QueryAllCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/customerInstances', 'json', $req, $runtime));
    }

    /**
     * @param SendOfficialAccountOTOMessageRequest $request
     *
     * @return SendOfficialAccountOTOMessageResponse
     */
    public function sendOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendOfficialAccountOTOMessageHeaders([]);

        return $this->sendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendOfficialAccountOTOMessageRequest $request
     * @param SendOfficialAccountOTOMessageHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return SendOfficialAccountOTOMessageResponse
     */
    public function sendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            @$body['detail'] = $request->detail;
        }
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->accountId)) {
            @$body['accountId'] = $request->accountId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendOfficialAccountOTOMessageResponse::fromMap($this->doROARequest('SendOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/officialAccounts/oToMessages/send', 'json', $req, $runtime));
    }

    /**
     * @param GetOfficialAccountOTOMessageResultRequest $request
     *
     * @return GetOfficialAccountOTOMessageResultResponse
     */
    public function getOfficialAccountOTOMessageResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountOTOMessageResultHeaders([]);

        return $this->getOfficialAccountOTOMessageResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOfficialAccountOTOMessageResultRequest $request
     * @param GetOfficialAccountOTOMessageResultHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return GetOfficialAccountOTOMessageResultResponse
     */
    public function getOfficialAccountOTOMessageResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openPushId)) {
            @$query['openPushId'] = $request->openPushId;
        }
        if (!Utils::isUnset($request->accountId)) {
            @$query['accountId'] = $request->accountId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetOfficialAccountOTOMessageResultResponse::fromMap($this->doROARequest('GetOfficialAccountOTOMessageResult', 'crm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/crm/officialAccounts/oToMessages/sendResults', 'json', $req, $runtime));
    }

    /**
     * @param AddCrmPersonalCustomerRequest $request
     *
     * @return AddCrmPersonalCustomerResponse
     */
    public function addCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCrmPersonalCustomerHeaders([]);

        return $this->addCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddCrmPersonalCustomerRequest $request
     * @param AddCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return AddCrmPersonalCustomerResponse
     */
    public function addCrmPersonalCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUserId)) {
            @$body['creatorUserId'] = $request->creatorUserId;
        }
        if (!Utils::isUnset($request->creatorNick)) {
            @$body['creatorNick'] = $request->creatorNick;
        }
        if (!Utils::isUnset($request->data)) {
            @$body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->extendData)) {
            @$body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->permission)) {
            @$body['permission'] = $request->permission;
        }
        if (!Utils::isUnset($request->skipDuplicateCheck)) {
            @$body['skipDuplicateCheck'] = $request->skipDuplicateCheck;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddCrmPersonalCustomerResponse::fromMap($this->doROARequest('AddCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/personalCustomers', 'json', $req, $runtime));
    }

    /**
     * @param RecallOfficialAccountOTOMessageRequest $request
     *
     * @return RecallOfficialAccountOTOMessageResponse
     */
    public function recallOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallOfficialAccountOTOMessageHeaders([]);

        return $this->recallOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RecallOfficialAccountOTOMessageRequest $request
     * @param RecallOfficialAccountOTOMessageHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return RecallOfficialAccountOTOMessageResponse
     */
    public function recallOfficialAccountOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->accountId)) {
            @$body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->openPushId)) {
            @$body['openPushId'] = $request->openPushId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RecallOfficialAccountOTOMessageResponse::fromMap($this->doROARequest('RecallOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/officialAccounts/oToMessages/recall', 'json', $req, $runtime));
    }

    /**
     * @return DescribeCrmPersonalCustomerObjectMetaResponse
     */
    public function describeCrmPersonalCustomerObjectMeta()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DescribeCrmPersonalCustomerObjectMetaHeaders([]);

        return $this->describeCrmPersonalCustomerObjectMetaWithOptions($headers, $runtime);
    }

    /**
     * @param DescribeCrmPersonalCustomerObjectMetaHeaders $headers
     * @param RuntimeOptions                               $runtime
     *
     * @return DescribeCrmPersonalCustomerObjectMetaResponse
     */
    public function describeCrmPersonalCustomerObjectMetaWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DescribeCrmPersonalCustomerObjectMetaResponse::fromMap($this->doROARequest('DescribeCrmPersonalCustomerObjectMeta', 'crm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/crm/personalCustomers/objectMeta', 'json', $req, $runtime));
    }

    /**
     * @param string                           $dataId
     * @param DeleteCrmPersonalCustomerRequest $request
     *
     * @return DeleteCrmPersonalCustomerResponse
     */
    public function deleteCrmPersonalCustomer($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmPersonalCustomerHeaders([]);

        return $this->deleteCrmPersonalCustomerWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $dataId
     * @param DeleteCrmPersonalCustomerRequest $request
     * @param DeleteCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return DeleteCrmPersonalCustomerResponse
     */
    public function deleteCrmPersonalCustomerWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            @$query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteCrmPersonalCustomerResponse::fromMap($this->doROARequest('DeleteCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/crm/personalCustomers/' . $dataId . '', 'json', $req, $runtime));
    }

    /**
     * @param UpdateCrmPersonalCustomerRequest $request
     *
     * @return UpdateCrmPersonalCustomerResponse
     */
    public function updateCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCrmPersonalCustomerHeaders([]);

        return $this->updateCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateCrmPersonalCustomerRequest $request
     * @param UpdateCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateCrmPersonalCustomerResponse
     */
    public function updateCrmPersonalCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->modifierUserId)) {
            @$body['modifierUserId'] = $request->modifierUserId;
        }
        if (!Utils::isUnset($request->modifierNick)) {
            @$body['modifierNick'] = $request->modifierNick;
        }
        if (!Utils::isUnset($request->data)) {
            @$body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->extendData)) {
            @$body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->permission)) {
            @$body['permission'] = $request->permission;
        }
        if (!Utils::isUnset($request->skipDuplicateCheck)) {
            @$body['skipDuplicateCheck'] = $request->skipDuplicateCheck;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateCrmPersonalCustomerResponse::fromMap($this->doROARequest('UpdateCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/crm/personalCustomers', 'json', $req, $runtime));
    }

    /**
     * @param QueryCrmPersonalCustomerRequest $request
     *
     * @return QueryCrmPersonalCustomerResponse
     */
    public function queryCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCrmPersonalCustomerHeaders([]);

        return $this->queryCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCrmPersonalCustomerRequest $request
     * @param QueryCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryCrmPersonalCustomerResponse
     */
    public function queryCrmPersonalCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            @$query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->queryDsl)) {
            @$query['queryDsl'] = $request->queryDsl;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryCrmPersonalCustomerResponse::fromMap($this->doROARequest('QueryCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/crm/personalCustomers', 'json', $req, $runtime));
    }

    /**
     * @param ListCrmPersonalCustomersRequest $request
     *
     * @return ListCrmPersonalCustomersResponse
     */
    public function listCrmPersonalCustomers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCrmPersonalCustomersHeaders([]);

        return $this->listCrmPersonalCustomersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListCrmPersonalCustomersRequest $request
     * @param ListCrmPersonalCustomersHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return ListCrmPersonalCustomersResponse
     */
    public function listCrmPersonalCustomersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            @$query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => $request->body,
        ]);

        return ListCrmPersonalCustomersResponse::fromMap($this->doROARequest('ListCrmPersonalCustomers', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/personalCustomers/batchQuery', 'json', $req, $runtime));
    }

    /**
     * @param CreateCustomerRequest $request
     *
     * @return CreateCustomerResponse
     */
    public function createCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomerHeaders([]);

        return $this->createCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCustomerRequest $request
     * @param CreateCustomerHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateCustomerResponse
     */
    public function createCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->objectType)) {
            @$body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->creatorUserId)) {
            @$body['creatorUserId'] = $request->creatorUserId;
        }
        if (!Utils::isUnset($request->data)) {
            @$body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->extendData)) {
            @$body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->contacts)) {
            @$body['contacts'] = $request->contacts;
        }
        if (!Utils::isUnset($request->permission)) {
            @$body['permission'] = $request->permission;
        }
        if (!Utils::isUnset($request->saveOption)) {
            @$body['saveOption'] = $request->saveOption;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateCustomerResponse::fromMap($this->doROARequest('CreateCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/customers', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllTracksRequest $request
     *
     * @return QueryAllTracksResponse
     */
    public function queryAllTracks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllTracksHeaders([]);

        return $this->queryAllTracksWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllTracksRequest $request
     * @param QueryAllTracksHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryAllTracksResponse
     */
    public function queryAllTracksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->order)) {
            @$query['order'] = $request->order;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllTracksResponse::fromMap($this->doROARequest('QueryAllTracks', 'crm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/crm/customers/tracks', 'json', $req, $runtime));
    }
}
