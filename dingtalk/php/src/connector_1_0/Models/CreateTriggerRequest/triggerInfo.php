<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerRequest;

use AlibabaCloud\Tea\Model;

class triggerInfo extends Model
{
    /**
     * @description 连接平台连接器id
     *
     * @var string
     */
    public $dingConnectorId;

    /**
     * @description 服务商的连接器Id，优先使用dingConnectorId，其次使用integratorConnectorId
     *
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @description 服务商的触发事件Id
     *
     * @var string
     */
    public $integratorTriggerId;

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
     * @description 入参jsonSchema
     *
     * @var string
     */
    public $inputSchema;
    protected $_name = [
        'dingConnectorId'       => 'dingConnectorId',
        'integratorConnectorId' => 'integratorConnectorId',
        'integratorTriggerId'   => 'integratorTriggerId',
        'name'                  => 'name',
        'description'           => 'description',
        'inputSchema'           => 'inputSchema',
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
        if (null !== $this->integratorTriggerId) {
            $res['integratorTriggerId'] = $this->integratorTriggerId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->inputSchema) {
            $res['inputSchema'] = $this->inputSchema;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return triggerInfo
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
        if (isset($map['integratorTriggerId'])) {
            $model->integratorTriggerId = $map['integratorTriggerId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['inputSchema'])) {
            $model->inputSchema = $map['inputSchema'];
        }

        return $model;
    }
}
