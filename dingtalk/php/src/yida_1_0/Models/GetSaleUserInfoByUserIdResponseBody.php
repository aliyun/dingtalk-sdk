<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdResponseBody\corpList;
use AlibabaCloud\Tea\Model;

class GetSaleUserInfoByUserIdResponseBody extends Model
{
    /**
     * @description userName
     *
     * @var string
     */
    public $userName;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description accountId
     *
     * @var int
     */
    public $accountId;

    /**
     * @description corpList
     *
     * @var corpList[]
     */
    public $corpList;
    protected $_name = [
        'userName'  => 'userName',
        'userId'    => 'userId',
        'accountId' => 'accountId',
        'corpList'  => 'corpList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->corpList) {
            $res['corpList'] = [];
            if (null !== $this->corpList && \is_array($this->corpList)) {
                $n = 0;
                foreach ($this->corpList as $item) {
                    $res['corpList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSaleUserInfoByUserIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['corpList'])) {
            if (!empty($map['corpList'])) {
                $model->corpList = [];
                $n               = 0;
                foreach ($map['corpList'] as $item) {
                    $model->corpList[$n++] = null !== $item ? corpList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
