<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataResponse;
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
     * @param PullDataByPageRequest $request
     *
     * @return PullDataByPageResponse
     */
    public function pullDataByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDataByPageHeaders([]);

        return $this->pullDataByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PullDataByPageRequest $request
     * @param PullDataByPageHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return PullDataByPageResponse
     */
    public function pullDataByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dataModelId)) {
            @$query['dataModelId'] = $request->dataModelId;
        }
        if (!Utils::isUnset($request->datetimeFilterField)) {
            @$query['datetimeFilterField'] = $request->datetimeFilterField;
        }
        if (!Utils::isUnset($request->minDatetime)) {
            @$query['minDatetime'] = $request->minDatetime;
        }
        if (!Utils::isUnset($request->maxDatetime)) {
            @$query['maxDatetime'] = $request->maxDatetime;
        }
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

        return PullDataByPageResponse::fromMap($this->doROARequest('PullDataByPage', 'connector_1.0', 'HTTP', 'GET', 'AK', '/v1.0/connector/data', 'json', $req, $runtime));
    }

    /**
     * @param string              $dataModelId
     * @param PullDataByPkRequest $request
     *
     * @return PullDataByPkResponse
     */
    public function pullDataByPk($dataModelId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDataByPkHeaders([]);

        return $this->pullDataByPkWithOptions($dataModelId, $request, $headers, $runtime);
    }

    /**
     * @param string              $dataModelId
     * @param PullDataByPkRequest $request
     * @param PullDataByPkHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return PullDataByPkResponse
     */
    public function pullDataByPkWithOptions($dataModelId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->primaryKey)) {
            @$query['primaryKey'] = $request->primaryKey;
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

        return PullDataByPkResponse::fromMap($this->doROARequest('PullDataByPk', 'connector_1.0', 'HTTP', 'GET', 'AK', '/v1.0/connector/data/' . $dataModelId . '', 'json', $req, $runtime));
    }

    /**
     * @param SyncDataRequest $request
     *
     * @return SyncDataResponse
     */
    public function syncData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncDataHeaders([]);

        return $this->syncDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncDataRequest $request
     * @param SyncDataHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return SyncDataResponse
     */
    public function syncDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->triggerDataList)) {
            @$body['triggerDataList'] = $request->triggerDataList;
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

        return SyncDataResponse::fromMap($this->doROARequest('SyncData', 'connector_1.0', 'HTTP', 'POST', 'AK', '/v1.0/connector/triggers/data/sync', 'json', $req, $runtime));
    }
}
