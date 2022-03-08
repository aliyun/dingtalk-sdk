<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest\sceneContext;

use AlibabaCloud\Tea\Model;

class groupMsgs extends Model
{
    /**
     * @description 是否为锚点消息
     *
     * @var bool
     */
    public $anchor;

    /**
     * @description 勾选消息openMsgId
     *
     * @var string
     */
    public $openMsgId;
    protected $_name = [
        'anchor'    => 'anchor',
        'openMsgId' => 'openMsgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->anchor) {
            $res['anchor'] = $this->anchor;
        }
        if (null !== $this->openMsgId) {
            $res['openMsgId'] = $this->openMsgId;
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
        if (isset($map['anchor'])) {
            $model->anchor = $map['anchor'];
        }
        if (isset($map['openMsgId'])) {
            $model->openMsgId = $map['openMsgId'];
        }

        return $model;
    }
}
