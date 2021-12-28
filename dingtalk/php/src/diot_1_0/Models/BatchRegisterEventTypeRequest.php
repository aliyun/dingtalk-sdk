<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterEventTypeRequest\eventTypes;
use AlibabaCloud\Tea\Model;

class BatchRegisterEventTypeRequest extends Model
{
    /**
     * @description 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 事件类型列表，最多支持添加500个。
     *
     * @var eventTypes[]
     */
    public $eventTypes;
    protected $_name = [
        'corpId'     => 'corpId',
        'eventTypes' => 'eventTypes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->eventTypes) {
            $res['eventTypes'] = [];
            if (null !== $this->eventTypes && \is_array($this->eventTypes)) {
                $n = 0;
                foreach ($this->eventTypes as $item) {
                    $res['eventTypes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRegisterEventTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['eventTypes'])) {
            if (!empty($map['eventTypes'])) {
                $model->eventTypes = [];
                $n                 = 0;
                foreach ($map['eventTypes'] as $item) {
                    $model->eventTypes[$n++] = null !== $item ? eventTypes::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
