<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryIndustryTagListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryIndustryTagListResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryRoleTagListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryRoleTagListResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateResponse;
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
     * @param BatchCreateTemplateRequest $request
     *
     * @return BatchCreateTemplateResponse
     */
    public function batchCreateTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateTemplateHeaders([]);

        return $this->batchCreateTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchCreateTemplateRequest $request
     * @param BatchCreateTemplateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchCreateTemplateResponse
     */
    public function batchCreateTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateList)) {
            @$body['templateList'] = $request->templateList;
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

        return BatchCreateTemplateResponse::fromMap($this->doROARequest('BatchCreateTemplate', 'apaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/apaas/templates', 'json', $req, $runtime));
    }

    /**
     * @param BatchQueryByTemplateKeyRequest $request
     *
     * @return BatchQueryByTemplateKeyResponse
     */
    public function batchQueryByTemplateKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryByTemplateKeyHeaders([]);

        return $this->batchQueryByTemplateKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchQueryByTemplateKeyRequest $request
     * @param BatchQueryByTemplateKeyHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return BatchQueryByTemplateKeyResponse
     */
    public function batchQueryByTemplateKeyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateKeys)) {
            @$body['templateKeys'] = $request->templateKeys;
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

        return BatchQueryByTemplateKeyResponse::fromMap($this->doROARequest('BatchQueryByTemplateKey', 'apaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/apaas/templates/query', 'json', $req, $runtime));
    }

    /**
     * @param BatchUpdateTemplateRequest $request
     *
     * @return BatchUpdateTemplateResponse
     */
    public function batchUpdateTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateTemplateHeaders([]);

        return $this->batchUpdateTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateTemplateRequest $request
     * @param BatchUpdateTemplateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchUpdateTemplateResponse
     */
    public function batchUpdateTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateList)) {
            @$body['templateList'] = $request->templateList;
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

        return BatchUpdateTemplateResponse::fromMap($this->doROARequest('BatchUpdateTemplate', 'apaas_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/apaas/templates', 'json', $req, $runtime));
    }

    /**
     * @return QueryIndustryTagListResponse
     */
    public function queryIndustryTagList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryIndustryTagListHeaders([]);

        return $this->queryIndustryTagListWithOptions($headers, $runtime);
    }

    /**
     * @param QueryIndustryTagListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryIndustryTagListResponse
     */
    public function queryIndustryTagListWithOptions($headers, $runtime)
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

        return QueryIndustryTagListResponse::fromMap($this->doROARequest('QueryIndustryTagList', 'apaas_1.0', 'HTTP', 'GET', 'AK', '/v1.0/apaas/templates/industries', 'json', $req, $runtime));
    }

    /**
     * @return QueryRoleTagListResponse
     */
    public function queryRoleTagList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRoleTagListHeaders([]);

        return $this->queryRoleTagListWithOptions($headers, $runtime);
    }

    /**
     * @param QueryRoleTagListHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryRoleTagListResponse
     */
    public function queryRoleTagListWithOptions($headers, $runtime)
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

        return QueryRoleTagListResponse::fromMap($this->doROARequest('QueryRoleTagList', 'apaas_1.0', 'HTTP', 'GET', 'AK', '/v1.0/apaas/templates/roles', 'json', $req, $runtime));
    }

    /**
     * @return QueryTemplateCategorysResponse
     */
    public function queryTemplateCategorys()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTemplateCategorysHeaders([]);

        return $this->queryTemplateCategorysWithOptions($headers, $runtime);
    }

    /**
     * @param QueryTemplateCategorysHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryTemplateCategorysResponse
     */
    public function queryTemplateCategorysWithOptions($headers, $runtime)
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

        return QueryTemplateCategorysResponse::fromMap($this->doROARequest('QueryTemplateCategorys', 'apaas_1.0', 'HTTP', 'GET', 'AK', '/v1.0/apaas/templates/categories', 'json', $req, $runtime));
    }

    /**
     * @param RecallAuditTemplateRequest $request
     *
     * @return RecallAuditTemplateResponse
     */
    public function recallAuditTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallAuditTemplateHeaders([]);

        return $this->recallAuditTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RecallAuditTemplateRequest $request
     * @param RecallAuditTemplateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RecallAuditTemplateResponse
     */
    public function recallAuditTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateKeys)) {
            @$body['templateKeys'] = $request->templateKeys;
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

        return RecallAuditTemplateResponse::fromMap($this->doROARequest('RecallAuditTemplate', 'apaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/apaas/templates/audits/recall', 'json', $req, $runtime));
    }
}
