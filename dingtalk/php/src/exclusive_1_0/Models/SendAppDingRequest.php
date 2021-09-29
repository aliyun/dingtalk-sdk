<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendAppDingRequest extends Model
{
    /**
     * @description 接收DING消息的用户列表
     *
     * @var string[]
     */
    public $userids;

    /**
     * @description 消息内容
     *
     * @var string
     */
    public $content;
    protected $_name = [
        'userids' => 'userids',
        'content' => 'content',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userids) {
            $res['userids'] = $this->userids;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendAppDingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userids'])) {
            if (!empty($map['userids'])) {
                $model->userids = $map['userids'];
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }

        return $model;
    }
}
