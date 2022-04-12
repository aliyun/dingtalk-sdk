<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\AlignObjectiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\AlignObjectiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\AlignObjectiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateKeyResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateKeyResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateKeyResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateObjectiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateObjectiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateObjectiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeleteKeyResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeleteKeyResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeleteKeyResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeleteObjectiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeleteObjectiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeleteObjectiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeletePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeletePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\DeletePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPeriodListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPeriodListResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UnAlignObjectiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UnAlignObjectiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UnAlignObjectiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfContentResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfScoreHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfScoreRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfScoreResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfWeightHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfWeightRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfWeightResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateObjectiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateObjectiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateObjectiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdatePrivacyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdatePrivacyRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdatePrivacyResponse;
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
     * @param string                $objectiveId
     * @param AlignObjectiveRequest $request
     *
     * @return AlignObjectiveResponse
     */
    public function alignObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AlignObjectiveHeaders([]);

        return $this->alignObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @param string                $objectiveId
     * @param AlignObjectiveRequest $request
     * @param AlignObjectiveHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return AlignObjectiveResponse
     */
    public function alignObjectiveWithOptions($objectiveId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $objectiveId = OpenApiUtilClient::getEncodeParam($objectiveId);
        $query       = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->periodId)) {
            @$body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->targetId)) {
            @$body['targetId'] = $request->targetId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AlignObjectiveResponse::fromMap($this->doROARequest('AlignObjective', 'okr_1.0', 'HTTP', 'POST', 'AK', '/v1.0/okr/objectives/' . $objectiveId . '/alignments', 'json', $req, $runtime));
    }

    /**
     * @param BatchAddPermissionRequest $request
     *
     * @return BatchAddPermissionResponse
     */
    public function batchAddPermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddPermissionHeaders([]);

        return $this->batchAddPermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchAddPermissionRequest $request
     * @param BatchAddPermissionHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return BatchAddPermissionResponse
     */
    public function batchAddPermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->list_)) {
            @$body['list_'] = $request->list_;
        }
        if (!Utils::isUnset($request->targetId)) {
            @$body['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            @$body['targetType'] = $request->targetType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchAddPermissionResponse::fromMap($this->doROARequest('BatchAddPermission', 'okr_1.0', 'HTTP', 'POST', 'AK', '/v1.0/okr/permissions/batch', 'json', $req, $runtime));
    }

    /**
     * @param BatchQueryObjectiveRequest $request
     *
     * @return BatchQueryObjectiveResponse
     */
    public function batchQueryObjective($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryObjectiveHeaders([]);

        return $this->batchQueryObjectiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchQueryObjectiveRequest $request
     * @param BatchQueryObjectiveHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchQueryObjectiveResponse
     */
    public function batchQueryObjectiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->objectiveIds)) {
            @$body['objectiveIds'] = $request->objectiveIds;
        }
        if (!Utils::isUnset($request->periodId)) {
            @$body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->withAlign)) {
            @$body['withAlign'] = $request->withAlign;
        }
        if (!Utils::isUnset($request->withKr)) {
            @$body['withKr'] = $request->withKr;
        }
        if (!Utils::isUnset($request->withProgress)) {
            @$body['withProgress'] = $request->withProgress;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchQueryObjectiveResponse::fromMap($this->doROARequest('BatchQueryObjective', 'okr_1.0', 'HTTP', 'POST', 'AK', '/v1.0/okr/objectives/query', 'json', $req, $runtime));
    }

    /**
     * @param BatchQueryUserRequest $request
     *
     * @return BatchQueryUserResponse
     */
    public function batchQueryUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryUserHeaders([]);

        return $this->batchQueryUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchQueryUserRequest $request
     * @param BatchQueryUserHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return BatchQueryUserResponse
     */
    public function batchQueryUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->okrUserIds)) {
            @$body['okrUserIds'] = $request->okrUserIds;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchQueryUserResponse::fromMap($this->doROARequest('BatchQueryUser', 'okr_1.0', 'HTTP', 'POST', 'AK', '/v1.0/okr/users/query', 'json', $req, $runtime));
    }

    /**
     * @param CreateKeyResultRequest $request
     *
     * @return CreateKeyResultResponse
     */
    public function createKeyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateKeyResultHeaders([]);

        return $this->createKeyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateKeyResultRequest $request
     * @param CreateKeyResultHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateKeyResultResponse
     */
    public function createKeyResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->objectiveId)) {
            @$body['objectiveId'] = $request->objectiveId;
        }
        if (!Utils::isUnset($request->periodId)) {
            @$body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->prevPosition)) {
            @$body['prevPosition'] = $request->prevPosition;
        }
        if (!Utils::isUnset($request->weight)) {
            @$body['weight'] = $request->weight;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateKeyResultResponse::fromMap($this->doROARequest('CreateKeyResult', 'okr_1.0', 'HTTP', 'POST', 'AK', '/v1.0/okr/keyResults', 'json', $req, $runtime));
    }

    /**
     * @param CreateObjectiveRequest $request
     *
     * @return CreateObjectiveResponse
     */
    public function createObjective($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateObjectiveHeaders([]);

        return $this->createObjectiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateObjectiveRequest $request
     * @param CreateObjectiveHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateObjectiveResponse
     */
    public function createObjectiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->periodId)) {
            @$body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->prevPosition)) {
            @$body['prevPosition'] = $request->prevPosition;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateObjectiveResponse::fromMap($this->doROARequest('CreateObjective', 'okr_1.0', 'HTTP', 'POST', 'AK', '/v1.0/okr/objectives', 'json', $req, $runtime));
    }

    /**
     * @param DeleteKeyResultRequest $request
     *
     * @return DeleteKeyResultResponse
     */
    public function deleteKeyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteKeyResultHeaders([]);

        return $this->deleteKeyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteKeyResultRequest $request
     * @param DeleteKeyResultHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DeleteKeyResultResponse
     */
    public function deleteKeyResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->krId)) {
            @$query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteKeyResultResponse::fromMap($this->doROARequest('DeleteKeyResult', 'okr_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/okr/keyResults', 'json', $req, $runtime));
    }

    /**
     * @param string                 $objectiveId
     * @param DeleteObjectiveRequest $request
     *
     * @return DeleteObjectiveResponse
     */
    public function deleteObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteObjectiveHeaders([]);

        return $this->deleteObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $objectiveId
     * @param DeleteObjectiveRequest $request
     * @param DeleteObjectiveHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DeleteObjectiveResponse
     */
    public function deleteObjectiveWithOptions($objectiveId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $objectiveId = OpenApiUtilClient::getEncodeParam($objectiveId);
        $query       = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteObjectiveResponse::fromMap($this->doROARequest('DeleteObjective', 'okr_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/okr/objectives/' . $objectiveId . '', 'json', $req, $runtime));
    }

    /**
     * @param DeletePermissionRequest $request
     *
     * @return DeletePermissionResponse
     */
    public function deletePermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePermissionHeaders([]);

        return $this->deletePermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeletePermissionRequest $request
     * @param DeletePermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeletePermissionResponse
     */
    public function deletePermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->id)) {
            @$query['id'] = $request->id;
        }
        if (!Utils::isUnset($request->policyType)) {
            @$query['policyType'] = $request->policyType;
        }
        if (!Utils::isUnset($request->targetId)) {
            @$query['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            @$query['targetType'] = $request->targetType;
        }
        if (!Utils::isUnset($request->type)) {
            @$query['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeletePermissionResponse::fromMap($this->doROARequest('DeletePermission', 'okr_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/okr/permissions/delete', 'json', $req, $runtime));
    }

    /**
     * @return GetPeriodListResponse
     */
    public function getPeriodList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPeriodListHeaders([]);

        return $this->getPeriodListWithOptions($headers, $runtime);
    }

    /**
     * @param GetPeriodListHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetPeriodListResponse
     */
    public function getPeriodListWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetPeriodListResponse::fromMap($this->doROARequest('GetPeriodList', 'okr_1.0', 'HTTP', 'GET', 'AK', '/v1.0/okr/periods', 'json', $req, $runtime));
    }

    /**
     * @param GetPermissionRequest $request
     *
     * @return GetPermissionResponse
     */
    public function getPermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPermissionHeaders([]);

        return $this->getPermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPermissionRequest $request
     * @param GetPermissionHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetPermissionResponse
     */
    public function getPermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->targetId)) {
            @$query['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            @$query['targetType'] = $request->targetType;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->withKr)) {
            @$query['withKr'] = $request->withKr;
        }
        if (!Utils::isUnset($request->withObjective)) {
            @$query['withObjective'] = $request->withObjective;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPermissionResponse::fromMap($this->doROARequest('GetPermission', 'okr_1.0', 'HTTP', 'GET', 'AK', '/v1.0/okr/permissions', 'json', $req, $runtime));
    }

    /**
     * @param GetUserOkrRequest $request
     *
     * @return GetUserOkrResponse
     */
    public function getUserOkr($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserOkrHeaders([]);

        return $this->getUserOkrWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserOkrRequest $request
     * @param GetUserOkrHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetUserOkrResponse
     */
    public function getUserOkrWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->periodId)) {
            @$query['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetUserOkrResponse::fromMap($this->doROARequest('GetUserOkr', 'okr_1.0', 'HTTP', 'GET', 'AK', '/v1.0/okr/users/okrs', 'json', $req, $runtime));
    }

    /**
     * @param string                  $objectiveId
     * @param UnAlignObjectiveRequest $request
     *
     * @return UnAlignObjectiveResponse
     */
    public function unAlignObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnAlignObjectiveHeaders([]);

        return $this->unAlignObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $objectiveId
     * @param UnAlignObjectiveRequest $request
     * @param UnAlignObjectiveHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UnAlignObjectiveResponse
     */
    public function unAlignObjectiveWithOptions($objectiveId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $objectiveId = OpenApiUtilClient::getEncodeParam($objectiveId);
        $query       = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->periodId)) {
            @$body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->targetId)) {
            @$body['targetId'] = $request->targetId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UnAlignObjectiveResponse::fromMap($this->doROARequest('UnAlignObjective', 'okr_1.0', 'HTTP', 'POST', 'AK', '/v1.0/okr/objectives/' . $objectiveId . '/alignments/cancel', 'json', $req, $runtime));
    }

    /**
     * @param UpdateKROfContentRequest $request
     *
     * @return UpdateKROfContentResponse
     */
    public function updateKROfContent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateKROfContentHeaders([]);

        return $this->updateKROfContentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateKROfContentRequest $request
     * @param UpdateKROfContentHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateKROfContentResponse
     */
    public function updateKROfContentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->krId)) {
            @$query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->updateQuoteList)) {
            @$body['updateQuoteList'] = $request->updateQuoteList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateKROfContentResponse::fromMap($this->doROARequest('UpdateKROfContent', 'okr_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/okr/keyResults/contents', 'json', $req, $runtime));
    }

    /**
     * @param UpdateKROfScoreRequest $request
     *
     * @return UpdateKROfScoreResponse
     */
    public function updateKROfScore($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateKROfScoreHeaders([]);

        return $this->updateKROfScoreWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateKROfScoreRequest $request
     * @param UpdateKROfScoreHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateKROfScoreResponse
     */
    public function updateKROfScoreWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->krId)) {
            @$query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->score)) {
            @$body['score'] = $request->score;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateKROfScoreResponse::fromMap($this->doROARequest('UpdateKROfScore', 'okr_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/okr/keyResults/scores', 'json', $req, $runtime));
    }

    /**
     * @param UpdateKROfWeightRequest $request
     *
     * @return UpdateKROfWeightResponse
     */
    public function updateKROfWeight($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateKROfWeightHeaders([]);

        return $this->updateKROfWeightWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateKROfWeightRequest $request
     * @param UpdateKROfWeightHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UpdateKROfWeightResponse
     */
    public function updateKROfWeightWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->krId)) {
            @$query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->weight)) {
            @$body['weight'] = $request->weight;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateKROfWeightResponse::fromMap($this->doROARequest('UpdateKROfWeight', 'okr_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/okr/keyResults/weights', 'json', $req, $runtime));
    }

    /**
     * @param string                 $objectiveId
     * @param UpdateObjectiveRequest $request
     *
     * @return UpdateObjectiveResponse
     */
    public function updateObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateObjectiveHeaders([]);

        return $this->updateObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $objectiveId
     * @param UpdateObjectiveRequest $request
     * @param UpdateObjectiveHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateObjectiveResponse
     */
    public function updateObjectiveWithOptions($objectiveId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $objectiveId = OpenApiUtilClient::getEncodeParam($objectiveId);
        $query       = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateObjectiveResponse::fromMap($this->doROARequest('UpdateObjective', 'okr_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/okr/objectives/' . $objectiveId . '', 'json', $req, $runtime));
    }

    /**
     * @param UpdatePrivacyRequest $request
     *
     * @return UpdatePrivacyResponse
     */
    public function updatePrivacy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePrivacyHeaders([]);

        return $this->updatePrivacyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdatePrivacyRequest $request
     * @param UpdatePrivacyHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return UpdatePrivacyResponse
     */
    public function updatePrivacyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->privacy)) {
            @$body['privacy'] = $request->privacy;
        }
        if (!Utils::isUnset($request->targetId)) {
            @$body['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            @$body['targetType'] = $request->targetType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdatePrivacyResponse::fromMap($this->doROARequest('UpdatePrivacy', 'okr_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/okr/permissions/privacies', 'json', $req, $runtime));
    }
}
