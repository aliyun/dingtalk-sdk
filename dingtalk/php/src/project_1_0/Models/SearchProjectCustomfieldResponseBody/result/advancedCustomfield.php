<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponseBody\result;

use AlibabaCloud\Tea\Model;

class advancedCustomfield extends Model
{
    /**
     * @example 63a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $advancedCustomfieldId;

    /**
     * @example 所思文档
     *
     * @var string
     */
    public $name;

    /**
     * @example thoughts.document
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
