<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateDeveloperMetadataRequest;

use AlibabaCloud\Tea\Model;

class associatedRow extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $row;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sheet;
    protected $_name = [
        'row' => 'row',
        'sheet' => 'sheet',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->row) {
            $res['row'] = $this->row;
        }
        if (null !== $this->sheet) {
            $res['sheet'] = $this->sheet;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return associatedRow
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['row'])) {
            $model->row = $map['row'];
        }
        if (isset($map['sheet'])) {
            $model->sheet = $map['sheet'];
        }

        return $model;
    }
}
