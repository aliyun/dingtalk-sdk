<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateStandardTemplateRequest\actions;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateStandardTemplateRequest\service;
use AlibabaCloud\Tea\Model;

class UpdateStandardTemplateRequest extends Model
{
    /**
     * @var actions[]
     */
    public $actions;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var service
     */
    public $service;

    /**
     * @var string
     */
    public $templateKey;
    protected $_name = [
        'actions'     => 'actions',
        'operatorId'  => 'operatorId',
        'service'     => 'service',
        'templateKey' => 'templateKey',
    ];

    public function validate()
    {
    }

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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->service) {
            $res['service'] = null !== $this->service ? $this->service->toMap() : null;
        }
        if (null !== $this->templateKey) {
            $res['templateKey'] = $this->templateKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateStandardTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actions'])) {
            if (!empty($map['actions'])) {
                $model->actions = [];
                $n              = 0;
                foreach ($map['actions'] as $item) {
                    $model->actions[$n++] = null !== $item ? actions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['service'])) {
            $model->service = service::fromMap($map['service']);
        }
        if (isset($map['templateKey'])) {
            $model->templateKey = $map['templateKey'];
        }

        return $model;
    }
}
