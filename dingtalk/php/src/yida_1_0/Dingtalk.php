<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponse;
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
     * @param SaveFormDataRequest $request
     *
     * @return SaveFormDataResponse
     */
    public function saveFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormDataHeaders([]);

        return $this->saveFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveFormDataRequest $request
     * @param SaveFormDataHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return SaveFormDataResponse
     */
    public function saveFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
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

        return SaveFormDataResponse::fromMap($this->doROARequest('SaveFormData', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances', 'json', $req, $runtime));
    }

    /**
     * @param SearchFormDatasRequest $request
     *
     * @return SearchFormDatasResponse
     */
    public function searchFormDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDatasHeaders([]);

        return $this->searchFormDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchFormDatasRequest $request
     * @param SearchFormDatasHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SearchFormDatasResponse
     */
    public function searchFormDatasWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->currentPage)) {
            @$body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->dynamicOrder)) {
            @$body['dynamicOrder'] = $request->dynamicOrder;
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

        return SearchFormDatasResponse::fromMap($this->doROARequest('SearchFormDatas', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/search', 'json', $req, $runtime));
    }

    /**
     * @param LoginCodeGenRequest $request
     *
     * @return LoginCodeGenResponse
     */
    public function loginCodeGen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoginCodeGenHeaders([]);

        return $this->loginCodeGenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param LoginCodeGenRequest $request
     * @param LoginCodeGenHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return LoginCodeGenResponse
     */
    public function loginCodeGenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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

        return LoginCodeGenResponse::fromMap($this->doROARequest('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/authorizations/loginCodes', 'json', $req, $runtime));
    }

    /**
     * @param string                 $id
     * @param GetFormDataByIDRequest $request
     *
     * @return GetFormDataByIDResponse
     */
    public function getFormDataByID($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormDataByIDHeaders([]);

        return $this->getFormDataByIDWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @param string                 $id
     * @param GetFormDataByIDRequest $request
     * @param GetFormDataByIDHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetFormDataByIDResponse
     */
    public function getFormDataByIDWithOptions($id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
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

        return GetFormDataByIDResponse::fromMap($this->doROARequest('GetFormDataByID', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/forms/instances/' . $id . '', 'json', $req, $runtime));
    }
}
