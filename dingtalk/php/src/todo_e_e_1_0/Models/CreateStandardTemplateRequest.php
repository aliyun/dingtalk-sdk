<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateStandardTemplateRequest\actions;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateStandardTemplateRequest\service;
use AlibabaCloud\Tea\Model;

class CreateStandardTemplateRequest extends Model
{
    /**
     * @var actions[]
     */
    public $actions;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var service
     */
    public $service;
    protected $_name = [
        'actions' => 'actions',
        'description' => 'description',
        'name' => 'name',
        'operatorId' => 'operatorId',
        'service' => 'service',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actions) {
            $res['actions'] = [];
            if (null !== $this->actions && \is_array($this->actions)) {
                $n = 0;
                foreach ($this->actions as $item) {
                    $res['actions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->service) {
            $res['service'] = null !== $this->service ? $this->service->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateStandardTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actions'])) {
            if (!empty($map['actions'])) {
                $model->actions = [];
                $n = 0;
                foreach ($map['actions'] as $item) {
                    $model->actions[$n++] = null !== $item ? actions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['service'])) {
            $model->service = service::fromMap($map['service']);
        }

        return $model;
    }
}
