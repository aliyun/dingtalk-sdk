<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionRequest;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionRequest\actionInfo\outputDataRules;
use AlibabaCloud\Tea\Model;

class actionInfo extends Model
{
    /**
     * @description 连接平台连接器id
     *
     * @var string
     */
    public $dingConnectorId;

    /**
     * @description 服务商的连接器Id
     *
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @description 连接平台的执行动作唯一标识。
     *
     * @var string
     */
    public $dingActionId;

    /**
     * @description 服务商的执行事件Id
     *
     * @var string
     */
    public $integratorActionId;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description api请求url path，结合Connector上的apiDomain使用
     *
     * @var string
     */
    public $apiPath;

    /**
     * @description 入参schema
     *
     * @var string
     */
    public $inputSchema;

    /**
     * @description 出参schema
     *
     * @var string
     */
    public $outputSchema;

    /**
     * @description 执行动作接口成功调用规则。
     *
     * @var outputDataRules[]
     */
    public $outputDataRules;
    protected $_name = [
        'dingConnectorId'       => 'dingConnectorId',
        'integratorConnectorId' => 'integratorConnectorId',
        'dingActionId'          => 'dingActionId',
        'integratorActionId'    => 'integratorActionId',
        'name'                  => 'name',
        'description'           => 'description',
        'apiPath'               => 'apiPath',
        'inputSchema'           => 'inputSchema',
        'outputSchema'          => 'outputSchema',
        'outputDataRules'       => 'outputDataRules',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingConnectorId) {
            $res['dingConnectorId'] = $this->dingConnectorId;
        }
        if (null !== $this->integratorConnectorId) {
            $res['integratorConnectorId'] = $this->integratorConnectorId;
        }
        if (null !== $this->dingActionId) {
            $res['dingActionId'] = $this->dingActionId;
        }
        if (null !== $this->integratorActionId) {
            $res['integratorActionId'] = $this->integratorActionId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->apiPath) {
            $res['apiPath'] = $this->apiPath;
        }
        if (null !== $this->inputSchema) {
            $res['inputSchema'] = $this->inputSchema;
        }
        if (null !== $this->outputSchema) {
            $res['outputSchema'] = $this->outputSchema;
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
        if (isset($map['dingConnectorId'])) {
            $model->dingConnectorId = $map['dingConnectorId'];
        }
        if (isset($map['integratorConnectorId'])) {
            $model->integratorConnectorId = $map['integratorConnectorId'];
        }
        if (isset($map['dingActionId'])) {
            $model->dingActionId = $map['dingActionId'];
        }
        if (isset($map['integratorActionId'])) {
            $model->integratorActionId = $map['integratorActionId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['apiPath'])) {
            $model->apiPath = $map['apiPath'];
        }
        if (isset($map['inputSchema'])) {
            $model->inputSchema = $map['inputSchema'];
        }
        if (isset($map['outputSchema'])) {
            $model->outputSchema = $map['outputSchema'];
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

        return $model;
    }
}
