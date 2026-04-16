<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryFileInfoByMinutesIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $minutesId;
    protected $_name = [
        'minutesId' => 'minutesId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->minutesId) {
            $res['minutesId'] = $this->minutesId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFileInfoByMinutesIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['minutesId'])) {
            $model->minutesId = $map['minutesId'];
        }

        return $model;
    }
}
