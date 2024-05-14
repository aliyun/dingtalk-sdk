<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateDeveloperMetadataRequest;

use AlibabaCloud\Tea\Model;

class associatedColumn extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $column;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sheet;
    protected $_name = [
        'column' => 'column',
        'sheet'  => 'sheet',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->column) {
            $res['column'] = $this->column;
        }
        if (null !== $this->sheet) {
            $res['sheet'] = $this->sheet;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return associatedColumn
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['column'])) {
            $model->column = $map['column'];
        }
        if (isset($map['sheet'])) {
            $model->sheet = $map['sheet'];
        }

        return $model;
    }
}
