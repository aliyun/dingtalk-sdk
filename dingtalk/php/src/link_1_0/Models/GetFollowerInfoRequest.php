<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFollowerInfoRequest extends Model
{
    /**
     * @example ding1234
     *
     * @var string
     */
    public $accountId;

    /**
     * @example UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ
     *
     * @var string
     */
    public $unionId;

    /**
     * @example Rp3Rqcts7BE08y49Jr6iu6xW4iQ
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accountId' => 'accountId',
        'unionId'   => 'unionId',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFollowerInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
