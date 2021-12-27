<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props\behaviorLinkage;

use AlibabaCloud\Tea\Model;

class targets extends Model
{
    /**
     * @description 字段 id。
     *
     * @var string
     */
    public $fieldId;

    /**
     * @description 行为。
     *
     * @var string
     */
    public $behavior;
    protected $_name = [
        'fieldId'  => 'fieldId',
        'behavior' => 'behavior',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->behavior) {
            $res['behavior'] = $this->behavior;
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
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['behavior'])) {
            $model->behavior = $map['behavior'];
        }

        return $model;
    }
}
