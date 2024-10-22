<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryReceiptForInvoiceResponseBody\list_;

use AlibabaCloud\Tea\Model;

class creator extends Model
{
    /**
     * @example https://xxxx
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @example 测试名字
     *
     * @var string
     */
    public $nick;

    /**
     * @example 1231
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatarUrl' => 'avatarUrl',
        'nick'      => 'nick',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return creator
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
