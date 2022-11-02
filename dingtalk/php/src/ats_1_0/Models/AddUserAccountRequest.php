<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddUserAccountRequest extends Model
{
    /**
     * @description 业务标识
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 渠道账号名
     *
     * @var string
     */
    public $channelAccountName;

    /**
     * @description 渠道用户标识
     *
     * @var string
     */
    public $channelUserIdentify;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $phoneNumber;

    /**
     * @description 企业标识
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 用户标识
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode'             => 'bizCode',
        'channelAccountName'  => 'channelAccountName',
        'channelUserIdentify' => 'channelUserIdentify',
        'phoneNumber'         => 'phoneNumber',
        'corpId'              => 'corpId',
        'userId'              => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->channelAccountName) {
            $res['channelAccountName'] = $this->channelAccountName;
        }
        if (null !== $this->channelUserIdentify) {
            $res['channelUserIdentify'] = $this->channelUserIdentify;
        }
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddUserAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['channelAccountName'])) {
            $model->channelAccountName = $map['channelAccountName'];
        }
        if (isset($map['channelUserIdentify'])) {
            $model->channelUserIdentify = $map['channelUserIdentify'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
