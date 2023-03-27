<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldResponseBody\result;

use AlibabaCloud\Tea\Model;

class advancedCustomfield extends Model
{
    /**
     * @description 字段类型ID。
     *
     * @var string
     */
    public $advancedCustomfieldId;

    /**
     * @description 字段类型名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 字段类型名称2
     *
     * @var string
     */
    public $objectType;
    protected $_name = [
        'advancedCustomfieldId' => 'advancedCustomfieldId',
        'name'                  => 'name',
        'objectType'            => 'objectType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->advancedCustomfieldId) {
            $res['advancedCustomfieldId'] = $this->advancedCustomfieldId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return advancedCustomfield
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['advancedCustomfieldId'])) {
            $model->advancedCustomfieldId = $map['advancedCustomfieldId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }

        return $model;
    }
}
