<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SortFilterRequest;

use AlibabaCloud\Tea\Model;

class field extends Model
{
    /**
     * @var bool
     */
    public $ascending;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $column;
    protected $_name = [
        'ascending' => 'ascending',
        'column' => 'column',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ascending) {
            $res['ascending'] = $this->ascending;
        }
        if (null !== $this->column) {
            $res['column'] = $this->column;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return field
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ascending'])) {
            $model->ascending = $map['ascending'];
        }
        if (isset($map['column'])) {
            $model->column = $map['column'];
        }

        return $model;
    }
}
