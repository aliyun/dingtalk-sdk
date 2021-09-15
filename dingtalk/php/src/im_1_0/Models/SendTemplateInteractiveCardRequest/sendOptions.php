<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardRequest;

use AlibabaCloud\Tea\Model;

class sendOptions extends Model
{
    /**
     * @description 消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
     *
     * @var string
     */
    public $atUserListJson;

    /**
     * @description 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
     *
     * @var string
     */
    public $receiverListJson;
    protected $_name = [
        'atUserListJson'   => 'atUserListJson',
        'receiverListJson' => 'receiverListJson',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atUserListJson) {
            $res['atUserListJson'] = $this->atUserListJson;
        }
        if (null !== $this->receiverListJson) {
            $res['receiverListJson'] = $this->receiverListJson;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sendOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atUserListJson'])) {
            $model->atUserListJson = $map['atUserListJson'];
        }
        if (isset($map['receiverListJson'])) {
            $model->receiverListJson = $map['receiverListJson'];
        }

        return $model;
    }
}
