<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserAlipayAccountResponseBody extends Model
{
    /**
     * @description 支付宝uid
     *
     * @var string
     */
    public $alipayUid;
    protected $_name = [
        'alipayUid' => 'alipayUid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayUid) {
            $res['alipayUid'] = $this->alipayUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserAlipayAccountResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alipayUid'])) {
            $model->alipayUid = $map['alipayUid'];
        }

        return $model;
    }
}
