<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAlipayUserIdRequest extends Model
{
    /**
     * @var string[]
     */
    public $dingUserIds;
    protected $_name = [
        'dingUserIds' => 'dingUserIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingUserIds) {
            $res['dingUserIds'] = $this->dingUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAlipayUserIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingUserIds'])) {
            if (!empty($map['dingUserIds'])) {
                $model->dingUserIds = $map['dingUserIds'];
            }
        }

        return $model;
    }
}
