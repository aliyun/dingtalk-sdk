<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataResponseBody;

use AlibabaCloud\Tea\Model;

class associatedRow extends Model
{
    /**
     * @description 行号，从0开始
     *
     * @var int
     */
    public $row;

    /**
     * @description 工作表ID或名称
     *
     * @var string
     */
    public $sheetId;
    protected $_name = [
        'row'     => 'row',
        'sheetId' => 'sheetId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->row) {
            $res['row'] = $this->row;
        }
        if (null !== $this->sheetId) {
            $res['sheetId'] = $this->sheetId;
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
        if (isset($map['sheetId'])) {
            $model->sheetId = $map['sheetId'];
        }

        return $model;
    }
}
