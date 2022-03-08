<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRelationMetaFieldRequest extends Model
{
    /**
     * @var string[]
     */
    public $fieldIdList;

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
        'fieldIdList'    => 'fieldIdList',
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
        if (null !== $this->fieldIdList) {
            $res['fieldIdList'] = $this->fieldIdList;
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
     * @return DeleteRelationMetaFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldIdList'])) {
            if (!empty($map['fieldIdList'])) {
                $model->fieldIdList = $map['fieldIdList'];
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
