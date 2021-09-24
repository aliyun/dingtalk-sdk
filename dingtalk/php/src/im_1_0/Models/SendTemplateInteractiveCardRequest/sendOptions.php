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
     * @description 是否@所有人
     *
     * @var bool
     */
    public $atAll;

    /**
     * @description 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
     *
     * @var string
     */
    public $receiverListJson;

    /**
     * @description 卡片特殊属性json串
     *
     * @var string
     */
    public $cardPropertyJson;
    protected $_name = [
        'atUserListJson'   => 'atUserListJson',
        'atAll'            => 'atAll',
        'receiverListJson' => 'receiverListJson',
        'cardPropertyJson' => 'cardPropertyJson',
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
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->receiverListJson) {
            $res['receiverListJson'] = $this->receiverListJson;
        }
        if (null !== $this->cardPropertyJson) {
            $res['cardPropertyJson'] = $this->cardPropertyJson;
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
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['receiverListJson'])) {
            $model->receiverListJson = $map['receiverListJson'];
        }
        if (isset($map['cardPropertyJson'])) {
            $model->cardPropertyJson = $map['cardPropertyJson'];
        }

        return $model;
    }
}
