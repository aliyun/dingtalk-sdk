<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsRequest;

use AlibabaCloud\Tea\Model;

class sortByFields extends Model
{
    /**
     * @description 排序字段名
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description 排序方向。Ascending=升序，Descending=降序
     *
     * @var string
     */
    public $direction;
    protected $_name = [
        'fieldName' => 'fieldName',
        'direction' => 'direction',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->direction) {
            $res['direction'] = $this->direction;
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
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['direction'])) {
            $model->direction = $map['direction'];
        }

        return $model;
    }
}
