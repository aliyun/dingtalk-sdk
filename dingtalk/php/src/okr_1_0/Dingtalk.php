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
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrObjectivesBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrObjectivesBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrObjectivesBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrObjectivesByUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrObjectivesByUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrObjectivesByUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrPeriodsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrPeriodsRequest;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\OkrPeriodsResponse;
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
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->periodId)) {
            $body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->targetId)) {
            $body['targetId'] = $request->targetId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AlignObjective',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/objectives/' . $objectiveId . '/alignments',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AlignObjectiveResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->list_)) {
            $body['list'] = $request->list_;
        }
        if (!Utils::isUnset($request->targetId)) {
            $body['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            $body['targetType'] = $request->targetType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchAddPermission',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/permissions/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchAddPermissionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->objectiveIds)) {
            $body['objectiveIds'] = $request->objectiveIds;
        }
        if (!Utils::isUnset($request->periodId)) {
            $body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->withAlign)) {
            $body['withAlign'] = $request->withAlign;
        }
        if (!Utils::isUnset($request->withKr)) {
            $body['withKr'] = $request->withKr;
        }
        if (!Utils::isUnset($request->withProgress)) {
            $body['withProgress'] = $request->withProgress;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchQueryObjective',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/objectives/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchQueryObjectiveResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['okrUserIds'] = $request->okrUserIds;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchQueryUser',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/users/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchQueryUserResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->objectiveId)) {
            $body['objectiveId'] = $request->objectiveId;
        }
        if (!Utils::isUnset($request->periodId)) {
            $body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->prevPosition)) {
            $body['prevPosition'] = $request->prevPosition;
        }
        if (!Utils::isUnset($request->weight)) {
            $body['weight'] = $request->weight;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateKeyResult',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/keyResults',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateKeyResultResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->periodId)) {
            $body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->prevPosition)) {
            $body['prevPosition'] = $request->prevPosition;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateObjective',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/objectives',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateObjectiveResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteKeyResult',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/keyResults',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteKeyResultResponse::fromMap($this->execute($params, $req, $runtime));
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
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteObjective',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/objectives/' . $objectiveId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteObjectiveResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['id'] = $request->id;
        }
        if (!Utils::isUnset($request->policyType)) {
            $query['policyType'] = $request->policyType;
        }
        if (!Utils::isUnset($request->targetId)) {
            $query['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            $query['targetType'] = $request->targetType;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeletePermission',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/permissions/delete',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeletePermissionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetPeriodList',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/periods',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPeriodListResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            $query['targetType'] = $request->targetType;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->withKr)) {
            $query['withKr'] = $request->withKr;
        }
        if (!Utils::isUnset($request->withObjective)) {
            $query['withObjective'] = $request->withObjective;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPermission',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/permissions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPermissionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->periodId)) {
            $query['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetUserOkr',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/users/okrs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserOkrResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param OkrObjectivesBatchRequest $request
     * @param OkrObjectivesBatchHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return OkrObjectivesBatchResponse
     */
    public function okrObjectivesBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->goodsCode)) {
            $body['goodsCode'] = $request->goodsCode;
        }
        if (!Utils::isUnset($request->objectiveIds)) {
            $body['objectiveIds'] = $request->objectiveIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'OkrObjectivesBatch',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/pro/objectives/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OkrObjectivesBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param OkrObjectivesBatchRequest $request
     *
     * @return OkrObjectivesBatchResponse
     */
    public function okrObjectivesBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OkrObjectivesBatchHeaders([]);

        return $this->okrObjectivesBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $dingUserId
     * @param OkrObjectivesByUserRequest $request
     * @param OkrObjectivesByUserHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return OkrObjectivesByUserResponse
     */
    public function okrObjectivesByUserWithOptions($dingUserId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->goodsCode)) {
            $query['goodsCode'] = $request->goodsCode;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'OkrObjectivesByUser',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/pro/users/' . $dingUserId . '/objectives',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OkrObjectivesByUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                     $dingUserId
     * @param OkrObjectivesByUserRequest $request
     *
     * @return OkrObjectivesByUserResponse
     */
    public function okrObjectivesByUser($dingUserId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OkrObjectivesByUserHeaders([]);

        return $this->okrObjectivesByUserWithOptions($dingUserId, $request, $headers, $runtime);
    }

    /**
     * @param OkrPeriodsRequest $request
     * @param OkrPeriodsHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return OkrPeriodsResponse
     */
    public function okrPeriodsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->goodsCode)) {
            $query['goodsCode'] = $request->goodsCode;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'OkrPeriods',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/pro/periods',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OkrPeriodsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param OkrPeriodsRequest $request
     *
     * @return OkrPeriodsResponse
     */
    public function okrPeriods($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OkrPeriodsHeaders([]);

        return $this->okrPeriodsWithOptions($request, $headers, $runtime);
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
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->periodId)) {
            $body['periodId'] = $request->periodId;
        }
        if (!Utils::isUnset($request->targetId)) {
            $body['targetId'] = $request->targetId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UnAlignObjective',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/objectives/' . $objectiveId . '/alignments/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnAlignObjectiveResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->updateQuoteList)) {
            $body['updateQuoteList'] = $request->updateQuoteList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateKROfContent',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/keyResults/contents',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateKROfContentResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->score)) {
            $body['score'] = $request->score;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateKROfScore',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/keyResults/scores',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateKROfScoreResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['krId'] = $request->krId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->weight)) {
            $body['weight'] = $request->weight;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateKROfWeight',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/keyResults/weights',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateKROfWeightResponse::fromMap($this->execute($params, $req, $runtime));
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
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateObjective',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/objectives/' . $objectiveId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateObjectiveResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->privacy)) {
            $body['privacy'] = $request->privacy;
        }
        if (!Utils::isUnset($request->targetId)) {
            $body['targetId'] = $request->targetId;
        }
        if (!Utils::isUnset($request->targetType)) {
            $body['targetType'] = $request->targetType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdatePrivacy',
            'version'     => 'okr_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/okr/permissions/privacies',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdatePrivacyResponse::fromMap($this->execute($params, $req, $runtime));
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
}
