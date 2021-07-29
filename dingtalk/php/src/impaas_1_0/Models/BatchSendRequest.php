<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchSendRequest extends Model
{
    /**
     * @description 发送者，企业员工账号
     *
     * @var string
     */
    public $userId;

    /**
     * @description 接受者列表，外部用户
     *
     * @var string[]
     */
    public $appUids;

    /**
     * @description 消息内容
     *
     * @var string
     */
    public $content;
    protected $_name = [
        'userId'  => 'userId',
        'appUids' => 'appUids',
        'content' => 'content',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->appUids) {
            $res['appUids'] = $this->appUids;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchSendRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['appUids'])) {
            if (!empty($map['appUids'])) {
                $model->appUids = $map['appUids'];
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }

        return $model;
    }
}
