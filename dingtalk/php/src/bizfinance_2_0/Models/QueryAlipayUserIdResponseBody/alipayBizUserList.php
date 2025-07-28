<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAlipayUserIdResponseBody;

use AlibabaCloud\Tea\Model;

class alipayBizUserList extends Model
{
    /**
     * @var string
     */
    public $alipayUserId;

    /**
     * @var string
     */
    public $dingUserId;
    protected $_name = [
        'alipayUserId' => 'alipayUserId',
        'dingUserId' => 'dingUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayUserId) {
            $res['alipayUserId'] = $this->alipayUserId;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return alipayBizUserList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alipayUserId'])) {
            $model->alipayUserId = $map['alipayUserId'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }

        return $model;
    }
}
