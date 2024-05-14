<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserPayInfoResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $signNo;
    protected $_name = [
        'signNo' => 'signNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->signNo) {
            $res['signNo'] = $this->signNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserPayInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['signNo'])) {
            $model->signNo = $map['signNo'];
        }

        return $model;
    }
}
