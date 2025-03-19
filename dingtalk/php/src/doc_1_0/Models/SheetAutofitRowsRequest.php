<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SheetAutofitRowsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $fontWidth;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $row;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $rowCount;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'fontWidth' => 'fontWidth',
        'row' => 'row',
        'rowCount' => 'rowCount',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fontWidth) {
            $res['fontWidth'] = $this->fontWidth;
        }
        if (null !== $this->row) {
            $res['row'] = $this->row;
        }
        if (null !== $this->rowCount) {
            $res['rowCount'] = $this->rowCount;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SheetAutofitRowsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fontWidth'])) {
            $model->fontWidth = $map['fontWidth'];
        }
        if (isset($map['row'])) {
            $model->row = $map['row'];
        }
        if (isset($map['rowCount'])) {
            $model->rowCount = $map['rowCount'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
