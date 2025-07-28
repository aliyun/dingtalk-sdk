<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryCalculationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryCalculationRequest;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryCalculationResponse;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryItemGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryItemGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\ListSalaryCalculationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\ListSalaryCalculationRequest;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\ListSalaryCalculationResponse;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\WriteSalaryCalculationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\WriteSalaryCalculationRequest;
use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\WriteSalaryCalculationResponse;
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
     * @summary 小微薪酬获取薪资记录
     *  *
     * @param GetSalaryCalculationRequest $request GetSalaryCalculationRequest
     * @param GetSalaryCalculationHeaders $headers GetSalaryCalculationHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSalaryCalculationResponse GetSalaryCalculationResponse
     */
    public function getSalaryCalculationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->date)) {
            $query['date'] = $request->date;
        }
        if (!Utils::isUnset($request->salaryGroupId)) {
            $query['salaryGroupId'] = $request->salaryGroupId;
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
            'action' => 'GetSalaryCalculation',
            'version' => 'salary_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/salary/calculation',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSalaryCalculationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 小微薪酬获取薪资记录
     *  *
     * @param GetSalaryCalculationRequest $request GetSalaryCalculationRequest
     *
     * @return GetSalaryCalculationResponse GetSalaryCalculationResponse
     */
    public function getSalaryCalculation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSalaryCalculationHeaders([]);

        return $this->getSalaryCalculationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 小微薪酬获取薪资组
     *  *
     * @param GetSalaryGroupHeaders $headers GetSalaryGroupHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSalaryGroupResponse GetSalaryGroupResponse
     */
    public function getSalaryGroupWithOptions($headers, $runtime)
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
            'action' => 'GetSalaryGroup',
            'version' => 'salary_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/salary/group',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSalaryGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 小微薪酬获取薪资组
     *  *
     * @return GetSalaryGroupResponse GetSalaryGroupResponse
     */
    public function getSalaryGroup()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSalaryGroupHeaders([]);

        return $this->getSalaryGroupWithOptions($headers, $runtime);
    }

    /**
     * @summary 小微薪酬获取薪资项目
     *  *
     * @param GetSalaryItemRequest $request GetSalaryItemRequest
     * @param GetSalaryItemHeaders $headers GetSalaryItemHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSalaryItemResponse GetSalaryItemResponse
     */
    public function getSalaryItemWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->salaryItemGroupId)) {
            $query['salaryItemGroupId'] = $request->salaryItemGroupId;
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
            'action' => 'GetSalaryItem',
            'version' => 'salary_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/salary/item',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSalaryItemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 小微薪酬获取薪资项目
     *  *
     * @param GetSalaryItemRequest $request GetSalaryItemRequest
     *
     * @return GetSalaryItemResponse GetSalaryItemResponse
     */
    public function getSalaryItem($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSalaryItemHeaders([]);

        return $this->getSalaryItemWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 小微薪酬获取薪资项目大类
     *  *
     * @param GetSalaryItemGroupHeaders $headers GetSalaryItemGroupHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSalaryItemGroupResponse GetSalaryItemGroupResponse
     */
    public function getSalaryItemGroupWithOptions($headers, $runtime)
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
            'action' => 'GetSalaryItemGroup',
            'version' => 'salary_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/salary/itemGroup',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSalaryItemGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 小微薪酬获取薪资项目大类
     *  *
     * @return GetSalaryItemGroupResponse GetSalaryItemGroupResponse
     */
    public function getSalaryItemGroup()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSalaryItemGroupHeaders([]);

        return $this->getSalaryItemGroupWithOptions($headers, $runtime);
    }

    /**
     * @summary 小微薪酬获取薪资记录数据
     *  *
     * @param ListSalaryCalculationRequest $request ListSalaryCalculationRequest
     * @param ListSalaryCalculationHeaders $headers ListSalaryCalculationHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListSalaryCalculationResponse ListSalaryCalculationResponse
     */
    public function listSalaryCalculationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->date)) {
            $body['date'] = $request->date;
        }
        if (!Utils::isUnset($request->pageIndex)) {
            $body['pageIndex'] = $request->pageIndex;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->salaryGroupId)) {
            $body['salaryGroupId'] = $request->salaryGroupId;
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
            'action' => 'ListSalaryCalculation',
            'version' => 'salary_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/salary/calculation',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListSalaryCalculationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 小微薪酬获取薪资记录数据
     *  *
     * @param ListSalaryCalculationRequest $request ListSalaryCalculationRequest
     *
     * @return ListSalaryCalculationResponse ListSalaryCalculationResponse
     */
    public function listSalaryCalculation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSalaryCalculationHeaders([]);

        return $this->listSalaryCalculationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 小微薪酬获取薪资记录写入
     *  *
     * @param WriteSalaryCalculationRequest $request WriteSalaryCalculationRequest
     * @param WriteSalaryCalculationHeaders $headers WriteSalaryCalculationHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return WriteSalaryCalculationResponse WriteSalaryCalculationResponse
     */
    public function writeSalaryCalculationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->date)) {
            $body['date'] = $request->date;
        }
        if (!Utils::isUnset($request->items)) {
            $body['items'] = $request->items;
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
            'action' => 'WriteSalaryCalculation',
            'version' => 'salary_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/salary/calculation/write',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return WriteSalaryCalculationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 小微薪酬获取薪资记录写入
     *  *
     * @param WriteSalaryCalculationRequest $request WriteSalaryCalculationRequest
     *
     * @return WriteSalaryCalculationResponse WriteSalaryCalculationResponse
     */
    public function writeSalaryCalculation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WriteSalaryCalculationHeaders([]);

        return $this->writeSalaryCalculationWithOptions($request, $headers, $runtime);
    }
}
