<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetColumnWidthResponseBody extends Model
{
    /**
     * @var string
     */
    public $sheetId;

    /**
     * @var string
     */
    public $sheetName;
    protected $_name = [
        'sheetId' => 'sheetId',
        'sheetName' => 'sheetName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sheetId) {
            $res['sheetId'] = $this->sheetId;
        }
        if (null !== $this->sheetName) {
            $res['sheetName'] = $this->sheetName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetColumnWidthResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sheetId'])) {
            $model->sheetId = $map['sheetId'];
        }
        if (isset($map['sheetName'])) {
            $model->sheetName = $map['sheetName'];
        }

        return $model;
    }
}
