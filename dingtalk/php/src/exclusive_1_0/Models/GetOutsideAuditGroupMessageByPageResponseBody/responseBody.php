<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageResponseBody\responseBody\messageList;
use AlibabaCloud\Tea\Model;

class responseBody extends Model
{
    /**
     * @description 消息列表
     *
     * @var messageList[]
     */
    public $messageList;

    /**
     * @description 下一次请求的token,无返回值则下一条消息不存在
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'messageList' => 'messageList',
        'nextToken'   => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageList) {
            $res['messageList'] = [];
            if (null !== $this->messageList && \is_array($this->messageList)) {
                $n = 0;
                foreach ($this->messageList as $item) {
                    $res['messageList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return responseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageList'])) {
            if (!empty($map['messageList'])) {
                $model->messageList = [];
                $n                  = 0;
                foreach ($map['messageList'] as $item) {
                    $model->messageList[$n++] = null !== $item ? messageList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
