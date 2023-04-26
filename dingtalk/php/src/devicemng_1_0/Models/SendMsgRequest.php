<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMsgRequest extends Model
{
    /**
     * @example text
     *
     * @var string
     */
    public $content;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $deviceUuid;

    /**
     * @example cidxxxxxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
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
