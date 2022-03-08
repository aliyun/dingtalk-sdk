<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageRequest\detail\messageBody;
use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @description 业务请求标识，当一次业务请求需要多次调用发送API时可以设置此参数，方便后续跟踪处理。
     *
     * @var string
     */
    public $bizRequestId;

    /**
     * @description 消息体
     *
     * @var messageBody
     */
    public $messageBody;

    /**
     * @description 消息类型
     *
     * @var string
     */
    public $msgType;

    /**
     * @description 全员群发
     *
     * @var bool
     */
    public $sendToAll;

    /**
     * @description 消息接收人列表，最多支持1000人
     *
     * @var string[]
     */
    public $userIdList;

    /**
     * @description 消息请求唯一ID
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'bizRequestId' => 'bizRequestId',
        'messageBody'  => 'messageBody',
        'msgType'      => 'msgType',
        'sendToAll'    => 'sendToAll',
        'userIdList'   => 'userIdList',
        'uuid'         => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizRequestId) {
            $res['bizRequestId'] = $this->bizRequestId;
        }
        if (null !== $this->messageBody) {
            $res['messageBody'] = null !== $this->messageBody ? $this->messageBody->toMap() : null;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->sendToAll) {
            $res['sendToAll'] = $this->sendToAll;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizRequestId'])) {
            $model->bizRequestId = $map['bizRequestId'];
        }
        if (isset($map['messageBody'])) {
            $model->messageBody = messageBody::fromMap($map['messageBody']);
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['sendToAll'])) {
            $model->sendToAll = $map['sendToAll'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
