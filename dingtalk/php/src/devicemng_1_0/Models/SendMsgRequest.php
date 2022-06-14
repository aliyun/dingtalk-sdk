<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMsgRequest extends Model
{
    /**
     * @description 消息内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 设备业务标识
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @description 设备唯一系统标识
     *
     * @var string
     */
    public $deviceUuid;

    /**
     * @description 开放群唯一标识
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 用户列表，群聊时为被@的人，单聊时为目标对象
     *
     * @var string[]
     */
    public $userList;
    protected $_name = [
        'content'            => 'content',
        'deviceCode'         => 'deviceCode',
        'deviceUuid'         => 'deviceUuid',
        'openConversationId' => 'openConversationId',
        'userList'           => 'userList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->deviceUuid) {
            $res['deviceUuid'] = $this->deviceUuid;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userList) {
            $res['userList'] = $this->userList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMsgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceUuid'])) {
            $model->deviceUuid = $map['deviceUuid'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = $map['userList'];
            }
        }

        return $model;
    }
}
