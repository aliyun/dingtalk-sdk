<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddRelationMetaFieldRequest\fieldDTOList;
use AlibabaCloud\Tea\Model;

class AddRelationMetaFieldRequest extends Model
{
    /**
     * @var fieldDTOList[]
     */
    public $fieldDTOList;

    /**
     * @var string
     */
    public $operatorUserId;

    /**
     * @var string
     */
    public $relationType;

    /**
     * @var string
     */
    public $tenant;
    protected $_name = [
        'fieldDTOList'   => 'fieldDTOList',
        'operatorUserId' => 'operatorUserId',
        'relationType'   => 'relationType',
        'tenant'         => 'tenant',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRelationMetaFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }

        return $model;
    }
}
