<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeMetaModelResponseBody\metaModelDTOList\items\props\behaviorLinkage;

use AlibabaCloud\Tea\Model;

class targets extends Model
{
    /**
     * @example NORMAL
     *
     * @var string
     */
    public $behavior;

    /**
     * @example TextField_1LTIYOR4XIF40
     *
     * @var string
     */
    public $fieldId;
    protected $_name = [
        'behavior' => 'behavior',
        'fieldId' => 'fieldId',
    ];

    public function validate() {}

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
