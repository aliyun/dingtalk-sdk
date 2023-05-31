<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryVerifyResultRequest extends Model
{
    /**
     * @var string
     */
    public $verifyId;
    protected $_name = [
        'verifyId' => 'verifyId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->verifyId) {
            $res['verifyId'] = $this->verifyId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryVerifyResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['verifyId'])) {
            $model->verifyId = $map['verifyId'];
        }

        return $model;
    }
}
