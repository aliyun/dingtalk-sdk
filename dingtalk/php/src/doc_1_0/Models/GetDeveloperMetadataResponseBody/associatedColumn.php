<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataResponseBody;

use AlibabaCloud\Tea\Model;

class associatedColumn extends Model
{
    /**
     * @description 列号，从0开始
     *
     * @var int
     */
    public $column;

    /**
     * @var string
     */
    public $sheetId;
    protected $_name = [
        'column'  => 'column',
        'sheetId' => 'sheetId',
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
        if (null !== $this->sheetId) {
            $res['sheetId'] = $this->sheetId;
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
        if (isset($map['sheetId'])) {
            $model->sheetId = $map['sheetId'];
        }

        return $model;
    }
}
