<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkrecord_1_0\Models;

use AlibabaCloud\Tea\Model;

class CountWorkRecordResponseBody extends Model
{
    /**
     * @description undoCount
     *
     * @var int
     */
    public $undoCount;
    protected $_name = [
        'undoCount' => 'undoCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->undoCount) {
            $res['undoCount'] = $this->undoCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CountWorkRecordResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['undoCount'])) {
            $model->undoCount = $map['undoCount'];
        }

        return $model;
    }
}
