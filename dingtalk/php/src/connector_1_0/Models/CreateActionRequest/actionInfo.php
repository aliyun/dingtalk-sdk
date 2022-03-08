<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest\actionInfo\outputDataRules;
use AlibabaCloud\Tea\Model;

class actionInfo extends Model
{
    /**
     * @description api请求url path，结合Connector上的apiDomain使用
     *
     * @var string
     */
    public $apiPath;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 连接平台连接器id
     *
     * @var string
     */
    public $dingConnectorId;

    /**
     * @description 入参schema
     *
     * @var string
     */
    public $inputSchema;

    /**
     * @description 服务商的执行事件Id
     *
     * @var string
     */
    public $integratorActionId;

    /**
     * @description 服务商的连接器Id
     *
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 执行动作接口成功调用规则。
     *
     * @var outputDataRules[]
     */
    public $outputDataRules;

    /**
     * @description 出参schema
     *
     * @var string
     */
    public $outputSchema;
    protected $_name = [
        'apiPath'               => 'apiPath',
        'description'           => 'description',
        'dingConnectorId'       => 'dingConnectorId',
        'inputSchema'           => 'inputSchema',
        'integratorActionId'    => 'integratorActionId',
        'integratorConnectorId' => 'integratorConnectorId',
        'name'                  => 'name',
        'outputDataRules'       => 'outputDataRules',
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
        if (isset($map['outputSchema'])) {
            $model->outputSchema = $map['outputSchema'];
        }

        return $model;
    }
}
