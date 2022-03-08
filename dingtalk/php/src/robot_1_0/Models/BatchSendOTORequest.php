<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchSendOTORequest extends Model
{
    /**
     * @description 消息的msgKey
     *
     * @var string
     */
    public $msgKey;

    /**
     * @description 消息体
     *
     * @var string
     */
    public $msgParam;

    /**
     * @description 机器人的robotCode
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 被推送会话人员的userId列表
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'msgKey'    => 'msgKey',
        'msgParam'  => 'msgParam',
        'robotCode' => 'robotCode',
        'userIds'   => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchSendOTORequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
