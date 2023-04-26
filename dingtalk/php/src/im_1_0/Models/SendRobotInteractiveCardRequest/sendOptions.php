<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardRequest;

use AlibabaCloud\Tea\Model;

class sendOptions extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $atAll;

    /**
     * @example [{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
     *
     * @var string
     */
    public $atUserListJson;

    /**
     * @example {}
     *
     * @var string
     */
    public $cardPropertyJson;

    /**
     * @example [{"userId":"userId0001"},{"unionId":"unionId001"}]
     *
     * @var string
     */
    public $receiverListJson;
    protected $_name = [
        'atAll'            => 'atAll',
        'atUserListJson'   => 'atUserListJson',
        'cardPropertyJson' => 'cardPropertyJson',
        'receiverListJson' => 'receiverListJson',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->atUserListJson) {
            $res['atUserListJson'] = $this->atUserListJson;
        }
        if (null !== $this->cardPropertyJson) {
            $res['cardPropertyJson'] = $this->cardPropertyJson;
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
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['atUserListJson'])) {
            $model->atUserListJson = $map['atUserListJson'];
        }
        if (isset($map['cardPropertyJson'])) {
            $model->cardPropertyJson = $map['cardPropertyJson'];
        }
        if (isset($map['receiverListJson'])) {
            $model->receiverListJson = $map['receiverListJson'];
        }

        return $model;
    }
}
