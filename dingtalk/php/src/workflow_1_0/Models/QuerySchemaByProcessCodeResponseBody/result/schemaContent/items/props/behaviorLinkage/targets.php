<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props\behaviorLinkage;

use AlibabaCloud\Tea\Model;

class targets extends Model
{
    /**
     * @description 行为。
     *
     * @var string
     */
    public $behavior;

    /**
     * @description 字段 id。
     *
     * @var string
     */
    public $fieldId;
    protected $_name = [
        'behavior' => 'behavior',
        'fieldId'  => 'fieldId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->behavior) {
            $res['behavior'] = $this->behavior;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return targets
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['behavior'])) {
            $model->behavior = $map['behavior'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }

        return $model;
    }
}
