<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsRequest;

use AlibabaCloud\Tea\Model;

class sortByFields extends Model
{
    /**
     * @example Ascending
     *
     * @var string
     */
    public $direction;

    /**
     * @example Age
     *
     * @var string
     */
    public $fieldName;
    protected $_name = [
        'direction' => 'direction',
        'fieldName' => 'fieldName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->direction) {
            $res['direction'] = $this->direction;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sortByFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['direction'])) {
            $model->direction = $map['direction'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }

        return $model;
    }
}
