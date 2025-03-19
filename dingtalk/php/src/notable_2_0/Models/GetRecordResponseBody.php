<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetRecordResponseBody extends Model
{
    /**
     * @var mixed[]
     */
    public $fields;

    /**
     * @var string
     */
    public $id;
    protected $_name = [
        'fields' => 'fields',
        'id' => 'id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fields) {
            $res['fields'] = $this->fields;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRecordResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fields'])) {
            $model->fields = $map['fields'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
