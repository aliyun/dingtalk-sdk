<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListActionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListActionResponseBody\list_\actionContent;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description actionCode
     *
     * @var string
     */
    public $actionCode;

    /**
     * @description actionContent
     *
     * @var actionContent[]
     */
    public $actionContent;

    /**
     * @description operator
     *
     * @var string
     */
    public $operator;

    /**
     * @description operatorId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description operatorRole
     *
     * @var string
     */
    public $operatorRole;
    protected $_name = [
        'actionCode'    => 'actionCode',
        'actionContent' => 'actionContent',
        'operator'      => 'operator',
        'operatorId'    => 'operatorId',
        'operatorRole'  => 'operatorRole',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionCode) {
            $res['actionCode'] = $this->actionCode;
        }
        if (null !== $this->actionContent) {
            $res['actionContent'] = [];
            if (null !== $this->actionContent && \is_array($this->actionContent)) {
                $n = 0;
                foreach ($this->actionContent as $item) {
                    $res['actionContent'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->operatorRole) {
            $res['operatorRole'] = $this->operatorRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionCode'])) {
            $model->actionCode = $map['actionCode'];
        }
        if (isset($map['actionContent'])) {
            if (!empty($map['actionContent'])) {
                $model->actionContent = [];
                $n                    = 0;
                foreach ($map['actionContent'] as $item) {
                    $model->actionContent[$n++] = null !== $item ? actionContent::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['operatorRole'])) {
            $model->operatorRole = $map['operatorRole'];
        }

        return $model;
    }
}
