<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdResponseBody\corpList;
use AlibabaCloud\Tea\Model;

class GetSaleUserInfoByUserIdResponseBody extends Model
{
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

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description userName
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'accountId' => 'accountId',
        'corpList'  => 'corpList',
        'userId'    => 'userId',
        'userName'  => 'userName',
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
        if (null !== $this->corpList) {
            $res['corpList'] = [];
            if (null !== $this->corpList && \is_array($this->corpList)) {
                $n = 0;
                foreach ($this->corpList as $item) {
                    $res['corpList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
