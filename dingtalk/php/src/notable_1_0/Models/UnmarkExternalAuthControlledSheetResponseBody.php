<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class UnmarkExternalAuthControlledSheetResponseBody extends Model
{
    /**
     * @var string
     */
    public $sheetId;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'sheetId' => 'sheetId',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sheetId) {
            $res['sheetId'] = $this->sheetId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UnmarkExternalAuthControlledSheetResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sheetId'])) {
            $model->sheetId = $map['sheetId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
