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
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 增加对齐目标
     *  *
     * @param string                $objectiveId
     * @param AlignObjectiveRequest $request     AlignObjectiveRequest
     * @param AlignObjectiveHeaders $headers     AlignObjectiveHeaders
     * @param RuntimeOptions        $runtime     runtime options for this request RuntimeOptions
     *
     * @return AlignObjectiveResponse AlignObjectiveResponse
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
     * @summary 增加对齐目标
     *  *
     * @param string                $objectiveId
     * @param AlignObjectiveRequest $request     AlignObjectiveRequest
     *
     * @return AlignObjectiveResponse AlignObjectiveResponse
     */
    public function alignObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AlignObjectiveHeaders([]);

        return $this->alignObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @summary  批量添加权限信息
     *  *
     * @param BatchAddPermissionRequest $request BatchAddPermissionRequest
     * @param BatchAddPermissionHeaders $headers BatchAddPermissionHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchAddPermissionResponse BatchAddPermissionResponse
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
     * @summary  批量添加权限信息
     *  *
     * @param BatchAddPermissionRequest $request BatchAddPermissionRequest
     *
     * @return BatchAddPermissionResponse BatchAddPermissionResponse
     */
    public function batchAddPermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddPermissionHeaders([]);

        return $this->batchAddPermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询目标
     *  *
     * @param BatchQueryObjectiveRequest $request BatchQueryObjectiveRequest
     * @param BatchQueryObjectiveHeaders $headers BatchQueryObjectiveHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryObjectiveResponse BatchQueryObjectiveResponse
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
     * @summary 批量查询目标
     *  *
     * @param BatchQueryObjectiveRequest $request BatchQueryObjectiveRequest
     *
     * @return BatchQueryObjectiveResponse BatchQueryObjectiveResponse
     */
    public function batchQueryObjective($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryObjectiveHeaders([]);

        return $this->batchQueryObjectiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询用户信息
     *  *
     * @param BatchQueryUserRequest $request BatchQueryUserRequest
     * @param BatchQueryUserHeaders $headers BatchQueryUserHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryUserResponse BatchQueryUserResponse
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
     * @summary 批量查询用户信息
     *  *
     * @param BatchQueryUserRequest $request BatchQueryUserRequest
     *
     * @return BatchQueryUserResponse BatchQueryUserResponse
     */
    public function batchQueryUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryUserHeaders([]);

        return $this->batchQueryUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建keyResult
     *  *
     * @param CreateKeyResultRequest $request CreateKeyResultRequest
     * @param CreateKeyResultHeaders $headers CreateKeyResultHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateKeyResultResponse CreateKeyResultResponse
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
     * @summary 创建keyResult
     *  *
     * @param CreateKeyResultRequest $request CreateKeyResultRequest
     *
     * @return CreateKeyResultResponse CreateKeyResultResponse
     */
    public function createKeyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateKeyResultHeaders([]);

        return $this->createKeyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建目标
     *  *
     * @param CreateObjectiveRequest $request CreateObjectiveRequest
     * @param CreateObjectiveHeaders $headers CreateObjectiveHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateObjectiveResponse CreateObjectiveResponse
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
     * @summary 创建目标
     *  *
     * @param CreateObjectiveRequest $request CreateObjectiveRequest
     *
     * @return CreateObjectiveResponse CreateObjectiveResponse
     */
    public function createObjective($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateObjectiveHeaders([]);

        return $this->createObjectiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除keyresult的方法
     *  *
     * @param DeleteKeyResultRequest $request DeleteKeyResultRequest
     * @param DeleteKeyResultHeaders $headers DeleteKeyResultHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteKeyResultResponse DeleteKeyResultResponse
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
     * @summary 删除keyresult的方法
     *  *
     * @param DeleteKeyResultRequest $request DeleteKeyResultRequest
     *
     * @return DeleteKeyResultResponse DeleteKeyResultResponse
     */
    public function deleteKeyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteKeyResultHeaders([]);

        return $this->deleteKeyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除目标
     *  *
     * @param string                 $objectiveId
     * @param DeleteObjectiveRequest $request     DeleteObjectiveRequest
     * @param DeleteObjectiveHeaders $headers     DeleteObjectiveHeaders
     * @param RuntimeOptions         $runtime     runtime options for this request RuntimeOptions
     *
     * @return DeleteObjectiveResponse DeleteObjectiveResponse
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
     * @summary 删除目标
     *  *
     * @param string                 $objectiveId
     * @param DeleteObjectiveRequest $request     DeleteObjectiveRequest
     *
     * @return DeleteObjectiveResponse DeleteObjectiveResponse
     */
    public function deleteObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteObjectiveHeaders([]);

        return $this->deleteObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @summary  删除权限信息
     *  *
     * @param DeletePermissionRequest $request DeletePermissionRequest
     * @param DeletePermissionHeaders $headers DeletePermissionHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DeletePermissionResponse DeletePermissionResponse
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
     * @summary  删除权限信息
     *  *
     * @param DeletePermissionRequest $request DeletePermissionRequest
     *
     * @return DeletePermissionResponse DeletePermissionResponse
     */
    public function deletePermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePermissionHeaders([]);

        return $this->deletePermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取周期列表
     *  *
     * @param GetPeriodListHeaders $headers GetPeriodListHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPeriodListResponse GetPeriodListResponse
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
     * @summary 获取周期列表
     *  *
     * @return GetPeriodListResponse GetPeriodListResponse
     */
    public function getPeriodList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPeriodListHeaders([]);

        return $this->getPeriodListWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取权限信息
     *  *
     * @param GetPermissionRequest $request GetPermissionRequest
     * @param GetPermissionHeaders $headers GetPermissionHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPermissionResponse GetPermissionResponse
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
     * @summary 获取权限信息
     *  *
     * @param GetPermissionRequest $request GetPermissionRequest
     *
     * @return GetPermissionResponse GetPermissionResponse
     */
    public function getPermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPermissionHeaders([]);

        return $this->getPermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary  获取用户当前周期下的全部 OKR 内容
     *  *
     * @param GetUserOkrRequest $request GetUserOkrRequest
     * @param GetUserOkrHeaders $headers GetUserOkrHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserOkrResponse GetUserOkrResponse
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
     * @summary  获取用户当前周期下的全部 OKR 内容
     *  *
     * @param GetUserOkrRequest $request GetUserOkrRequest
     *
     * @return GetUserOkrResponse GetUserOkrResponse
     */
    public function getUserOkr($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserOkrHeaders([]);

        return $this->getUserOkrWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询OKR
     *  *
     * @param OkrObjectivesBatchRequest $request OkrObjectivesBatchRequest
     * @param OkrObjectivesBatchHeaders $headers OkrObjectivesBatchHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return OkrObjectivesBatchResponse OkrObjectivesBatchResponse
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
     * @summary 批量查询OKR
     *  *
     * @param OkrObjectivesBatchRequest $request OkrObjectivesBatchRequest
     *
     * @return OkrObjectivesBatchResponse OkrObjectivesBatchResponse
     */
    public function okrObjectivesBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OkrObjectivesBatchHeaders([]);

        return $this->okrObjectivesBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询单个用户的OKR
     *  *
     * @param string                     $dingUserId
     * @param OkrObjectivesByUserRequest $request    OkrObjectivesByUserRequest
     * @param OkrObjectivesByUserHeaders $headers    OkrObjectivesByUserHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return OkrObjectivesByUserResponse OkrObjectivesByUserResponse
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
     * @summary 查询单个用户的OKR
     *  *
     * @param string                     $dingUserId
     * @param OkrObjectivesByUserRequest $request    OkrObjectivesByUserRequest
     *
     * @return OkrObjectivesByUserResponse OkrObjectivesByUserResponse
     */
    public function okrObjectivesByUser($dingUserId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OkrObjectivesByUserHeaders([]);

        return $this->okrObjectivesByUserWithOptions($dingUserId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取 OKR 周期
     *  *
     * @param OkrPeriodsRequest $request OkrPeriodsRequest
     * @param OkrPeriodsHeaders $headers OkrPeriodsHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return OkrPeriodsResponse OkrPeriodsResponse
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
     * @summary 获取 OKR 周期
     *  *
     * @param OkrPeriodsRequest $request OkrPeriodsRequest
     *
     * @return OkrPeriodsResponse OkrPeriodsResponse
     */
    public function okrPeriods($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OkrPeriodsHeaders([]);

        return $this->okrPeriodsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary  取消对齐Objective
     *  *
     * @param string                  $objectiveId
     * @param UnAlignObjectiveRequest $request     UnAlignObjectiveRequest
     * @param UnAlignObjectiveHeaders $headers     UnAlignObjectiveHeaders
     * @param RuntimeOptions          $runtime     runtime options for this request RuntimeOptions
     *
     * @return UnAlignObjectiveResponse UnAlignObjectiveResponse
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
     * @summary  取消对齐Objective
     *  *
     * @param string                  $objectiveId
     * @param UnAlignObjectiveRequest $request     UnAlignObjectiveRequest
     *
     * @return UnAlignObjectiveResponse UnAlignObjectiveResponse
     */
    public function unAlignObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnAlignObjectiveHeaders([]);

        return $this->unAlignObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @summary 更改KR内容
     *  *
     * @param UpdateKROfContentRequest $request UpdateKROfContentRequest
     * @param UpdateKROfContentHeaders $headers UpdateKROfContentHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateKROfContentResponse UpdateKROfContentResponse
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
     * @summary 更改KR内容
     *  *
     * @param UpdateKROfContentRequest $request UpdateKROfContentRequest
     *
     * @return UpdateKROfContentResponse UpdateKROfContentResponse
     */
    public function updateKROfContent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateKROfContentHeaders([]);

        return $this->updateKROfContentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更改KR分数
     *  *
     * @param UpdateKROfScoreRequest $request UpdateKROfScoreRequest
     * @param UpdateKROfScoreHeaders $headers UpdateKROfScoreHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateKROfScoreResponse UpdateKROfScoreResponse
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
     * @summary 更改KR分数
     *  *
     * @param UpdateKROfScoreRequest $request UpdateKROfScoreRequest
     *
     * @return UpdateKROfScoreResponse UpdateKROfScoreResponse
     */
    public function updateKROfScore($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateKROfScoreHeaders([]);

        return $this->updateKROfScoreWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更改 KR 权重
     *  *
     * @param UpdateKROfWeightRequest $request UpdateKROfWeightRequest
     * @param UpdateKROfWeightHeaders $headers UpdateKROfWeightHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateKROfWeightResponse UpdateKROfWeightResponse
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
     * @summary 更改 KR 权重
     *  *
     * @param UpdateKROfWeightRequest $request UpdateKROfWeightRequest
     *
     * @return UpdateKROfWeightResponse UpdateKROfWeightResponse
     */
    public function updateKROfWeight($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateKROfWeightHeaders([]);

        return $this->updateKROfWeightWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新目标
     *  *
     * @param string                 $objectiveId
     * @param UpdateObjectiveRequest $request     UpdateObjectiveRequest
     * @param UpdateObjectiveHeaders $headers     UpdateObjectiveHeaders
     * @param RuntimeOptions         $runtime     runtime options for this request RuntimeOptions
     *
     * @return UpdateObjectiveResponse UpdateObjectiveResponse
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
     * @summary 更新目标
     *  *
     * @param string                 $objectiveId
     * @param UpdateObjectiveRequest $request     UpdateObjectiveRequest
     *
     * @return UpdateObjectiveResponse UpdateObjectiveResponse
     */
    public function updateObjective($objectiveId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateObjectiveHeaders([]);

        return $this->updateObjectiveWithOptions($objectiveId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新资源隐私策略
     *  *
     * @param UpdatePrivacyRequest $request UpdatePrivacyRequest
     * @param UpdatePrivacyHeaders $headers UpdatePrivacyHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdatePrivacyResponse UpdatePrivacyResponse
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
     * @summary 更新资源隐私策略
     *  *
     * @param UpdatePrivacyRequest $request UpdatePrivacyRequest
     *
     * @return UpdatePrivacyResponse UpdatePrivacyResponse
     */
    public function updatePrivacy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePrivacyHeaders([]);

        return $this->updatePrivacyWithOptions($request, $headers, $runtime);
    }
}
