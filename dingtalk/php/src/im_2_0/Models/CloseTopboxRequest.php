<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models;

use AlibabaCloud\Tea\Model;

class CloseTopboxRequest extends Model
{
    /**
     * @description 会话类型。
     *
     * @var int
     */
    public $conversationType;

    /**
     * @description 酷应用编码。
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description 群模板id。
     *
     * @var string
     */
    public $groupTemplateId;

    /**
     * @description 会话id。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 唯一标识一张卡片的外部ID。
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description 单聊助手会话，机器人编码。
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 单聊助手会话，用户unionId。
     *
     * @var string
     */
    public $unoinId;

    /**
     * @description 单聊助手会话，用户userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'conversationType'   => 'conversationType',
        'coolAppCode'        => 'coolAppCode',
        'groupTemplateId'    => 'groupTemplateId',
        'openConversationId' => 'openConversationId',
        'outTrackId'         => 'outTrackId',
        'robotCode'          => 'robotCode',
        'unoinId'            => 'unoinId',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->unoinId) {
            $res['unoinId'] = $this->unoinId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CloseTopboxRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationType'])) {
            $model->conversationType = $map['conversationType'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['unoinId'])) {
            $model->unoinId = $map['unoinId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
