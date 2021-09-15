<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDingIdByMigrationDingIdResponseBody extends Model
{
    /**
     * @description dingId
     *
     * @var string
     */
    public $dingId;
    protected $_name = [
        'dingId' => 'dingId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingId) {
            $res['dingId'] = $this->dingId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDingIdByMigrationDingIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingId'])) {
            $model->dingId = $map['dingId'];
        }

        return $model;
    }
}
