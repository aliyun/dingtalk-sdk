<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryInstancesByMultiConditionsRequest;

use AlibabaCloud\Tea\Model;

class sortFields extends Model
{
    /**
     * @description 排序字段
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @description 排序方式
     *
     * @var string
     */
    public $sortBy;
    protected $_name = [
        'fieldCode' => 'fieldCode',
        'sortBy'    => 'sortBy',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->sortBy) {
            $res['sortBy'] = $this->sortBy;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sortFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['sortBy'])) {
            $model->sortBy = $map['sortBy'];
        }

        return $model;
    }
}
