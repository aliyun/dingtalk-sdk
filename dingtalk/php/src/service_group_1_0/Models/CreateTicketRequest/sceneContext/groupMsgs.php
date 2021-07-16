<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest\sceneContext;

use AlibabaCloud\Tea\Model;

class groupMsgs extends Model
{
    /**
     * @description 勾选消息openMsgId
     *
     * @var string
     */
    public $openMsgId;

    /**
     * @description 是否为锚点消息
     *
     * @var bool
     */
    public $anchor;
    protected $_name = [
        'openMsgId' => 'openMsgId',
        'anchor'    => 'anchor',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openMsgId) {
            $res['openMsgId'] = $this->openMsgId;
        }
        if (null !== $this->anchor) {
            $res['anchor'] = $this->anchor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupMsgs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openMsgId'])) {
            $model->openMsgId = $map['openMsgId'];
        }
        if (isset($map['anchor'])) {
            $model->anchor = $map['anchor'];
        }

        return $model;
    }
}
