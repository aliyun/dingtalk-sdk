<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\InsertRecordsRequest;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $fields;
    protected $_name = [
        'fields' => 'fields',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fields) {
            $res['fields'] = $this->fields;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fields'])) {
            $model->fields = $map['fields'];
        }

        return $model;
    }
}
