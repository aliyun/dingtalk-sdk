<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushResponse;
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
}
