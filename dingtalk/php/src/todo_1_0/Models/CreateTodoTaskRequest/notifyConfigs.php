<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest;

use AlibabaCloud\Tea\Model;

class notifyConfigs extends Model
{
    /**
     * @description 是否发送单聊卡片：value:"true/false" （发送则传true）
     *
     * @var string
     */
    public $singleChat;

    /**
     * @description 是否发送群聊卡片：value:"groupId"（发送则传对应群聊id）
     *
     * @var string
     */
    public $groupChat;

    /**
     * @description ding通知配置：value:"channel"（1钉弹框通知，2钉短信通知，3钉电话通知）
     *
     * @var string
     */
    public $dingNotify;

    /**
     * @description 是否同步到日历：value:"true/false"（同步则传true）
     *
     * @var string
     */
    public $canlender;
    protected $_name = [
        'singleChat' => 'singleChat',
        'groupChat'  => 'groupChat',
        'dingNotify' => 'dingNotify',
        'canlender'  => 'canlender',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->singleChat) {
            $res['singleChat'] = $this->singleChat;
        }
        if (null !== $this->groupChat) {
            $res['groupChat'] = $this->groupChat;
        }
        if (null !== $this->dingNotify) {
            $res['dingNotify'] = $this->dingNotify;
        }
        if (null !== $this->canlender) {
            $res['canlender'] = $this->canlender;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notifyConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['singleChat'])) {
            $model->singleChat = $map['singleChat'];
        }
        if (isset($map['groupChat'])) {
            $model->groupChat = $map['groupChat'];
        }
        if (isset($map['dingNotify'])) {
            $model->dingNotify = $map['dingNotify'];
        }
        if (isset($map['canlender'])) {
            $model->canlender = $map['canlender'];
        }

        return $model;
    }
}
