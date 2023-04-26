<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest\actionInfo\inputMappingConfig;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest\actionInfo\outputDataRules;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest\actionInfo\outputMappingConfig;
use AlibabaCloud\Tea\Model;

class actionInfo extends Model
{
    /**
     * @var string
     */
    public $apiPath;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $dingConnectorId;

    /**
     * @var inputMappingConfig
     */
    public $inputMappingConfig;

    /**
     * @var string
     */
    public $inputSchema;

    /**
     * @var string
     */
    public $integratorActionId;

    /**
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var outputDataRules[]
     */
    public $outputDataRules;

    /**
     * @var outputMappingConfig
     */
    public $outputMappingConfig;

    /**
     * @var string
     */
    public $outputSchema;
    protected $_name = [
        'apiPath'               => 'apiPath',
        'description'           => 'description',
        'dingConnectorId'       => 'dingConnectorId',
        'inputMappingConfig'    => 'inputMappingConfig',
        'inputSchema'           => 'inputSchema',
        'integratorActionId'    => 'integratorActionId',
        'integratorConnectorId' => 'integratorConnectorId',
        'name'                  => 'name',
        'outputDataRules'       => 'outputDataRules',
        'outputMappingConfig'   => 'outputMappingConfig',
        'outputSchema'          => 'outputSchema',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiPath) {
            $res['apiPath'] = $this->apiPath;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->dingConnectorId) {
            $res['dingConnectorId'] = $this->dingConnectorId;
        }
        if (null !== $this->inputMappingConfig) {
            $res['inputMappingConfig'] = null !== $this->inputMappingConfig ? $this->inputMappingConfig->toMap() : null;
        }
        if (null !== $this->inputSchema) {
            $res['inputSchema'] = $this->inputSchema;
        }
        if (null !== $this->integratorActionId) {
            $res['integratorActionId'] = $this->integratorActionId;
        }
        if (null !== $this->integratorConnectorId) {
            $res['integratorConnectorId'] = $this->integratorConnectorId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outputDataRules) {
            $res['outputDataRules'] = [];
            if (null !== $this->outputDataRules && \is_array($this->outputDataRules)) {
                $n = 0;
                foreach ($this->outputDataRules as $item) {
                    $res['outputDataRules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outputMappingConfig) {
            $res['outputMappingConfig'] = null !== $this->outputMappingConfig ? $this->outputMappingConfig->toMap() : null;
        }
        if (null !== $this->outputSchema) {
            $res['outputSchema'] = $this->outputSchema;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actionInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiPath'])) {
            $model->apiPath = $map['apiPath'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['dingConnectorId'])) {
            $model->dingConnectorId = $map['dingConnectorId'];
        }
        if (isset($map['inputMappingConfig'])) {
            $model->inputMappingConfig = inputMappingConfig::fromMap($map['inputMappingConfig']);
        }
        if (isset($map['inputSchema'])) {
            $model->inputSchema = $map['inputSchema'];
        }
        if (isset($map['integratorActionId'])) {
            $model->integratorActionId = $map['integratorActionId'];
        }
        if (isset($map['integratorConnectorId'])) {
            $model->integratorConnectorId = $map['integratorConnectorId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outputDataRules'])) {
            if (!empty($map['outputDataRules'])) {
                $model->outputDataRules = [];
                $n                      = 0;
                foreach ($map['outputDataRules'] as $item) {
                    $model->outputDataRules[$n++] = null !== $item ? outputDataRules::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outputMappingConfig'])) {
            $model->outputMappingConfig = outputMappingConfig::fromMap($map['outputMappingConfig']);
        }
        if (isset($map['outputSchema'])) {
            $model->outputSchema = $map['outputSchema'];
        }

        return $model;
    }
}
