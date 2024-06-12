<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMetaModelFieldRequest\fieldDTOList;
use AlibabaCloud\Tea\Model;

class UpdateMetaModelFieldRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @var fieldDTOList[]
     */
    public $fieldDTOList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tenant;
    protected $_name = [
        'bizType'        => 'bizType',
        'fieldDTOList'   => 'fieldDTOList',
        'operatorUserId' => 'operatorUserId',
        'tenant'         => 'tenant',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->fieldDTOList) {
            $res['fieldDTOList'] = [];
            if (null !== $this->fieldDTOList && \is_array($this->fieldDTOList)) {
                $n = 0;
                foreach ($this->fieldDTOList as $item) {
                    $res['fieldDTOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMetaModelFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['fieldDTOList'])) {
            if (!empty($map['fieldDTOList'])) {
                $model->fieldDTOList = [];
                $n                   = 0;
                foreach ($map['fieldDTOList'] as $item) {
                    $model->fieldDTOList[$n++] = null !== $item ? fieldDTOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }

        return $model;
    }
}
