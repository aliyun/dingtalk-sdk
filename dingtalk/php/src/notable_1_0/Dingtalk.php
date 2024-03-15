<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllSheetsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllSheetsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\InsertRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\InsertRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\InsertRecordsResponse;
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
     * @param string             $baseId
     * @param string             $name
     * @param CreateSheetRequest $request
     * @param CreateSheetHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateSheetResponse
     */
    public function createSheetWithOptions($baseId, $name, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fields)) {
            $body['fields'] = $request->fields;
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
            'action'      => 'CreateSheet',
            'version'     => 'notable_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/notable/bases/' . $baseId . '/sheets',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $baseId
     * @param string             $name
     * @param CreateSheetRequest $request
     *
     * @return CreateSheetResponse
     */
    public function createSheet($baseId, $name, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSheetHeaders([]);

        return $this->createSheetWithOptions($baseId, $name, $request, $headers, $runtime);
    }

    /**
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param DeleteSheetHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeleteSheetResponse
     */
    public function deleteSheetWithOptions($baseId, $sheetIdOrName, $headers, $runtime)
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
            'action'      => 'DeleteSheet',
            'version'     => 'notable_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $baseId
     * @param string $sheetIdOrName
     *
     * @return DeleteSheetResponse
     */
    public function deleteSheet($baseId, $sheetIdOrName)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSheetHeaders([]);

        return $this->deleteSheetWithOptions($baseId, $sheetIdOrName, $headers, $runtime);
    }

    /**
     * @param string              $baseId
     * @param GetAllSheetsHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetAllSheetsResponse
     */
    public function getAllSheetsWithOptions($baseId, $headers, $runtime)
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
            'action'      => 'GetAllSheets',
            'version'     => 'notable_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/notable/bases/' . $baseId . '/sheets',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAllSheetsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $baseId
     *
     * @return GetAllSheetsResponse
     */
    public function getAllSheets($baseId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllSheetsHeaders([]);

        return $this->getAllSheetsWithOptions($baseId, $headers, $runtime);
    }

    /**
     * @param string           $baseId
     * @param string           $sheetIdOrName
     * @param string           $recordId
     * @param GetRecordHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return GetRecordResponse
     */
    public function getRecordWithOptions($baseId, $sheetIdOrName, $recordId, $headers, $runtime)
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
            'action'      => 'GetRecord',
            'version'     => 'notable_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records/' . $recordId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $baseId
     * @param string $sheetIdOrName
     * @param string $recordId
     *
     * @return GetRecordResponse
     */
    public function getRecord($baseId, $sheetIdOrName, $recordId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecordHeaders([]);

        return $this->getRecordWithOptions($baseId, $sheetIdOrName, $recordId, $headers, $runtime);
    }

    /**
     * @param string            $baseId
     * @param string            $sheetIdOrName
     * @param GetRecordsRequest $request
     * @param GetRecordsHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetRecordsResponse
     */
    public function getRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action'      => 'GetRecords',
            'version'     => 'notable_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $baseId
     * @param string            $sheetIdOrName
     * @param GetRecordsRequest $request
     *
     * @return GetRecordsResponse
     */
    public function getRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecordsHeaders([]);

        return $this->getRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @param string          $baseId
     * @param string          $sheetIdOrName
     * @param GetSheetHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetSheetResponse
     */
    public function getSheetWithOptions($baseId, $sheetIdOrName, $headers, $runtime)
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
            'action'      => 'GetSheet',
            'version'     => 'notable_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $baseId
     * @param string $sheetIdOrName
     *
     * @return GetSheetResponse
     */
    public function getSheet($baseId, $sheetIdOrName)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSheetHeaders([]);

        return $this->getSheetWithOptions($baseId, $sheetIdOrName, $headers, $runtime);
    }

    /**
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param InsertRecordsRequest $request
     * @param InsertRecordsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return InsertRecordsResponse
     */
    public function insertRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->records)) {
            $body['records'] = $request->records;
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
            'action'      => 'InsertRecords',
            'version'     => 'notable_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InsertRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param InsertRecordsRequest $request
     *
     * @return InsertRecordsResponse
     */
    public function insertRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertRecordsHeaders([]);

        return $this->insertRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }
}
