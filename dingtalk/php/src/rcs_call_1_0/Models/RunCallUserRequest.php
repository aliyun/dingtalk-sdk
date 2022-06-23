<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models;

use AlibabaCloud\Tea\Model;

class RunCallUserRequest extends Model
{
    /**
     * @description 授权isv套件企业的corpid
     *
     * @var string
     */
    public $authorizeCorpId;

    /**
     * @description 授权isv套件企业的员工userid
     *
     * @var string
     */
    public $authorizeUserId;

    /**
     * @description 订单id
     *
     * @var string
     */
    public $orderId;

    /**
     * @description isv套件所属企业下的员工userid
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'authorizeCorpId' => 'authorizeCorpId',
        'authorizeUserId' => 'authorizeUserId',
        'orderId'         => 'orderId',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorizeCorpId) {
            $res['authorizeCorpId'] = $this->authorizeCorpId;
        }
        if (null !== $this->authorizeUserId) {
            $res['authorizeUserId'] = $this->authorizeUserId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RunCallUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorizeCorpId'])) {
            $model->authorizeCorpId = $map['authorizeCorpId'];
        }
        if (isset($map['authorizeUserId'])) {
            $model->authorizeUserId = $map['authorizeUserId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
