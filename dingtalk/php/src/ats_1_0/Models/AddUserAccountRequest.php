<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddUserAccountRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example 示例昵称xxx
     *
     * @var string
     */
    public $channelAccountName;

    /**
     * @example 6FSe51616SOdd394d6
     *
     * @var string
     */
    public $channelUserIdentify;

    /**
     * @example 16600010001
     *
     * @var string
     */
    public $phoneNumber;

    /**
     * @example ding123456789
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1676451039
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode' => 'bizCode',
        'channelAccountName' => 'channelAccountName',
        'channelUserIdentify' => 'channelUserIdentify',
        'phoneNumber' => 'phoneNumber',
        'corpId' => 'corpId',
        'userId' => 'userId',
    ];

    public function validate() {}

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
