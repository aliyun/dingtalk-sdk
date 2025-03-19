<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\CreateFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\CreateFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\CreateFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\CreateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\CreateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\CreateSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\DeleteFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\DeleteFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\DeleteRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\DeleteRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\DeleteRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\DeleteSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\DeleteSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetAllFieldsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetAllFieldsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetAllSheetsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetAllSheetsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\GetSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\InsertRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\InsertRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\InsertRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models\UpdateSheetResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 新增数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param CreateFieldRequest $request       CreateFieldRequest
     * @param CreateFieldHeaders $headers       CreateFieldHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return CreateFieldResponse CreateFieldResponse
     */
    public function createFieldWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->property)) {
            $body['property'] = $request->property;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateField',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param CreateFieldRequest $request       CreateFieldRequest
     *
     * @return CreateFieldResponse CreateFieldResponse
     */
    public function createField($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFieldHeaders([]);

        return $this->createFieldWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 创建数据表
     *  *
     * @param string             $baseId
     * @param CreateSheetRequest $request CreateSheetRequest
     * @param CreateSheetHeaders $headers CreateSheetHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSheetResponse CreateSheetResponse
     */
    public function createSheetWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fields)) {
            $body['fields'] = $request->fields;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateSheet',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建数据表
     *  *
     * @param string             $baseId
     * @param CreateSheetRequest $request CreateSheetRequest
     *
     * @return CreateSheetResponse CreateSheetResponse
     */
    public function createSheet($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSheetHeaders([]);

        return $this->createSheetWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param string             $fieldIdOrName
     * @param DeleteFieldHeaders $headers       DeleteFieldHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return DeleteFieldResponse DeleteFieldResponse
     */
    public function deleteFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $headers, $runtime)
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
            'action' => 'DeleteField',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields/' . $fieldIdOrName . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除数据表字段
     *  *
     * @param string $baseId
     * @param string $sheetIdOrName
     * @param string $fieldIdOrName
     *
     * @return DeleteFieldResponse DeleteFieldResponse
     */
    public function deleteField($baseId, $sheetIdOrName, $fieldIdOrName)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFieldHeaders([]);

        return $this->deleteFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $headers, $runtime);
    }

    /**
     * @summary 删除数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param DeleteRecordsRequest $request       DeleteRecordsRequest
     * @param DeleteRecordsHeaders $headers       DeleteRecordsHeaders
     * @param RuntimeOptions       $runtime       runtime options for this request RuntimeOptions
     *
     * @return DeleteRecordsResponse DeleteRecordsResponse
     */
    public function deleteRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->recordIds)) {
            $body['recordIds'] = $request->recordIds;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeleteRecords',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records/delete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param DeleteRecordsRequest $request       DeleteRecordsRequest
     *
     * @return DeleteRecordsResponse DeleteRecordsResponse
     */
    public function deleteRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRecordsHeaders([]);

        return $this->deleteRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 删除数据表
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param DeleteSheetHeaders $headers       DeleteSheetHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return DeleteSheetResponse DeleteSheetResponse
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
            'action' => 'DeleteSheet',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除数据表
     *  *
     * @param string $baseId
     * @param string $sheetIdOrName
     *
     * @return DeleteSheetResponse DeleteSheetResponse
     */
    public function deleteSheet($baseId, $sheetIdOrName)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSheetHeaders([]);

        return $this->deleteSheetWithOptions($baseId, $sheetIdOrName, $headers, $runtime);
    }

    /**
     * @summary 获取所有字段
     *  *
     * @param string              $baseId
     * @param string              $sheetIdOrName
     * @param GetAllFieldsHeaders $headers       GetAllFieldsHeaders
     * @param RuntimeOptions      $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetAllFieldsResponse GetAllFieldsResponse
     */
    public function getAllFieldsWithOptions($baseId, $sheetIdOrName, $headers, $runtime)
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
            'action' => 'GetAllFields',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAllFieldsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取所有字段
     *  *
     * @param string $baseId
     * @param string $sheetIdOrName
     *
     * @return GetAllFieldsResponse GetAllFieldsResponse
     */
    public function getAllFields($baseId, $sheetIdOrName)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllFieldsHeaders([]);

        return $this->getAllFieldsWithOptions($baseId, $sheetIdOrName, $headers, $runtime);
    }

    /**
     * @summary 获取所有数据表
     *  *
     * @param string              $baseId
     * @param GetAllSheetsHeaders $headers GetAllSheetsHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAllSheetsResponse GetAllSheetsResponse
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
            'action' => 'GetAllSheets',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAllSheetsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取所有数据表
     *  *
     * @param string $baseId
     *
     * @return GetAllSheetsResponse GetAllSheetsResponse
     */
    public function getAllSheets($baseId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllSheetsHeaders([]);

        return $this->getAllSheetsWithOptions($baseId, $headers, $runtime);
    }

    /**
     * @summary 获取记录
     *  *
     * @param string           $baseId
     * @param string           $sheetIdOrName
     * @param string           $recordId
     * @param GetRecordHeaders $headers       GetRecordHeaders
     * @param RuntimeOptions   $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetRecordResponse GetRecordResponse
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
            'action' => 'GetRecord',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records/' . $recordId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取记录
     *  *
     * @param string $baseId
     * @param string $sheetIdOrName
     * @param string $recordId
     *
     * @return GetRecordResponse GetRecordResponse
     */
    public function getRecord($baseId, $sheetIdOrName, $recordId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecordHeaders([]);

        return $this->getRecordWithOptions($baseId, $sheetIdOrName, $recordId, $headers, $runtime);
    }

    /**
     * @summary 获取多行记录
     *  *
     * @param string            $baseId
     * @param string            $sheetIdOrName
     * @param GetRecordsRequest $request       GetRecordsRequest
     * @param GetRecordsHeaders $headers       GetRecordsHeaders
     * @param RuntimeOptions    $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetRecordsResponse GetRecordsResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetRecords',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取多行记录
     *  *
     * @param string            $baseId
     * @param string            $sheetIdOrName
     * @param GetRecordsRequest $request       GetRecordsRequest
     *
     * @return GetRecordsResponse GetRecordsResponse
     */
    public function getRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecordsHeaders([]);

        return $this->getRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 获取数据表
     *  *
     * @param string          $baseId
     * @param string          $sheetIdOrName
     * @param GetSheetHeaders $headers       GetSheetHeaders
     * @param RuntimeOptions  $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetSheetResponse GetSheetResponse
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
            'action' => 'GetSheet',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取数据表
     *  *
     * @param string $baseId
     * @param string $sheetIdOrName
     *
     * @return GetSheetResponse GetSheetResponse
     */
    public function getSheet($baseId, $sheetIdOrName)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSheetHeaders([]);

        return $this->getSheetWithOptions($baseId, $sheetIdOrName, $headers, $runtime);
    }

    /**
     * @summary 新增记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param InsertRecordsRequest $request       InsertRecordsRequest
     * @param InsertRecordsHeaders $headers       InsertRecordsHeaders
     * @param RuntimeOptions       $runtime       runtime options for this request RuntimeOptions
     *
     * @return InsertRecordsResponse InsertRecordsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InsertRecords',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InsertRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param InsertRecordsRequest $request       InsertRecordsRequest
     *
     * @return InsertRecordsResponse InsertRecordsResponse
     */
    public function insertRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertRecordsHeaders([]);

        return $this->insertRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 更新数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param string             $fieldIdOrName
     * @param UpdateFieldRequest $request       UpdateFieldRequest
     * @param UpdateFieldHeaders $headers       UpdateFieldHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return UpdateFieldResponse UpdateFieldResponse
     */
    public function updateFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->property)) {
            $body['property'] = $request->property;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateField',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields/' . $fieldIdOrName . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param string             $fieldIdOrName
     * @param UpdateFieldRequest $request       UpdateFieldRequest
     *
     * @return UpdateFieldResponse UpdateFieldResponse
     */
    public function updateField($baseId, $sheetIdOrName, $fieldIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFieldHeaders([]);

        return $this->updateFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 更新数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param UpdateRecordsRequest $request       UpdateRecordsRequest
     * @param UpdateRecordsHeaders $headers       UpdateRecordsHeaders
     * @param RuntimeOptions       $runtime       runtime options for this request RuntimeOptions
     *
     * @return UpdateRecordsResponse UpdateRecordsResponse
     */
    public function updateRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRecords',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param UpdateRecordsRequest $request       UpdateRecordsRequest
     *
     * @return UpdateRecordsResponse UpdateRecordsResponse
     */
    public function updateRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRecordsHeaders([]);

        return $this->updateRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 更新数据表
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param UpdateSheetRequest $request       UpdateSheetRequest
     * @param UpdateSheetHeaders $headers       UpdateSheetHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return UpdateSheetResponse UpdateSheetResponse
     */
    public function updateSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateSheet',
            'version' => 'notable_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新数据表
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param UpdateSheetRequest $request       UpdateSheetRequest
     *
     * @return UpdateSheetResponse UpdateSheetResponse
     */
    public function updateSheet($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSheetHeaders([]);

        return $this->updateSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }
}
