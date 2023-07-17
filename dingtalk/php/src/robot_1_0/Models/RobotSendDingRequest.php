<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class RobotSendDingRequest extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @example 1:APP，2:短信，3:电话
     *
     * @var int
     */
    public $remindType;

    /**
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'content'            => 'content',
        'receiverUserIdList' => 'receiverUserIdList',
        'remindType'         => 'remindType',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->receiverUserIdList) {
            $res['receiverUserIdList'] = $this->receiverUserIdList;
        }
        if (null !== $this->remindType) {
            $res['remindType'] = $this->remindType;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotSendDingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['receiverUserIdList'])) {
            if (!empty($map['receiverUserIdList'])) {
                $model->receiverUserIdList = $map['receiverUserIdList'];
            }
        }
        if (isset($map['remindType'])) {
            $model->remindType = $map['remindType'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
