<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRelationMetaFieldRequest extends Model
{
    /**
     * @var string
     */
    public $tenant;

    /**
     * @var string
     */
    public $operatorUserId;

    /**
     * @var string
     */
    public $relationType;

    /**
     * @var string[]
     */
    public $fieldIdList;
    protected $_name = [
        'tenant'         => 'tenant',
        'operatorUserId' => 'operatorUserId',
        'relationType'   => 'relationType',
        'fieldIdList'    => 'fieldIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->fieldIdList) {
            $res['fieldIdList'] = $this->fieldIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRelationMetaFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['fieldIdList'])) {
            if (!empty($map['fieldIdList'])) {
                $model->fieldIdList = $map['fieldIdList'];
            }
        }

        return $model;
    }
}
